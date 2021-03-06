﻿namespace MiNegocio.Desktop.Masters
{
    partial class MsjOk
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
            this.components = new System.ComponentModel.Container();
            this.pbSuccess = new System.Windows.Forms.PictureBox();
            this.btnClose = new Syncfusion.WinForms.Controls.SfButton();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSuccess
            // 
            this.pbSuccess.BackColor = System.Drawing.Color.Transparent;
            this.pbSuccess.Image = global::MiNegocio.Desktop.Properties.Resources.CheckSmall;
            this.pbSuccess.Location = new System.Drawing.Point(81, 101);
            this.pbSuccess.Name = "pbSuccess";
            this.pbSuccess.Size = new System.Drawing.Size(124, 124);
            this.pbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSuccess.TabIndex = 16;
            this.pbSuccess.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Button";
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.btnClose.Location = new System.Drawing.Point(28, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(230, 40);
            this.btnClose.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnClose.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnClose.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnClose.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.btnClose.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnClose.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "OK";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDetail
            // 
            this.lblDetail.BackColor = System.Drawing.Color.Transparent;
            this.lblDetail.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.lblDetail.ForeColor = System.Drawing.Color.Black;
            this.lblDetail.Location = new System.Drawing.Point(18, 46);
            this.lblDetail.MaximumSize = new System.Drawing.Size(250, 30);
            this.lblDetail.MinimumSize = new System.Drawing.Size(250, 50);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(250, 50);
            this.lblDetail.TabIndex = 14;
            this.lblDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(111, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 32);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Éxito";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 4);
            this.panel4.TabIndex = 17;
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // MsjOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(286, 272);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbSuccess);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MsjOk";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsjOk";
            ((System.ComponentModel.ISupportInitialize)(this.pbSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSuccess;
        private Syncfusion.WinForms.Controls.SfButton btnClose;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse Elipse;
    }
}