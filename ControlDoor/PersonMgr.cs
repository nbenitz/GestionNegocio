﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ControlDoor
{
    public class PersonMgr
    {
        ACEntities entities = new ACEntities();
        FingerPrintMgr fingerMgr = new FingerPrintMgr();
        Request req = new Request();

        #region _Gets_
        public string GetNextEmployeeNo()
        {
            string employeeNo = "";
            CUserInfoSearch UserData = GetAllUsers();
            try
            {
                if (UserData.UserInfo.Count == UserData.totalMatches)
                {
                    int i = UserData.UserInfo.Count - 1;
                    CUserInfo userInfo = UserData.UserInfo[i];
                    employeeNo = (Int32.Parse(userInfo.employeeNo) + 1).ToString();
                }
            }
            catch {}

            return employeeNo; 
        }

        public string GetOneEmployeeNo()
        {
            string employeeNo = "0";
            var url = "http://192.168.0.3/ISAPI/AccessControl/UserInfo/Search?format=json";
            List<CEmployeeNoList> employeeNoLists = new List<CEmployeeNoList>();
            //Obj de respuesta
            CUserInfoSearchResult objUserData;
            try
            {
                Random r = new Random();
                int searchID = r.Next(0, 1000);
                int startPosition = 100;
                string JsonUserSearchCond = entities.SerializeUserSearchCond(searchID.ToString(), startPosition, 1, employeeNoLists);
                string JsonUserSearchResult = req.PostRequest(url, JsonUserSearchCond).Result;
                objUserData = JsonConvert.DeserializeObject<CUserInfoSearchResult>(JsonUserSearchResult);
                CUserInfo userInfo = objUserData.UserInfoSearch.UserInfo[0];
                employeeNo = userInfo.employeeNo;
                return employeeNo;
            }
            catch (Exception e)
            {
                //ShowMessage("Error: " + e);
            }
            return employeeNo;
        }

        public CUserInfoSearch GetAllUsers()
        {
            var url = "http://192.168.0.3/ISAPI/AccessControl/UserInfo/Search?format=json";
            List<CEmployeeNoList> employeeNoLists = new List<CEmployeeNoList>();

            //Obj de respuesta
            CUserInfoSearchResult objUserData = entities.InitUserSearchResult();

            try
            {
                Random r = new Random();
                int searchID = r.Next(0, 1000);

                int startPosition = 0;
                bool flag = true;
                while (flag)
                {
                    string JsonUserSearchCond = entities.SerializeUserSearchCond(searchID.ToString(), startPosition, 10, employeeNoLists);
                    string JsonUserSearchResult = req.PostRequest(url, JsonUserSearchCond).Result;
                    if (objUserData.UserInfoSearch.searchID == null)
                    {
                        objUserData = JsonConvert.DeserializeObject<CUserInfoSearchResult>(JsonUserSearchResult);
                    }
                    else
                    {
                        CUserInfoSearchResult objUserDataNew;
                        objUserDataNew = JsonConvert.DeserializeObject<CUserInfoSearchResult>(JsonUserSearchResult);
                        if (objUserDataNew.UserInfoSearch.numOfMatches > 0)
                        {
                            objUserData.UserInfoSearch.UserInfo.AddRange(objUserDataNew.UserInfoSearch.UserInfo);
                        }
                        else
                        {
                            ;
                        }
                        if (objUserDataNew.UserInfoSearch.responseStatusStrg == "OK") flag = false;

                    }
                    startPosition = objUserData.UserInfoSearch.UserInfo.Count;
                    Thread.Sleep(100);
                }
            }
            catch (Exception e)
            {
                //objUserData = new CUserInfoSearchResult();
                ;
            }
            return objUserData.UserInfoSearch;
        }

        public int GetUserCount()
        {
            int count = -1;
            var url = "http://192.168.0.3/ISAPI/AccessControl/UserInfo/Count?format=json";
            try
            {
                string JsonUserCountResult = req.GetRequest(url);
                CUserInfoCount userInfoCount;
                userInfoCount = JsonConvert.DeserializeObject<CUserInfoCount>(JsonUserCountResult);
                return userInfoCount.UserInfoCount.UserNumber;
            }
            catch (Exception e)
            {
                //ShowMessage("Error: " + e);
            }
            return count;
        }
        #endregion


        #region _Sets_
        public string SetUserInfo(string name, string employeeNo)
        {
            string status = "";
            var url = "http://192.168.0.3/ISAPI/AccessControl/UserInfo/Record?format=json";

            string beginTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            string endTime = DateTime.Now.AddYears(10).ToString("yyyy-MM-ddTHH:mm:ss");

            CUserInfoCfg JsonUserInfo = new CUserInfoCfg();
            JsonUserInfo.UserInfo = new CUserInfo();
            JsonUserInfo.UserInfo.employeeNo = employeeNo;
            JsonUserInfo.UserInfo.name = name;
            JsonUserInfo.UserInfo.userType = "normal";
            JsonUserInfo.UserInfo.Valid = new CValid();
            JsonUserInfo.UserInfo.Valid.enable = true;
            JsonUserInfo.UserInfo.Valid.beginTime = beginTime;
            JsonUserInfo.UserInfo.Valid.endTime = endTime;
            JsonUserInfo.UserInfo.Valid.timeType = "local";
            JsonUserInfo.UserInfo.RightPlan = new List<CRightPlan>();
            JsonUserInfo.UserInfo.doorRight = "1"; //Asegúrese de configurarlo, si no, se le indicará que no tiene permiso.
            CRightPlan JsonRightPlan = new CRightPlan();
            JsonRightPlan.doorNo = 1;
            JsonRightPlan.planTemplateNo = "1";
            JsonUserInfo.UserInfo.RightPlan.Add(JsonRightPlan);
            // JsonUserInfo.UserInfo.userVerifyMode = "face";
            string JsonData = JsonConvert.SerializeObject(JsonUserInfo, Formatting.Indented,
                                                        new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            string JsonResult = req.PostRequest(url, JsonData).Result;
            try
            {
                CJSON_ResponseStatus responseStatus = JsonConvert.DeserializeObject<CJSON_ResponseStatus>(JsonResult);
                if (responseStatus.statusString == "OK") status = "OK";
            }
            catch (Exception e)
            {
                status = e.Message;
            }
            return status;
        }

        private void BackUp()
        {
            CUserInfoSearch UserData = GetAllUsers();

            using (var db = new minegocioEntities())
            {
                List<acceso> accesoList = new List<acceso>();
                for (int i = 0; i < UserData.UserInfo.Count; i++)
                {
                    acceso _acceso = new acceso
                    {
                        codigo = UserData.UserInfo[i].employeeNo,
                        nombre = UserData.UserInfo[i].name,
                    };
                    accesoList.Add(_acceso);

                    List<string> FPDataList = fingerMgr.GetFinger(UserData.UserInfo[i].employeeNo);
                    if (FPDataList.Count > 0)
                    {
                        List<finger_print> fp_list = new List<finger_print>();
                        List<acceso_finger_print> acceso_fp_list = new List<acceso_finger_print>();
                        for (int j = 0; j < FPDataList.Count; j++)
                        {
                            finger_print FP = new finger_print
                            {
                                fp_data = FPDataList[j]
                            };
                            fp_list.Add(FP);

                            acceso_finger_print acceso_FP = new acceso_finger_print
                            {
                                acceso = _acceso,
                                finger_print = FP
                            };
                            acceso_fp_list.Add(acceso_FP);
                        }
                        db.finger_print.AddRange(fp_list);
                        db.acceso_finger_print.AddRange(acceso_fp_list);
                    }
                }

                db.acceso.AddRange(accesoList);
                db.SaveChanges();
            }
        }

        #endregion
    }
}