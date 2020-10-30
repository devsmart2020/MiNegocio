namespace MiNegocio.Desktop.Masters
{
    partial class MsjFail
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
            this.pbError = new System.Windows.Forms.PictureBox();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).BeginInit();
            this.SuspendLayout();
            // 
            // pbError
            // 
            this.pbError.BackColor = System.Drawing.Color.Transparent;
            this.pbError.Image = global::MiNegocio.Desktop.Properties.Resources.ErrorGif;
            this.pbError.Location = new System.Drawing.Point(59, 64);
            this.pbError.Name = "pbError";
            this.pbError.Size = new System.Drawing.Size(168, 116);
            this.pbError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbError.TabIndex = 20;
            this.pbError.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnClose.Location = new System.Drawing.Point(22, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(243, 40);
            this.btnClose.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnClose.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnClose.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnClose.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnClose.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnClose.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "OK";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblDetail.ForeColor = System.Drawing.Color.Black;
            this.lblDetail.Location = new System.Drawing.Point(14, 40);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(258, 21);
            this.lblDetail.TabIndex = 18;
            this.lblDetail.Text = "¡Atención! se ha producido un error:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(111, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 32);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Error";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 3);
            this.panel4.TabIndex = 21;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Black;
            this.lblError.Location = new System.Drawing.Point(15, 185);
            this.lblError.MaximumSize = new System.Drawing.Size(260, 45);
            this.lblError.MinimumSize = new System.Drawing.Size(10, 45);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(250, 45);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "A";
            // 
            // MsjFail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(286, 280);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsjFail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbError;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblError;
    }
}