using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;
using System.IO;


namespace ControlDoor
{
    public partial class EventByDeploy : Form
    {
        AddDevice deviceAdd = new AddDevice();

        public static int m_UserID = -1;
        private CHCNetSDK2.MSGCallBack m_falarmData = null;
        private string ShowData = null;

        public delegate void MensajeRecibido(DateTime tiempo, uint codigo);
        public event MensajeRecibido MsgRecibido;

        public delegate void SetMessageCallBackSucc();
        public event SetMessageCallBackSucc CallBackSucc;

        public delegate void LoginCallBackSuccess();
        public event LoginCallBackSuccess LoginSuccess;

        public delegate void LoginCallBackE();
        public event LoginCallBackE LoginErr;

        public EventByDeploy()
        {
            InitializeComponent();
            if (CHCNetSDK2.NET_DVR_Init() == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }

            deviceAdd.loginError += onLoginError;
            deviceAdd.loginSucc += onLoginSucc;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        public void init()
        {
            login();   
        }

        public void login()
        {
            Logout();
            deviceAdd.Login();
        }

        private void onLoginSucc()
        {
            m_UserID = deviceAdd.m_iUserID;
            deviceAdd.Dispose();
            LoginSuccess();
            deploy();
        }

        private void onLoginError()
        {
            m_UserID = deviceAdd.m_iUserID;
            deviceAdd.Dispose();
            LoginErr();
        }

        private void btnDeploy_Click(object sender, EventArgs e)
        {
            deploy();
        }

        public void deploy()
        {
            if (m_UserID < 0)
            {
                MessageBox.Show("Please Login First!");
                return;
            }
            else
            {
                CHCNetSDK2.NET_DVR_SETUPALARM_PARAM struSetupAlarmParam = new CHCNetSDK2.NET_DVR_SETUPALARM_PARAM();
                struSetupAlarmParam.dwSize = (uint)Marshal.SizeOf(struSetupAlarmParam);
                struSetupAlarmParam.byLevel = 1;
                struSetupAlarmParam.byAlarmInfoType = 1;
                struSetupAlarmParam.byDeployType = 1;

                if (CHCNetSDK2.NET_DVR_SetupAlarmChan_V41(m_UserID, ref struSetupAlarmParam) < 0)
                {
                    MessageBox.Show("NET_DVR_SetupAlarmChan_V41 fail error: " + CHCNetSDK2.NET_DVR_GetLastError(), "Setup alarm chan failed");
                    return;
                }
                //else
                //{
                //    MessageBox.Show("Setup alarm chan succeed");
                //}

                m_falarmData = new CHCNetSDK2.MSGCallBack(MsgCallback);
                if (CHCNetSDK2.NET_DVR_SetDVRMessageCallBack_V50(0, m_falarmData, IntPtr.Zero))
                {
                    //MessageBox.Show("NET_DVR_SetDVRMessageCallBack_V50 succ", "succ", MessageBoxButtons.OK);
                    CallBackSucc();
                }
                else
                {
                    MessageBox.Show("NET_DVR_SetDVRMessageCallBack_V50 fail", "operation fail", MessageBoxButtons.OK);
                }
            }
        }

        private void MsgCallback(int lCommand, ref CHCNetSDK2.NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser)
        {
            switch (lCommand)
            {
                case CHCNetSDK2.COMM_ALARM_ACS:
                    ProcessCommAlarmACS(ref pAlarmer, pAlarmInfo, dwBufLen, pUser);
                    break;
                default:
                    break;
            }
        }

        private void ProcessCommAlarmACS(ref CHCNetSDK2.NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser)
        {
            CHCNetSDK2.NET_DVR_ACS_ALARM_INFO struAcsAlarmInfo = new CHCNetSDK2.NET_DVR_ACS_ALARM_INFO();
            struAcsAlarmInfo = (CHCNetSDK2.NET_DVR_ACS_ALARM_INFO)Marshal.PtrToStructure(pAlarmInfo, typeof(CHCNetSDK2.NET_DVR_ACS_ALARM_INFO));

            /*
            CHCNetSDK2.NET_DVR_LOG_V30 struFileInfo = new CHCNetSDK2.NET_DVR_LOG_V30();
            struFileInfo.dwMajorType = struAcsAlarmInfo.dwMajor;
            struFileInfo.dwMinorType = struAcsAlarmInfo.dwMinor;
            char[] csTmp = new char[256];

            if (CHCNetSDK2.MAJOR_ALARM == struFileInfo.dwMajorType)
            {
                TypeMap.AlarmMinorTypeMap(struFileInfo, csTmp);
            }
            else if (CHCNetSDK2.MAJOR_OPERATION == struFileInfo.dwMajorType)
            {
                TypeMap.OperationMinorTypeMap(struFileInfo, csTmp);
            }
            else if (CHCNetSDK2.MAJOR_EXCEPTION == struFileInfo.dwMajorType)
            {
                TypeMap.ExceptionMinorTypeMap(struFileInfo, csTmp);
            }
            else if (CHCNetSDK2.MAJOR_EVENT == struFileInfo.dwMajorType)
            {
                TypeMap.EventMinorTypeMap(struFileInfo, csTmp);
            }

            String szInfo = new String(csTmp).TrimEnd('\0');
            String szInfoBuf = null;
            szInfoBuf = szInfo;

            /**************************************************
            String name = System.Text.Encoding.UTF8.GetString(struAcsAlarmInfo.sNetUser).TrimEnd('\0');
            for (int i = 0; i < struAcsAlarmInfo.sNetUser.Length; i++)
            {
                if (struAcsAlarmInfo.sNetUser[i] == 0)
                {
                    name = name.Substring(0, i);
                    break;
                }
            }
            /**************************************************

            szInfoBuf = string.Format("{0,4}-{1:D2}-{2} {3:D2}:{4:D2}:{5:D2}", struAcsAlarmInfo.struTime.dwYear, struAcsAlarmInfo.struTime.dwMonth,
                struAcsAlarmInfo.struTime.dwDay, struAcsAlarmInfo.struTime.dwHour, struAcsAlarmInfo.struTime.dwMinute, struAcsAlarmInfo.struTime.dwSecond);
            String tiempo = szInfoBuf;
            
            if (struAcsAlarmInfo.struAcsEventInfo.byCardNo[0] != 0)
            {
                szInfoBuf = szInfoBuf + "+Card Number:" + System.Text.Encoding.UTF8.GetString(struAcsAlarmInfo.struAcsEventInfo.byCardNo).TrimEnd('\0');
            }
            String[] szCardType = { "normal card", "disabled card", "blocklist card", "night watch card", "stress card", "super card", "guest card" };
            byte byCardType = struAcsAlarmInfo.struAcsEventInfo.byCardType;
             
            if (byCardType != 0 && byCardType <= szCardType.Length)
            {
                szInfoBuf = szInfoBuf + "+Card Type:" + szCardType[byCardType - 1];
            }

            if (struAcsAlarmInfo.struAcsEventInfo.dwCardReaderNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Card Reader Number:" + struAcsAlarmInfo.struAcsEventInfo.dwCardReaderNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwDoorNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Door Number:" + struAcsAlarmInfo.struAcsEventInfo.dwDoorNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwVerifyNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Multiple Card Authentication Serial Number:" + struAcsAlarmInfo.struAcsEventInfo.dwVerifyNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwAlarmInNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Alarm Input Number:" + struAcsAlarmInfo.struAcsEventInfo.dwAlarmInNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwAlarmOutNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Alarm Output Number:" + struAcsAlarmInfo.struAcsEventInfo.dwAlarmOutNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwCaseSensorNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Event Trigger Number:" + struAcsAlarmInfo.struAcsEventInfo.dwCaseSensorNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwRs485No != 0)
            {
                szInfoBuf = szInfoBuf + "+RS485 Channel Number:" + struAcsAlarmInfo.struAcsEventInfo.dwRs485No;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.dwMultiCardGroupNo != 0)
            {
                szInfoBuf = szInfoBuf + "+Multi Recombinant Authentication ID:" + struAcsAlarmInfo.struAcsEventInfo.dwMultiCardGroupNo;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.byCardReaderKind != 0)
            {
                szInfoBuf = szInfoBuf + "+CardReaderKind:" + struAcsAlarmInfo.struAcsEventInfo.byCardReaderKind.ToString();
            }
            if (struAcsAlarmInfo.struAcsEventInfo.wAccessChannel >= 0)
            {
                szInfoBuf = szInfoBuf + "+wAccessChannel:" + struAcsAlarmInfo.struAcsEventInfo.wAccessChannel;
            }

            if (struAcsAlarmInfo.struAcsEventInfo.dwEmployeeNo != 0)
            {
                szInfoBuf = szInfoBuf + "+EmployeeNo:" + struAcsAlarmInfo.struAcsEventInfo.dwEmployeeNo;
            }

            if (struAcsAlarmInfo.struAcsEventInfo.byDeviceNo != 0)
            {
                szInfoBuf = szInfoBuf + "+byDeviceNo:" +  struAcsAlarmInfo.struAcsEventInfo.byDeviceNo.ToString();
            }
            if (struAcsAlarmInfo.struAcsEventInfo.wLocalControllerID >= 0)
            {
                szInfoBuf = szInfoBuf + "+wLocalControllerID:" + struAcsAlarmInfo.struAcsEventInfo.wLocalControllerID;
            }
            if (struAcsAlarmInfo.struAcsEventInfo.byInternetAccess >= 0)
            {
                szInfoBuf = szInfoBuf + "+byInternetAccess:" + struAcsAlarmInfo.struAcsEventInfo.byInternetAccess.ToString();
            }
            if (struAcsAlarmInfo.struAcsEventInfo.byType >= 0)
            {
                szInfoBuf = szInfoBuf + "+byType:" + struAcsAlarmInfo.struAcsEventInfo.byType.ToString();
            }
            if (struAcsAlarmInfo.struAcsEventInfo.bySwipeCardType != 0)
            {
                szInfoBuf = szInfoBuf + "+bySwipeCardType:" + struAcsAlarmInfo.struAcsEventInfo.bySwipeCardType.ToString();
            }

            this.listViewAlarmInfo.BeginInvoke(new Action(() =>
            {
                ListViewItem Item = new ListViewItem();
                Item.Text = (++m_lLogNum).ToString();
                Item.SubItems.Add(DateTime.Now.ToString());
                Item.SubItems.Add(szInfoBuf);
                this.listViewAlarmInfo.Items.Add(Item);
            }));*/

            DateTime tiempo = new DateTime(
                struAcsAlarmInfo.struTime.dwYear,
                struAcsAlarmInfo.struTime.dwMonth,
                struAcsAlarmInfo.struTime.dwDay,
                struAcsAlarmInfo.struTime.dwHour,
                struAcsAlarmInfo.struTime.dwMinute,
                struAcsAlarmInfo.struTime.dwSecond);

            uint codigo = 0;
            if (struAcsAlarmInfo.struAcsEventInfo.dwEmployeeNo != 0)
            {
                codigo = struAcsAlarmInfo.struAcsEventInfo.dwEmployeeNo;
            }
            
            if (struAcsAlarmInfo.dwMajor == 0x5)
            {
                switch (struAcsAlarmInfo.dwMinor)
                {
                    case 0x26:  //MINOR_FINGERPRINT_COMPARE_PASS
                        MsgRecibido(tiempo, codigo);    
                        break;
                    case 0xB5:  //ACCESO POR CONTRASEÑA
                        MsgRecibido(tiempo, codigo);
                        break;
                    case 0x17:  //MINOR_DOOR_BUTTON_PRESS
                        OpenDoor();
                        break;
                    case 0x15:  //MINOR_LOCK_OPEN
                        //OpenDoor();
                        break;
                    case 0x16:  //MINOR_LOCK_CLOSE
                        //OpenDoor();
                        break;
                    case 0x1A:  //Sensor de Puerta
                        LookDoor();
                        break;
                    default:
                        // code block
                        break;
                }

                /*
                if (struAcsAlarmInfo.dwMinor == 0x26)    //MINOR_FINGERPRINT_COMPARE_PASS
                {
                    MsgRecibido(tiempo, codigo);
                }

                if (struAcsAlarmInfo.dwMinor == 0x17)   //MINOR_DOOR_BUTTON_PRESS
                {
                    OpenDoor();
                }*/
            }

        }

        private void listViewAlarmInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAlarmInfo.SelectedItems.Count > 0)
            {
                ShowData = null;
                ShowData = this.listViewAlarmInfo.FocusedItem.SubItems[2].Text.ToString();
                if (ShowData != null)
                {
                    ShowOtherData();
                }
            }
        }

