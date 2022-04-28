
namespace ControlDoor
{
    partial class FLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLoading));
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.BtnCerrarForm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLoading
            // 
            this.pbxLoading.BackColor = System.Drawing.Color.Black;
            this.pbxLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoading.Image")));
            this.pbxLoading.Location = new System.Drawing.Point(318, 164);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(56, 49);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoading.TabIndex = 84;
            this.pbxLoading.TabStop = false;
            // 
            // BtnCerrarForm
            // 
            this.BtnCerrarForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrarForm.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarForm.Image")));
            this.BtnCerrarForm.Location = new System.Drawing.Point(672, 1);
            this.BtnCerrarForm.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarForm.Name = "BtnCerrarForm";
            this.BtnCerrarForm.Size = new System.Drawing.Size(35, 35);
            this.BtnCerrarForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnCerrarForm.TabIndex = 115;
            this.BtnCerrarForm.TabStop = false;
            this.BtnCerrarForm.Click += new System.EventHandler(this.BtnCerrarForm_Click);
            // 
            // FLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(707, 384);
            this.Controls.Add(this.BtnCerrarForm);
            this.Controls.Add(this.pbxLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FLoading";
            this.Opacity = 0.5D;
            this.Text = "FLoading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLoading;
        internal System.Windows.Forms.PictureBox BtnCerrarForm;
    }
}