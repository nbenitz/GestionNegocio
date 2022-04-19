namespace ControlDoor
{
    partial class FingerPrintMgr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FingerPrintMgr));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.openFileDialogBrowseData = new System.Windows.Forms.OpenFileDialog();
            this.btnCap = new System.Windows.Forms.Button();
            this.btnGetFP = new System.Windows.Forms.Button();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.tmrHideMsg = new System.Windows.Forms.Timer(this.components);
            this.pbxConectado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxFingerPrint = new System.Windows.Forms.PictureBox();
            this.LblReconectar = new System.Windows.Forms.Label();
            this.tmrReconectar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFingerPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(577, 91);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDel
            // 
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(577, 235);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(103, 29);
            this.btnDel.TabIndex = 71;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // openFileDialogBrowseData
            // 
            this.openFileDialogBrowseData.FileName = "openFileDialog1";
            // 
            // btnCap
            // 
            this.btnCap.Enabled = false;
            this.btnCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCap.ForeColor = System.Drawing.Color.White;
            this.btnCap.Location = new System.Drawing.Point(219, 292);
            this.btnCap.Name = "btnCap";
            this.btnCap.Size = new System.Drawing.Size(120, 33);
            this.btnCap.TabIndex = 77;
            this.btnCap.Text = "Capturar Huella";
            this.btnCap.UseVisualStyleBackColor = true;
            this.btnCap.Click += new System.EventHandler(this.btnCap_Click);
            // 
            // btnGetFP
            // 
            this.btnGetFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFP.ForeColor = System.Drawing.Color.White;
            this.btnGetFP.Location = new System.Drawing.Point(577, 200);
            this.btnGetFP.Name = "btnGetFP";
            this.btnGetFP.Size = new System.Drawing.Size(103, 29);
            this.btnGetFP.TabIndex = 78;
            this.btnGetFP.Text = "Get";
            this.btnGetFP.UseVisualStyleBackColor = true;
            this.btnGetFP.Click += new System.EventHandler(this.GetFP_Click);
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchUser.ForeColor = System.Drawing.Color.White;
            this.btnSearchUser.Location = new System.Drawing.Point(577, 165);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(103, 29);
            this.btnSearchUser.TabIndex = 79;
            this.btnSearchUser.Text = "Set";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrueba.ForeColor = System.Drawing.Color.White;
            this.btnPrueba.Location = new System.Drawing.Point(577, 292);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(103, 29);
            this.btnPrueba.TabIndex = 81;
            this.btnPrueba.Text = "Prueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(372, 375);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(219, 375);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 33);
            this.btnAgregar.TabIndex = 86;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // LblMensaje
            // 
            this.LblMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.White;
            this.LblMensaje.Location = new System.Drawing.Point(101, 92);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(354, 20);
            this.LblMensaje.TabIndex = 88;
            this.LblMensaje.Text = "Mensate";
            this.LblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensaje.Visible = false;
            // 
            // tmrHideMsg
            // 
            this.tmrHideMsg.Interval = 5000;
            this.tmrHideMsg.Tick += new System.EventHandler(this.tmrHideMsg_Tick);
            // 
            // pbxConectado
            // 
            this.pbxConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxConectado.Image = global::ControlDoor.Properties.Resources.desconectado;
            this.pbxConectado.Location = new System.Drawing.Point(12, 417);
            this.pbxConectado.Name = "pbxConectado";
            this.pbxConectado.Size = new System.Drawing.Size(12, 12);
            this.pbxConectado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxConectado.TabIndex = 87;
            this.pbxConectado.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ControlDoor.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(538, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Close_Click);
            // 
            // pbxFingerPrint
            // 
            this.pbxFingerPrint.Image = global::ControlDoor.Properties.Resources.fingerprint;
            this.pbxFingerPrint.Location = new System.Drawing.Point(219, 129);
            this.pbxFingerPrint.Name = "pbxFingerPrint";
            this.pbxFingerPrint.Size = new System.Drawing.Size(120, 120);
            this.pbxFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFingerPrint.TabIndex = 82;
            this.pbxFingerPrint.TabStop = false;
            // 
            // LblReconectar
            // 
            this.LblReconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReconectar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblReconectar.Location = new System.Drawing.Point(32, 412);
            this.LblReconectar.Name = "LblReconectar";
            this.LblReconectar.Size = new System.Drawing.Size(113, 20);
            this.LblReconectar.TabIndex = 89;
            this.LblReconectar.Text = "Reconectar";
            this.LblReconectar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblReconectar.Visible = false;
            this.LblReconectar.Click += new System.EventHandler(this.LblReconectar_Click);
            // 
            // tmrReconectar
            // 
            this.tmrReconectar.Interval = 1000;
            this.tmrReconectar.Tick += new System.EventHandler(this.tmrReconectar_Tick);
            // 
            // FingerPrintMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(564, 444);
            this.Controls.Add(this.LblReconectar);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.pbxConectado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxFingerPrint);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.btnGetFP);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FingerPrintMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acs Demo";
            this.Load += new System.EventHandler(this.FingerPrintMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFingerPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowseData;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.Button btnGetFP;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.PictureBox pbxFingerPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbxConectado;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Timer tmrHideMsg;
        private System.Windows.Forms.Label LblReconectar;
        private System.Windows.Forms.Timer tmrReconectar;
    }
}

