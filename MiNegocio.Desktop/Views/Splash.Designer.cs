namespace MiNegocio.Desktop.Views
{
    partial class frmSplash
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
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pbLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // Drag
            // 
            this.Drag.Fixed = true;
            this.Drag.Horizontal = true;
            this.Drag.TargetControl = this;
            this.Drag.Vertical = true;
            // 
            // pbLoad
            // 
            this.pbLoad.BackColor = System.Drawing.Color.Transparent;
            this.pbLoad.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016DarkGray;
            this.pbLoad.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoad.BackSegments = false;
            this.pbLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.pbLoad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbLoad.CustomText = null;
            this.pbLoad.CustomWaitingRender = false;
            this.pbLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoad.ForeColor = System.Drawing.Color.White;
            this.pbLoad.ForegroundImage = null;
            this.pbLoad.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.pbLoad.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.pbLoad.Location = new System.Drawing.Point(0, 261);
            this.pbLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoad.SegmentWidth = 12;
            this.pbLoad.Size = new System.Drawing.Size(400, 6);
            this.pbLoad.TabIndex = 14;
            this.pbLoad.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoad.ThemeName = "WaitingGradient";
            this.pbLoad.ThemeStyle.BorderThickness = 0;
            this.pbLoad.WaitingGradientEnabled = true;
            this.pbLoad.WaitingGradientInterval = 70;
            this.pbLoad.WaitingGradientWidth = 100;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiNegocio.Desktop.Properties.Resources.SplashPng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 267);
            this.Controls.Add(this.pbLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.frmSplash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl Drag;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoad;
    }
}