        public void ShowOtherData()
        {
            if (!ShowData.Contains("EmployeeNo:"))
            {
                textBoxEmployeeNo.Text = null;
            }
            else
            {
                textBoxEmployeeNo.Text = MidStrEx(ShowData, "EmployeeNo:", "+");
            }

            if (!ShowData.Contains("Card Number:"))
            {
                textBoxCardNo.Text = null;
            }
            else
            {
                textBoxCardNo.Text = MidStrEx(ShowData, "Card Number:", "+");
            }

            if (!ShowData.Contains("time:"))
            {
                textBoxTime.Text = null;
            }
            else
            {
                textBoxTime.Text = MidStrEx(ShowData, "time:", ",");
            }
        }


        //本函数用于截取字符串
        public string MidStrEx(string sourse, string startstr, string endstr)
        {
            string result = string.Empty;
            int startindex, endindex;
            try
            {
                startindex = sourse.IndexOf(startstr);
                if (startindex == -1)
                    return result;
                string tmpstr = sourse.Substring(startindex + startstr.Length);
                endindex = tmpstr.IndexOf(endstr);
                if (endindex == -1)
                    return result;
                result = tmpstr.Remove(endindex);
            }
            catch (Exception e)
            {
                MessageBox.Show("MidStrEx Err:" + e.Message);
            }
            return result;
        }

