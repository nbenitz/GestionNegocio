namespace ControlDoor
{
    partial class FTest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTest));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnDelFP = new System.Windows.Forms.Button();
            this.openFileDialogBrowseData = new System.Windows.Forms.OpenFileDialog();
            this.btnCap = new System.Windows.Forms.Button();
            this.btnGetFP = new System.Windows.Forms.Button();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.btnSetFP = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.tmrHideMsg = new System.Windows.Forms.Timer(this.components);
            this.LblReconectar = new System.Windows.Forms.Label();
            this.tmrReconectar = new System.Windows.Forms.Timer(this.components);
            this.pbxConectado = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxFingerPrint = new System.Windows.Forms.PictureBox();
            this.btnSetUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.txtEmployeeNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFPData = new System.Windows.Forms.TextBox();
            this.dgvAccesos = new System.Windows.Forms.DataGridView();
            this.EmployeeNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FPCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbxConectado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFingerPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(590, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(134, 29);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnDelFP
            // 
            this.btnDelFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelFP.ForeColor = System.Drawing.Color.White;
            this.btnDelFP.Location = new System.Drawing.Point(342, 161);
            this.btnDelFP.Name = "btnDelFP";
            this.btnDelFP.Size = new System.Drawing.Size(134, 29);
            this.btnDelFP.TabIndex = 71;
            this.btnDelFP.Text = "Delete Finger Print";
            this.btnDelFP.UseVisualStyleBackColor = true;
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
            this.btnCap.Location = new System.Drawing.Point(33, 254);
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
            this.btnGetFP.Location = new System.Drawing.Point(342, 91);
            this.btnGetFP.Name = "btnGetFP";
            this.btnGetFP.Size = new System.Drawing.Size(134, 29);
            this.btnGetFP.TabIndex = 78;
            this.btnGetFP.Text = "Get Finger Print";
            this.btnGetFP.UseVisualStyleBackColor = true;
            this.btnGetFP.Click += new System.EventHandler(this.GetFP_Click);
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetUsers.ForeColor = System.Drawing.Color.White;
            this.btnGetUsers.Location = new System.Drawing.Point(202, 91);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(134, 29);
            this.btnGetUsers.TabIndex = 79;
            this.btnGetUsers.Text = "Get Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSetFP
            // 
            this.btnSetFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetFP.ForeColor = System.Drawing.Color.White;
            this.btnSetFP.Location = new System.Drawing.Point(342, 126);
            this.btnSetFP.Name = "btnSetFP";
            this.btnSetFP.Size = new System.Drawing.Size(134, 29);
            this.btnSetFP.TabIndex = 81;
            this.btnSetFP.Text = "Set Finger Print";
            this.btnSetFP.UseVisualStyleBackColor = true;
            this.btnSetFP.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(730, 448);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 29);
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
            this.btnAgregar.Location = new System.Drawing.Point(33, 293);
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
            this.LblMensaje.Location = new System.Drawing.Point(30, 41);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(123, 71);
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
            // LblReconectar
            // 
            this.LblReconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblReconectar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReconectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LblReconectar.Location = new System.Drawing.Point(30, 448);
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
            // pbxConectado
            // 
            this.pbxConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbxConectado.Image = global::ControlDoor.Properties.Resources.desconectado;
            this.pbxConectado.Location = new System.Drawing.Point(12, 453);
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
            this.pictureBox1.Location = new System.Drawing.Point(873, 5);
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
            this.pbxFingerPrint.Location = new System.Drawing.Point(33, 128);
            this.pbxFingerPrint.Name = "pbxFingerPrint";
            this.pbxFingerPrint.Size = new System.Drawing.Size(120, 120);
            this.pbxFingerPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFingerPrint.TabIndex = 82;
            this.pbxFingerPrint.TabStop = false;
            // 
            // btnSetUser
            // 
            this.btnSetUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetUser.ForeColor = System.Drawing.Color.White;
            this.btnSetUser.Location = new System.Drawing.Point(202, 126);
            this.btnSetUser.Name = "btnSetUser";
            this.btnSetUser.Size = new System.Drawing.Size(134, 29);
            this.btnSetUser.TabIndex = 91;
            this.btnSetUser.Text = "Set User";
            this.btnSetUser.UseVisualStyleBackColor = true;
            this.btnSetUser.Click += new System.EventHandler(this.btnSetUser_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelUser.ForeColor = System.Drawing.Color.White;
            this.btnDelUser.Location = new System.Drawing.Point(202, 161);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(134, 29);
            this.btnDelUser.TabIndex = 90;
            this.btnDelUser.Text = "Delete User";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // txtEmployeeNo
            // 
            this.txtEmployeeNo.Location = new System.Drawing.Point(201, 58);
            this.txtEmployeeNo.Name = "txtEmployeeNo";
            this.txtEmployeeNo.Size = new System.Drawing.Size(135, 22);
            this.txtEmployeeNo.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(198, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 93;
            this.label1.Text = "Employee No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 95;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(342, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 22);
            this.txtName.TabIndex = 94;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(198, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 97;
            this.label3.Text = "Finger Print Data";
            // 
            // txtFPData
            // 
            this.txtFPData.Location = new System.Drawing.Point(201, 216);
            this.txtFPData.Multiline = true;
            this.txtFPData.Name = "txtFPData";
            this.txtFPData.Size = new System.Drawing.Size(275, 218);
            this.txtFPData.TabIndex = 96;
            // 
            // dgvAccesos
            // 
            this.dgvAccesos.AllowUserToAddRows = false;
            this.dgvAccesos.AllowUserToDeleteRows = false;
            this.dgvAccesos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.dgvAccesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccesos.ColumnHeadersHeight = 25;
            this.dgvAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeNoCol,
            this.NombreCol,
            this.FPCol});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccesos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccesos.Location = new System.Drawing.Point(502, 58);
            this.dgvAccesos.Name = "dgvAccesos";
            this.dgvAccesos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAccesos.RowHeadersVisible = false;
            this.dgvAccesos.Size = new System.Drawing.Size(362, 376);
            this.dgvAccesos.TabIndex = 98;
            // 
            // EmployeeNoCol
            // 
            this.EmployeeNoCol.Frozen = true;
            this.EmployeeNoCol.HeaderText = "Employee No";
            this.EmployeeNoCol.Name = "EmployeeNoCol";
            this.EmployeeNoCol.ReadOnly = true;
            // 
            // NombreCol
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.NombreCol.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreCol.Frozen = true;
            this.NombreCol.HeaderText = "Name";
            this.NombreCol.Name = "NombreCol";
            this.NombreCol.ReadOnly = true;
            this.NombreCol.Width = 200;
            // 
            // FPCol
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.FPCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.FPCol.FillWeight = 30F;
            this.FPCol.Frozen = true;
            this.FPCol.HeaderText = "FP";
            this.FPCol.Name = "FPCol";
            this.FPCol.ReadOnly = true;
            this.FPCol.Width = 30;
            // 
            // FTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(899, 480);
            this.Controls.Add(this.dgvAccesos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFPData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeNo);
            this.Controls.Add(this.btnSetUser);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.LblReconectar);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.pbxConectado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxFingerPrint);
            this.Controls.Add(this.btnSetFP);
            this.Controls.Add(this.btnGetUsers);
            this.Controls.Add(this.btnGetFP);
            this.Controls.Add(this.btnCap);
            this.Controls.Add(this.btnDelFP);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acs Demo";
            this.Load += new System.EventHandler(this.FingerPrintMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxConectado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFingerPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnDelFP;
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowseData;
        private System.Windows.Forms.Button btnCap;
        private System.Windows.Forms.Button btnGetFP;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.Button btnSetFP;
        private System.Windows.Forms.PictureBox pbxFingerPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.PictureBox pbxConectado;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Timer tmrHideMsg;
        private System.Windows.Forms.Label LblReconectar;
        private System.Windows.Forms.Timer tmrReconectar;
        private System.Windows.Forms.Button btnSetUser;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.TextBox txtEmployeeNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFPData;
        internal System.Windows.Forms.DataGridView dgvAccesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn FPCol;
    }
}

