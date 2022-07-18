using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDoor
{
    class ACEntities
    {
        public string SerializeUserSearchCond(string searchID, int startPosition, int maxResult, List<CEmployeeNoList> employeeNoLists)
        {
            //Obj de solicitud
            CUserInfoSearchCondCfg UsrSearchCond = new CUserInfoSearchCondCfg();
            UsrSearchCond.UserInfoSearchCond = new CUserInfoSearchCond();
            UsrSearchCond.UserInfoSearchCond.searchID = searchID;
            UsrSearchCond.UserInfoSearchCond.searchResultPosition = startPosition;
            UsrSearchCond.UserInfoSearchCond.maxResults = maxResult;
            UsrSearchCond.UserInfoSearchCond.EmployeeNoList = employeeNoLists;
            //Json de solicitud
            string JsonUserSearchCond = JsonConvert.SerializeObject(UsrSearchCond, Formatting.Indented);
            return JsonUserSearchCond;
        }

        public CUserInfoSearchResult InitUserSearchResult()
        {
            CUserInfoSearchResult objUserData = new CUserInfoSearchResult();
            objUserData.UserInfoSearch = new CUserInfoSearch();
            objUserData.UserInfoSearch.UserInfo = new List<CUserInfo>();
            CUserInfo userInfo = new CUserInfo();
            userInfo.Valid = new CValid();
            userInfo.RightPlan = new List<CRightPlan>();
            objUserData.UserInfoSearch.UserInfo.Add(userInfo);
            return objUserData;
        }
    }

     #region Clase de Entidad
    public class CUserInfoCfg
    {
        public CUserInfo UserInfo { get; set; }
    }

    public class CRightPlan
    {
        [DefaultValue(-1)]
        public int doorNo { get; set; }
        [DefaultValue(null)]
        public string planTemplateNo { get; set; }
    }

    public class CUserInfo
    {
        public string employeeNo { get; set; }
        public string name { get; set; }
        public string userType { get; set; }
        public bool closeDelayEnabled { get; set; }
        public CValid Valid { get; set; }
        public string belongGroup { get; set; }
        public string password { get; set; }
        public string doorRight { get; set; }
        public List<CRightPlan> RightPlan { get; set; }
        public int maxOpenDoorTime { get; set; }
        public int openDoorTime { get; set; }
        public int roomNumber { get; set; }
        public int floorNumber { get; set; }
        public bool doubleLockRight { get; set; }
        public bool alwaysOpenRight { get; set; }
        public bool localUIRight { get; set; }
        public string userVerifyMode { get; set; }
    }

    public class CValid
    {
        public bool enable { get; set; } //req
        public string beginTime { get; set; } //req
        public string endTime { get; set; } //req
        [DefaultValue(null)]
        public string timeType { get; set; }
    }

    public class CResponseStatus
    {
        public string requestURL { get; set; }
        public int statusCode { get; set; }
        public string statusString { get; set; }
        public string subStatusCode { get; set; }
        public int errorCode { get; set; }
        public string errorMsg { get; set; }
    }


    public class CCardInfoCfg
    {
        public CCardInfo CardInfo { get; set; }
    }

    public class CCardInfo
    {
        public string employeeNo { get; set; } //req
        public string cardNo { get; set; } //req
        public bool deleteCard { get; set; } //opt
        public string cardType { get; set; } //req
    }

    public class CSetFaceDataCond
    {
        public string faceLibType { get; set; } //req
        public string FDID { get; set; } //req
        public string FPID { get; set; } //opt
        public bool deleteFP { get; set; } //opt
    }

    public class CSearchFaceDataCond
    {
        public int searchResultPosition { get; set; } //req
        public int maxResults { get; set; } //req
        public string faceLibType { get; set; } //req
        public string FDID { get; set; } //req
        public string FPID { get; set; } //opt
    }

    public class CSearchFaceDataReturn
    {
        public string requestURL { get; set; } //opt
        public int statusCode { get; set; } //req
        public string statusString { get; set; } //req
        public string subStatusCode { get; set; } //req
        public int errorCode { get; set; } //opt
        public string errorMsg { get; set; } //opt
        public string responseStatusStrg { get; set; } //opt
        public int numOfMatches { get; set; } //opt
        public int totalMatches { get; set; } //opt
        public List<CMatchList> MatchList { get; set; } //opt
    }

    public class CMatchList
    {
        public string FPID { get; set; } //opt
        public int employeeNo { get; set; } //opt
    }


    public class CUserInfoCount
    {
        public CUserNumber UserInfoCount { get; set; }
    }

    public class CUserNumber
    {
        public int UserNumber { get; set; }
    }

    public class CUserInfoSearchCondCfg
    {
        public CUserInfoSearchCond UserInfoSearchCond { get; set; } //req
    }

    public class CUserInfoSearchCond
    {
        public string searchID { get; set; } //req
        public Int32 searchResultPosition { get; set; } //req
        public Int32 maxResults { get; set; } //req
        public List<CEmployeeNoList> EmployeeNoList { get; set; } //opt
    }

    public class CEmployeeNoList
    {
        public string employeeNo { get; set; } //opt
    }


    public class CUserInfoSearchResult
    {
        public CUserInfoSearch UserInfoSearch { get; set; } //req
    }

    public class CUserInfoSearch
    {
        public string searchID { get; set; } //req
        public string responseStatusStrg { get; set; } //req
        public Int32 numOfMatches { get; set; } //req
        public Int32 totalMatches { get; set; } //req
        public List<CUserInfo> UserInfo { get; set; } //opt
    }

    public class CJSON_ResponseStatus
    {
        public string requestURL { get; set; } //req
        public Int32 statusCode { get; set; } //req
        public string statusString { get; set; } //req
        public string subStatusCode { get; set; } //opt
        public int errorCode { get; set; } //req
        public string errorMsg { get; set; } //opt
        public string MErrCode { get; set; } //opt
        public string MErrDevSelfEx { get; set; } //opt
    }

    public class JSON_FingerPrintCfg
    {
        public CFingerPrintCfg FingerPrintCfg { get; set; } //req
    }

    public class CFingerPrintCfg
    {
        public string employeeNo { get; set; } //req
        public List<int> enableCardReader { get; set; } //req
        public int fingerPrintID { get; set; } //req
        public Boolean deleteFingerPrint { get; set; } //opt
        public string fingerType { get; set; } //req
        public string fingerData { get; set; } //opt
        public List<int> leaderFP { get; set; } //req
        public bool checkEmployeeNo { get; set; } //opt
    }

    public class JSON_FingerPrintStatus
    {
        public CFingerPrintStatus FingerPrintStatus { get; set; } //req
    }

    public class CFingerPrintStatus
    {
        public string status { get; set; } /*opt, status: "success", "failed". This node will be returned only when editing fingerprint parameters or deleting fingerprints; for applying fingerprint data to the fingerprint module, this node will not be returned*/
        public List<CStatusList> StatusList { get; set; } /*optional, This node will be returned only when applying fingerprint data to the fingerprint module; for editing fingerprint parameters or deleting fingerprints, this node will not be returned*/

        public Int32 totalStatus { get; set; } /*req, applying status: 0-applying, 1-applied*/
    }

    public class CStatusList
    {
        public Int32 id { get; set; } //opt
        public Int32 cardReaderRecvStatus { get; set; } //opt
        public Int32 errorMsg { get; set; } //opt
    }

    public class JSON_FingerPrintCond
    {
        public CFingerPrintCond FingerPrintCond { get; set; } //req
    }

    public class CFingerPrintCond
    {
        public string searchID { get; set; } 
        public string employeeNo { get; set; } 
        public Int32 cardReaderNo { get; set; } 
        public Int32 fingerPrintID { get; set; }
    }

    public class JSON_FingerPrintInfo
    {
        public CFingerPrintInfo FingerPrintInfo { get; set; } //req
    }

    public class CFingerPrintInfo
    {
        public string searchID { get; set; }
        public string status { get; set; }
        public List<CFingerPrintList> FingerPrintList { get; set; } 
    }

    public class CFingerPrintList
    {
        public Int32 cardReaderNo { get; set; } //opt
        public Int32 fingerPrintID { get; set; } //opt
        public string fingerType { get; set; } //req
        public string fingerData { get; set; } //opt
        public List<int> leaderFP { get; set; } //req
    }

    public class JSON_FingerPrintDelete
    {
        public CFingerPrintDelete FingerPrintDelete { get; set; } //req
    }

    public class CFingerPrintDelete
    {
        public string mode { get; set; }    //req
        public CEmployeeNoDetail EmployeeNoDetail { get; set; }   //opt
        public CCardReaderDetail CardReaderDetail { get; set; }   //opt
    }

    public class CEmployeeNoDetail
    {
        public string employeeNo { get; set; } //opt
        public List<Int32> enableCardReader { get; set; } //opt
        public List<Int32> fingerPrintID { get; set; } //opt
    }

    public class CCardReaderDetail
    {
        public Int32 cardReaderNo { get; set; } //opt
        public Boolean clearAllCard { get; set; } //opt
        public string employeeNo { get; set; } //opt
    }

    public class JSON_UserInfoDelCond
    {
        public CUserInfoDelCond UserInfoDelCond { get; set; } //req
    }

    public class CUserInfoDelCond
    {
        public List<CEmployeeNoList> EmployeeNoList { get; set; } //opt //opt
    }

    #endregion
}