        private void listViewAlarmInfo_DoubleClick(object sender, EventArgs e)
        {
            if (listViewAlarmInfo.SelectedItems.Count > 0)
            {
                MessageBox.Show(this.listViewAlarmInfo.FocusedItem.SubItems[2].Text.ToString(), "Alarm Info");
            }
        }

        private void EventByDeploy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_UserID >= 0)
            {
                CHCNetSDK2.NET_DVR_Logout_V30(m_UserID);
                m_UserID = -1;
            }
            CHCNetSDK2.NET_DVR_Cleanup();
        }

        private void EventByDeploy_Load(object sender, EventArgs e)
        {

        }

        public void Logout()
        {
            if (m_UserID >= 0)
            {
                CHCNetSDK2.NET_DVR_Logout_V30(m_UserID);
            }
        }

        public void OpenDoor()
        {
            if (CHCNetSDK2.NET_DVR_ControlGateway(m_UserID, 1, 1))
            {
                //MessageBox.Show("Paso permitido");
            }
            else
            {
                MessageBox.Show("Error: " + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        public void LookDoor()
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 0))
            {
                //MessageBox.Show("Paso bloqueado");
            }
            else
            {
                MessageBox.Show("Error:" + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        public void StayOpenDoor()
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 2))
            {
                //MessageBox.Show("El acceso se mantiene habilitado");
            }
            else
            {
                //MessageBox.Show("Error:" + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        private void tmrDeploy_Tick(object sender, EventArgs e)
        {
            CHCNetSDK2.NET_DVR_Cleanup();
            if (CHCNetSDK2.NET_DVR_Init() == false)
            {
                MessageBox.Show("NET_DVR_Init error!");
                return;
            }
            deploy();
        }
    }
}
