namespace MiNegocio.Desktop.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtPass = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblForgot = new System.Windows.Forms.Label();
            this.pbLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BeforeTouchSize = new System.Drawing.Size(200, 31);
            this.txtPass.BorderColor = System.Drawing.Color.DimGray;
            this.txtPass.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(49, 219);
            this.txtPass.MaxLength = 20;
            this.txtPass.Metrocolor = System.Drawing.Color.Silver;
            this.txtPass.Name = "txtPass";
            this.txtPass.NearImage = global::MiNegocio.Desktop.Properties.Resources.PassIcon;
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(200, 31);
            this.txtPass.TabIndex = 1;
            this.txtPass.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.ThemeStyle.CornerRadius = 3;
            this.txtPass.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtPass.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtPass.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.UseBorderColorOnFocus = true;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyUp);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.BackColor = System.Drawing.Color.Transparent;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.DimGray;
            this.lblForgot.Location = new System.Drawing.Point(128, 257);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(121, 13);
            this.lblForgot.TabIndex = 11;
            this.lblForgot.Text = "Olvidó la contraseña ?";
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
            this.pbLoad.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoad.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoad.Location = new System.Drawing.Point(88, 336);
            this.pbLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoad.SegmentWidth = 12;
            this.pbLoad.Size = new System.Drawing.Size(120, 7);
            this.pbLoad.TabIndex = 13;
            this.pbLoad.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoad.ThemeName = "WaitingGradient";
            this.pbLoad.ThemeStyle.BorderThickness = 0;
            this.pbLoad.WaitingGradientEnabled = true;
            this.pbLoad.WaitingGradientInterval = 70;
            this.pbLoad.WaitingGradientWidth = 100;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleName = "Button";
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(49, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(200, 40);
            this.btnLogin.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnLogin.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnLogin.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnLogin.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnLogin.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnLogin.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitle.Location = new System.Drawing.Point(83, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 32);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Mi Negocio";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::MiNegocio.Desktop.Properties.Resources.Close;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(273, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BeforeTouchSize = new System.Drawing.Size(200, 31);
            this.txtUser.BorderColor = System.Drawing.Color.DimGray;
            this.txtUser.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.txtUser.Location = new System.Drawing.Point(49, 164);
            this.txtUser.MaxLength = 20;
            this.txtUser.Metrocolor = System.Drawing.Color.Silver;
            this.txtUser.Name = "txtUser";
            this.txtUser.NearImage = global::MiNegocio.Desktop.Properties.Resources.UserIcon;
            this.txtUser.Size = new System.Drawing.Size(200, 31);
            this.txtUser.TabIndex = 0;
            this.txtUser.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.ThemeStyle.CornerRadius = 3;
            this.txtUser.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtUser.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtUser.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.UseBorderColorOnFocus = true;
            // 
            // Drag
            // 
            this.Drag.Fixed = true;
            this.Drag.Horizontal = true;
            this.Drag.TargetControl = this;
            this.Drag.Vertical = true;
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            this.errorLogin.Icon = ((System.Drawing.Icon)(resources.GetObject("errorLogin.Icon")));
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MiNegocio.Desktop.Properties.Resources.loginBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 459);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.txtPass);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPass;
        private System.Windows.Forms.Label lblForgot;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoad;
        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUser;
        private Bunifu.Framework.UI.BunifuDragControl Drag;
        private System.Windows.Forms.ErrorProvider errorLogin;
    }
}