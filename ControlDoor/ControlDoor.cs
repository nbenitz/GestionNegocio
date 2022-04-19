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


namespace ControlDoor
{
    public partial class ControlDoor : Form
    {
        public static int m_UserID = -1;

        public ControlDoor()
        {
            InitializeComponent();
            if (CHCNetSDK0.NET_DVR_Init() == false)
            {
                MessageBox.Show("Error al inicializar el dispositivo!");
                return;
            }
        }
        
        //0-close, 1-open, 2-stay open, 3-stay close
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AddDevice dlg = new AddDevice();
            dlg.ShowDialog();
            dlg.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 1))
            {
                MessageBox.Show("Paso permitido");
            }
            else
            {
                MessageBox.Show("Error: " + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 0))
            {
                MessageBox.Show("Paso bloqueado");
            }
            else
            {
                MessageBox.Show("Error:" + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        private void btnStayOpen_Click(object sender, EventArgs e)
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 2))
            {
                MessageBox.Show("El acceso se mantiene habilitado");
            }
            else
            {
                MessageBox.Show("Error:" + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        private void btnStayClose_Click(object sender, EventArgs e)
        {
            if (CHCNetSDK0.NET_DVR_ControlGateway(m_UserID, 1, 3))
            {
                MessageBox.Show("El acceso se mantiene bloqueado");
            }
            else
            {
                MessageBox.Show("Error:" + CHCNetSDK0.NET_DVR_GetLastError());
            }
        }

        private void ControlDoor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_UserID >= 0)
            {
                CHCNetSDK0.NET_DVR_Logout_V30(m_UserID);
                m_UserID = -1;
            }
            CHCNetSDK0.NET_DVR_Cleanup();
        }

    }
}
