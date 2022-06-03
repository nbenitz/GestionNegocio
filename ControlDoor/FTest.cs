using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Configuration;

namespace ControlDoor
{
    public partial class FTest : Form
    {
        public int m_UserID = -1;
        private int m_lCapFingerPrintCfHandle = -1;
        AddDevice deviceAdd = new AddDevice();
        public delegate void SendFingerPrintData(Byte[] FPData);
        public event SendFingerPrintData SendFPData;
        public Boolean Conectado = false;
        FLoading loading;
        CRequest req = new CRequest();
        byte[] FingerData;
        string host = ConfigurationManager.AppSettings["device"].ToString();
        string port = ConfigurationManager.AppSettings["devicePort"].ToString();

        public FTest()
        {
            InitializeComponent();
            CHCNetSDK2.NET_DVR_Init();
            CHCNetSDK2.NET_DVR_SetLogToFile(3, "./SdkLog/", true);

            deviceAdd.loginError += onLoginError;
            deviceAdd.loginSucc += onLoginSucc;
        }

        private void FingerPrintMgr_Load(object sender, EventArgs e)
        {
            btnCap.Focus();
        }


        #region --Eventos Suscriptos--
        private void onLoginSucc()
        {
            btnCap.Enabled = true;
            m_UserID = deviceAdd.m_iUserID;
            deviceAdd.Dispose();
            pbxConectado.Image = Properties.Resources.conectado;
            Conectado = true;
            LblMensaje.Visible = false;
            LblReconectar.Visible = false;
        }

        private void onLoginError()
        {
            btnCap.Enabled = false;
            pbxConectado.Image = Properties.Resources.desconectado;
            Conectado = false;
            LblMensaje.Visible = true;
            LblMensaje.Text = "No se puede conectar con del dispositivo";
            LblReconectar.Visible = true;
            LblReconectar.Text = "Reconectar";
        }
        #endregion


        #region interfaz
        private void ShowLoading()
        {
            loading = new FLoading();
            loading.Show();
        }

        private void CloseLoading()
        {
            if (loading != null)
                loading.Close();
        }
        #endregion


        #region --Funciones--
        private void ProcessCapFingerData(ref CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_CFG struCFG, ref bool flag)
        {
            FingerData = new byte[struCFG.dwFingerPrintDataSize];

            for (int i = 0; i < struCFG.dwFingerPrintDataSize; i++)
            {
                if (i >= struCFG.dwFingerPrintDataSize)
                {
                    break;
                }
                FingerData[i] = struCFG.byFingerData[i];
            }
            pbxFingerPrint.Image = Properties.Resources.fingerprint_scan_ok;

            this.btnCap.BeginInvoke(new Action(() =>
            {
                btnCap.Text = "Recapturar";
                btnCap.Focus();
            }));

            this.btnAgregar.BeginInvoke(new Action(() =>
            {
                btnAgregar.Enabled = true;
                btnAgregar.Focus();
            }));

            /*
            string strpath = null;
            DateTime dt = DateTime.Now;
            string yy = dt.Year.ToString();
            string mm = dt.Month.ToString();
            string dd = dt.Day.ToString();
            string hh = dt.Hour.ToString();
            string MM = dt.Minute.ToString();
            string ss = dt.Second.ToString();

            strpath = string.Format("FP-" + yy + mm + dd + hh + MM + ss + ".dat", Environment.CurrentDirectory);
            try
            {
                using (FileStream fs = new FileStream(strpath, FileMode.OpenOrCreate))
                {
                    fs.Write(struCFG.byFingerData, 0, struCFG.dwFingerPrintDataSize);
                    fs.Close();
                }
                //textBoxFingerData.Text = strpath;
                ShowMessage("FingerPrint Cap SUCCEED");
            }
            catch
            {
                ShowMessage("CapFingerprint process failed");
                flag = false;
            }*/
        }

        private string ByteToBase64(byte[] Data)
        {
            return Convert.ToBase64String(Data, 0, Data.Length);
        }
        #endregion


        #region --Finger--
        #region _Gets_
        public List<string> GetFinger(string emmployeNo)
        {
            var url = "http://" + host + ":" + port + "/ISAPI/AccessControl/FingerPrintUpload?format=json";
            List<string> FingerDataList = new List<string>();

            JSON_FingerPrintCond FingerCond = new JSON_FingerPrintCond();
            FingerCond.FingerPrintCond = new CFingerPrintCond();
            FingerCond.FingerPrintCond.searchID = "100";
            FingerCond.FingerPrintCond.employeeNo = emmployeNo;
            string JsonData = JsonConvert.SerializeObject(FingerCond, Formatting.Indented,
                                                        new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });

            while (true)
            {
                string JsonResult = req.PostRequest(url, JsonData).Result;
                try
                {
                    JSON_FingerPrintInfo responseStatus = JsonConvert.DeserializeObject<JSON_FingerPrintInfo>(JsonResult);
                    if (responseStatus.FingerPrintInfo.status == "OK")
                    {
                        FingerDataList.Add(responseStatus.FingerPrintInfo.FingerPrintList[0].fingerData);
                    }
                    else if (responseStatus.FingerPrintInfo.status == "NoFP")
                    {
                        return FingerDataList;
                    }
                    else
                    {
                        return FingerDataList;
                    }
                }
                catch
                {
                    return FingerDataList;
                }
            }
        }
        #endregion
        #region _Sets_
        private void CapFingerPrint()
        {
            if (m_lCapFingerPrintCfHandle != -1)
            {
                CHCNetSDK2.NET_DVR_StopRemoteConfig(m_lCapFingerPrintCfHandle);
                m_lCapFingerPrintCfHandle = -1;
            }

            CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_COND struCond = new CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_COND();
            struCond.init();
            struCond.dwSize = Marshal.SizeOf(struCond);
            int dwInBufferSize = struCond.dwSize;
            struCond.byFingerPrintPicType = 1; //指纹图片类型是什么暂定1
            struCond.byFingerNo = 1;
            IntPtr ptrStruCond = Marshal.AllocHGlobal(struCond.dwSize);
            Marshal.StructureToPtr(struCond, ptrStruCond, false);

            m_lCapFingerPrintCfHandle = CHCNetSDK2.NET_DVR_StartRemoteConfig(m_UserID, CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_INFO, ptrStruCond, dwInBufferSize, null, IntPtr.Zero);
            pbxFingerPrint.Image = Properties.Resources.fingerprint_scan;
            if (-1 == m_lCapFingerPrintCfHandle)
            {
                Marshal.FreeHGlobal(ptrStruCond);
                //this.LblMensaje.BeginInvoke(new Action(() =>
                //{
                //    LblMensaje.Visible = true;
                //    LblMensaje.Text = "Error en la Captura de la Huella Dactilar, Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString();
                //    tmrHideMsg.Start();
                //}));
                ShowMessage("Error en la Captura de la Huella Dactilar, Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString());
            }

            bool flag = true;
            int dwStatus = 0;

            CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_CFG struCFG = new CHCNetSDK2.NET_DVR_CAPTURE_FINGERPRINT_CFG();
            struCFG.init();
            struCFG.dwSize = Marshal.SizeOf(struCFG);
            int dwOutBuffSize = struCFG.dwSize;
            while (flag)
            {
                dwStatus = CHCNetSDK2.NET_DVR_GetNextRemoteConfig(m_lCapFingerPrintCfHandle, ref struCFG, dwOutBuffSize);
                switch (dwStatus)
                {
                    case CHCNetSDK2.NET_SDK_GET_NEXT_STATUS_SUCCESS://成功读取到数据，处理完本次数据后需调用next
                        ProcessCapFingerData(ref struCFG, ref flag);
                        break;
                    case CHCNetSDK2.NET_SDK_GET_NEXT_STATUS_NEED_WAIT:
                        break;
                    case CHCNetSDK2.NET_SDK_GET_NEXT_STATUS_FAILED:
                        CHCNetSDK2.NET_DVR_StopRemoteConfig(m_lCapFingerPrintCfHandle);
                        //this.LblMensaje.BeginInvoke(new Action(() =>
                        //{
                        //    LblMensaje.Visible = true;
                        //    LblMensaje.Text = "Error al capturar la Huella Dactilar. Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString();
                        //    tmrHideMsg.Start();
                        //}));
                        ShowMessage("Error al capturar la Huella Dactilar. Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString());
                        flag = false;
                        break;
                    case CHCNetSDK2.NET_SDK_GET_NEXT_STATUS_FINISH:
                        CHCNetSDK2.NET_DVR_StopRemoteConfig(m_lCapFingerPrintCfHandle);
                        flag = false;
                        break;
                    default:
                        //this.LblMensaje.BeginInvoke(new Action(() =>
                        //{
                        //    LblMensaje.Visible = true;
                        //    LblMensaje.Text = "Error al capturar la Huella Dactilar. Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString();
                        //    tmrHideMsg.Start();
                        //}));
                        ShowMessage("Error al capturar la Huella Dactilar. Codigo " + CHCNetSDK2.NET_DVR_GetLastError().ToString());
                        flag = false;
                        CHCNetSDK2.NET_DVR_StopRemoteConfig(m_lCapFingerPrintCfHandle);
                        break;
                }
            }
            Marshal.FreeHGlobal(ptrStruCond);
        }

        public string SetFingerData(string emmployeNo, List<byte[]> FPDataList)
        {
            string status = "";

            var url = "http://" + host + ":" + port + "/ISAPI/AccessControl/FingerPrint/SetUp?format=json";
            for (int i = 0; i < FPDataList.Count; i++)
            {
                string FPData = ByteToBase64(FPDataList[i]);
                JSON_FingerPrintCfg fingerPrintCfg = new JSON_FingerPrintCfg();
                fingerPrintCfg.FingerPrintCfg = new CFingerPrintCfg();
                fingerPrintCfg.FingerPrintCfg.employeeNo = emmployeNo;
                fingerPrintCfg.FingerPrintCfg.enableCardReader = new List<int>();
                fingerPrintCfg.FingerPrintCfg.enableCardReader.Add(1);
                fingerPrintCfg.FingerPrintCfg.fingerPrintID = i + 1;
                fingerPrintCfg.FingerPrintCfg.fingerType = "normalFP";
                fingerPrintCfg.FingerPrintCfg.fingerData = FPData;
                //fingerPrintCfg.FingerPrintCfg.checkEmployeeNo = true;

                string JsonFPInfo = JsonConvert.SerializeObject(fingerPrintCfg, Formatting.Indented,
                                                        new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
                string JsonResult = req.PostRequest(url, JsonFPInfo).Result;
                try
                {
                    JSON_FingerPrintStatus responseStatus = JsonConvert.DeserializeObject<JSON_FingerPrintStatus>(JsonResult);
                    if (responseStatus.FingerPrintStatus.StatusList[0].errorMsg == 0)
                        status = "OK";
                    else
                        status = responseStatus.FingerPrintStatus.status;
                }
                catch (Exception e)
                {
                    status = e.Message;
                }
            }
            return status;
        }
        #endregion
        #region _Del_
        public string DelFingerData(string emmployeNo)
        {
            string status = "";

            var url = "http://" + host + ":" + port + "/ISAPI/AccessControl/FingerPrint/Delete?format=json";

            JSON_FingerPrintDelete FingerDel = new JSON_FingerPrintDelete
            {
                FingerPrintDelete = new CFingerPrintDelete
                {
                    mode = "byEmployeeNo",
                    EmployeeNoDetail = new CEmployeeNoDetail
                    {
                        employeeNo = emmployeNo,
                        enableCardReader = new List<int> { 1 },
                        fingerPrintID = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
                    }
                }
            };

            string JsonFPInfo = JsonConvert.SerializeObject(FingerDel, Formatting.Indented,
                                                    new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
            string JsonResult = req.PutRequest(url, JsonFPInfo).Result;
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
        #endregion
        #region _Update_
        public string UpdateFingerData(string emmployeNo, List<byte[]> FPDataList)
        {
            string estado = DelFingerData(emmployeNo);
            if (estado != "OK")
            {
                return estado;
            }
            estado = SetFingerData(emmployeNo, FPDataList);
            return estado;
        }
        #endregion
        #endregion


        #region --Controles--

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SendFPData(FingerData);
            this.Hide();
            pbxFingerPrint.Image = Properties.Resources.fingerprint;
            btnCap.Text = "Capturar Huella";
            btnAgregar.Enabled = false;
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }

        private async void btnCap_Click(object sender, EventArgs e)
        {
            if (Conectado)
            {
                ShowLoading();
                btnCap.Enabled = false;
                if (btnCap.Text == "Recapturar")
                {
                    FingerData = new byte[512];
                    btnAgregar.Enabled = false;
                }
                Task capTask = new Task(() => CapFingerPrint());
                capTask.Start();
                await capTask;
                btnCap.Enabled = true;
                CloseLoading();
            }
        }

        private void GetFP_Click(object sender, EventArgs e)
        {

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            PersonMgr personMgr = new PersonMgr();

            ShowLoading();
            Task oTask = new Task(() => personMgr.SetUserInfo("Fiorella", "12345"));
            oTask.Start();
            await oTask;
            CloseLoading();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LblReconectar_Click(object sender, EventArgs e)
        {
            if (LblReconectar.Text == "Reconectar")
            {
                LblReconectar.Text = "Reconectando..";
                tmrReconectar.Start();
            }
        }

        private void tmrReconectar_Tick(object sender, EventArgs e)
        {
            tmrReconectar.Stop();
            Login();
        }
        #endregion


        #region --Alerta--
        private void ShowMessage(string msg)
        {
            this.LblMensaje.BeginInvoke(new Action(() =>
            {
                LblMensaje.Visible = true;
                LblMensaje.Text = msg;
                tmrHideMsg.Start();
            }));
        }

        private void tmrHideMsg_Tick(object sender, EventArgs e)
        {
            tmrHideMsg.Stop();
            LblMensaje.Visible = false;
        }
        #endregion


        #region  --Conexion-
        public void Login()
        {
            deviceAdd.Login();
        }

        private string PostRequest22(string url, string json)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var credentialCache = new CredentialCache();

            credentialCache.Add(
              new Uri(uri.GetLeftPart(UriPartial.Authority)),
              "Digest",  // authentication type 
              new NetworkCredential("admin", "ivandavid121")
            );

            request.Method = "POST";
            request.ContentType = "application/json";
            //request.ContentLength = json.Length;
            request.Credentials = credentialCache;

            try
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
                //HttpStatusCode statusCode = httpResponse.StatusCode;
            }
            catch (Exception e)
            {
                //ShowMessage("Error: " + e);
                return "Error: " + e.Message;
            }
        }

        private async Task<string> PostRequest(string url, string json)
        {
            Uri uri = new Uri(url);
            var request = (HttpWebRequest)WebRequest.Create(uri);
            var credentialCache = new CredentialCache();

            credentialCache.Add(
              new Uri(uri.GetLeftPart(UriPartial.Authority)),
              "Digest",  // authentication type 
              new NetworkCredential("admin", "ivandavid121")
            );

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Credentials = credentialCache;

            try
            {
                // Write the request Asynchronously 
                using (var stream = await Task.Factory.FromAsync<Stream>(request.BeginGetRequestStream, request.EndGetRequestStream, null))
                {
                    byte[] byteArray = Encoding.UTF8.GetBytes(json);

                    // Write the bytes to the stream
                    await stream.WriteAsync(byteArray, 0, byteArray.Length);
                }

                using (var response = (HttpWebResponse)await request.GetResponseAsync())
                {
                    string data;

                    // Read the response into a Stream object. 
                    Stream responseStream = response.GetResponseStream();
                    using (var reader = new StreamReader(responseStream))
                    {
                        data = reader.ReadToEnd();
                    }
                    responseStream.Close();
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        return data;
                    }
                    else
                    {
                        if (response.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            return "No autorizado";
                        }
                        else if (response.StatusCode == HttpStatusCode.BadRequest)
                        {
                            return "Solicitud incorrecta";
                        }
                        else
                        {
                            return "Error de conexión";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
        #endregion

        public string SaveNewCliente(
            cliente _cliente,
            int membresia_id,
            DateTime fechaInicio,
            int precio,
            int descuento,
            int monto,
            string employeeNo,
            List<Byte[]> FPDataList)
        {
            string estado;

            try
            {
                using (var db = new minegocioEntities())
                {
                    /*db.ChangeDatabase
                        (
                            server: ConfigurationManager.AppSettings["server"].ToString()
                        );*/

                    db.cliente.Add(_cliente);

                    cliente_membresia cliente_Membresia = new cliente_membresia
                    {
                        cliente = _cliente,
                        membresia_id = membresia_id,
                        fecha_inicio = fechaInicio,
                        precio = precio,
                        descuento = descuento
                    };
                    db.cliente_membresia.Add(cliente_Membresia);

                    pago_membresia pago_Membresia = new pago_membresia
                    {
                        cliente_membresia = cliente_Membresia,
                        fecha = DateTime.Now,
                        monto = monto
                    };
                    db.pago_membresia.Add(pago_Membresia);

                    //Create user access
                    if (FPDataList.Count > 0)
                    {
                        acceso _acceso = new acceso
                        {
                            codigo = employeeNo,
                            nombre = _cliente.Nombre,
                        };
                        db.acceso.Add(_acceso);

                        cliente_acceso cliente_Acceso = new cliente_acceso
                        {
                            cliente = _cliente,
                            acceso = _acceso
                        };
                        db.cliente_acceso.Add(cliente_Acceso);

                        List<finger_print> fp_list = new List<finger_print>();
                        List<acceso_finger_print> acceso_fp_list = new List<acceso_finger_print>();
                        for (int j = 0; j < FPDataList.Count; j++)
                        {
                            finger_print FP = new finger_print
                            {
                                fp_data = ByteToBase64(FPDataList[j])
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
                    db.SaveChanges();
                    estado = "OK";
                }
            }
            catch (Exception e)
            {
                estado = e.Message;
            }
            return estado;
        }

        public string SaveNewEmple(
            empleado _emple,
            string employeeNo,
            List<Byte[]> FPDataList)
        {
            string estado;

            try
            {
                using (var db = new minegocioEntities())
                {
                    db.empleado.Add(_emple);

                    //Create user access
                    if (FPDataList.Count > 0)
                    {
                        acceso _acceso = new acceso
                        {
                            codigo = employeeNo,
                            nombre = _emple.Nombre,
                        };
                        db.acceso.Add(_acceso);

                        empleado_acceso empleado_Acceso = new empleado_acceso
                        {
                            empleado = _emple,
                            acceso = _acceso
                        };
                        db.empleado_acceso.Add(empleado_Acceso);

                        List<finger_print> fp_list = new List<finger_print>();
                        List<acceso_finger_print> acceso_fp_list = new List<acceso_finger_print>();
                        for (int j = 0; j < FPDataList.Count; j++)
                        {
                            finger_print FP = new finger_print
                            {
                                fp_data = ByteToBase64(FPDataList[j])
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
                    db.SaveChanges();
                    estado = "OK";
                }
            }
            catch (Exception e)
            {
                estado = e.Message;
            }
            return estado;
        }

        public string SaveAcceso(
            string ci,
            string name,
            string employeeNo,
            List<Byte[]> FPDataList)
        {
            string estado;

            try
            {
                using (var db = new minegocioEntities())
                {
                    //Create user access
                    if (FPDataList.Count > 0)
                    {
                        acceso _acceso = new acceso
                        {
                            codigo = employeeNo,
                            nombre = name,
                        };
                        db.acceso.Add(_acceso);

                        cliente_acceso cliente_Acceso = new cliente_acceso
                        {
                            cliente_ci = ci,
                            acceso = _acceso
                        };
                        db.cliente_acceso.Add(cliente_Acceso);

                        List<finger_print> fp_list = new List<finger_print>();
                        List<acceso_finger_print> acceso_fp_list = new List<acceso_finger_print>();
                        for (int j = 0; j < FPDataList.Count; j++)
                        {
                            finger_print FP = new finger_print
                            {
                                fp_data = ByteToBase64(FPDataList[j])
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
                    db.SaveChanges();
                    estado = "OK";
                }
            }
            catch (Exception e)
            {
                estado = e.InnerException.InnerException.Message;
            }
            return estado;
        }

        public string SaveAccesoEmple(
            int ci,
            string name,
            string employeeNo,
            List<Byte[]> FPDataList)
        {
            string estado;

            try
            {
                using (var db = new minegocioEntities())
                {
                    //Create user access
                    if (FPDataList.Count > 0)
                    {
                        acceso _acceso = new acceso
                        {
                            codigo = employeeNo,
                            nombre = name,
                        };
                        db.acceso.Add(_acceso);

                        empleado_acceso empleado_Acceso = new empleado_acceso
                        {
                            empleado_ci = ci,
                            acceso = _acceso
                        };
                        db.empleado_acceso.Add(empleado_Acceso);

                        List<finger_print> fp_list = new List<finger_print>();
                        List<acceso_finger_print> acceso_fp_list = new List<acceso_finger_print>();
                        for (int j = 0; j < FPDataList.Count; j++)
                        {
                            finger_print FP = new finger_print
                            {
                                fp_data = ByteToBase64(FPDataList[j])
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
                    db.SaveChanges();
                    estado = "OK";
                }
            }
            catch (Exception e)
            {
                estado = e.InnerException.InnerException.Message;
            }
            return estado;
        }

        private async void btnSetUser_Click(object sender, EventArgs e)
        {
            PersonMgr personMgr = new PersonMgr();

            ShowLoading();
            Task oTask = new Task(() => personMgr.SetUserInfo(txtName.Text, txtEmployeeNo.Text));
            oTask.Start();
            await oTask;
            CloseLoading();
        }

        private async void btnDelUser_Click(object sender, EventArgs e)
        {
            PersonMgr personMgr = new PersonMgr();

            ShowLoading();
            Task oTask = new Task(() => personMgr.DelUser(txtEmployeeNo.Text));
            oTask.Start();
            await oTask;
            CloseLoading();
        }
    }
}
