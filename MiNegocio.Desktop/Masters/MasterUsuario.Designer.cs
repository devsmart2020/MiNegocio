namespace MiNegocio.Desktop.Masters
{
    partial class frmMasterUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasterUsuario));
            this.dgvUsuario = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnActualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnGuardar = new Syncfusion.WinForms.Controls.SfButton();
            this.pbLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dpFcha = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.txtDireccion = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDocId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblUser = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPass = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUsuario = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbPerfil = new Syncfusion.WinForms.ListView.SfComboBox();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.errorUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfil)).BeginInit();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AccessibleName = "Table";
            this.dgvUsuario.AllowDeleting = true;
            this.dgvUsuario.AllowFiltering = true;
            this.dgvUsuario.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvUsuario.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsuario.Location = new System.Drawing.Point(12, 392);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvUsuario.Size = new System.Drawing.Size(722, 157);
            this.dgvUsuario.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvUsuario.TabIndex = 12;
            this.dgvUsuario.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvUsuario_CellDoubleClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AccessibleName = "Button";
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.FocusRectangleVisible = true;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnActualizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnActualizar.Location = new System.Drawing.Point(327, 338);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(30, 30);
            this.btnActualizar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnActualizar.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnActualizar.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnActualizar.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Actualizar;
            this.btnActualizar.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnActualizar.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "Button";
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FocusRectangleVisible = true;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.ImageSize = new System.Drawing.Size(18, 18);
            this.btnGuardar.Location = new System.Drawing.Point(272, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(30, 30);
            this.btnGuardar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardar.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardar.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnGuardar.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Guardar;
            this.btnGuardar.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnGuardar.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.pbLoad.Location = new System.Drawing.Point(264, 380);
            this.pbLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoad.SegmentWidth = 12;
            this.pbLoad.Size = new System.Drawing.Size(126, 6);
            this.pbLoad.TabIndex = 182;
            this.pbLoad.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoad.ThemeName = "WaitingGradient";
            this.pbLoad.ThemeStyle.BorderThickness = 0;
            this.pbLoad.WaitingGradientEnabled = true;
            this.pbLoad.WaitingGradientInterval = 70;
            this.pbLoad.WaitingGradientWidth = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(321, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 180;
            this.label7.Text = "Actualizar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(269, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 181;
            this.label11.Text = "Guardar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(269, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 202;
            this.label13.Text = "Cumpleaños";
            // 
            // dpFcha
            // 
            this.dpFcha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dpFcha.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dpFcha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dpFcha.Location = new System.Drawing.Point(272, 148);
            this.dpFcha.Name = "dpFcha";
            this.dpFcha.Size = new System.Drawing.Size(237, 23);
            this.dpFcha.Style.BackColor = System.Drawing.Color.White;
            this.dpFcha.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.FocusedBorderColor = System.Drawing.Color.OrangeRed;
            this.dpFcha.Style.ForeColor = System.Drawing.Color.Black;
            this.dpFcha.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.UpDownBackColor = System.Drawing.Color.White;
            this.dpFcha.Style.UpDownForeColor = System.Drawing.Color.WhiteSmoke;
            this.dpFcha.Style.UpDownHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.UpDownHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dpFcha.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtDireccion.BorderColor = System.Drawing.Color.DimGray;
            this.txtDireccion.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDireccion.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(25, 204);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Metrocolor = System.Drawing.Color.Silver;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NearImage = global::MiNegocio.Desktop.Properties.Resources.Gps;
            this.txtDireccion.Size = new System.Drawing.Size(484, 23);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.ThemeStyle.CornerRadius = 0;
            this.txtDireccion.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtDireccion.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtDireccion.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDireccion.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.UseBorderColorOnFocus = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(22, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 201;
            this.label3.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtTelefono.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefono.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTelefono.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(25, 148);
            this.txtTelefono.MaxLength = 12;
            this.txtTelefono.Metrocolor = System.Drawing.Color.Silver;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.NearImage = global::MiNegocio.Desktop.Properties.Resources.Telefono;
            this.txtTelefono.Size = new System.Drawing.Size(200, 23);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.ThemeStyle.CornerRadius = 0;
            this.txtTelefono.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtTelefono.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtTelefono.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.UseBorderColorOnFocus = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(22, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 198;
            this.label4.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(12, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 197;
            this.label8.Text = "2.Información de Contacto";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtApellido.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellido.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApellido.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(519, 53);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Metrocolor = System.Drawing.Color.Silver;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.NearImage = global::MiNegocio.Desktop.Properties.Resources.Texto;
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.ThemeStyle.CornerRadius = 0;
            this.txtApellido.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtApellido.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtApellido.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtApellido.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.UseBorderColorOnFocus = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(516, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 196;
            this.label2.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombre.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(272, 53);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Metrocolor = System.Drawing.Color.Silver;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.NearImage = global::MiNegocio.Desktop.Properties.Resources.Texto;
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.ThemeStyle.CornerRadius = 0;
            this.txtNombre.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtNombre.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.UseBorderColorOnFocus = true;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(269, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 195;
            this.label9.Text = "Nombres";
            // 
            // txtDocId
            // 
            this.txtDocId.BackColor = System.Drawing.Color.White;
            this.txtDocId.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtDocId.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocId.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDocId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDocId.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtDocId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocId.ForeColor = System.Drawing.Color.Black;
            this.txtDocId.Location = new System.Drawing.Point(25, 53);
            this.txtDocId.MaxLength = 10;
            this.txtDocId.Metrocolor = System.Drawing.Color.Silver;
            this.txtDocId.Name = "txtDocId";
            this.txtDocId.NearImage = global::MiNegocio.Desktop.Properties.Resources.DocId;
            this.txtDocId.Size = new System.Drawing.Size(200, 23);
            this.txtDocId.TabIndex = 0;
            this.txtDocId.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtDocId.ThemeStyle.CornerRadius = 0;
            this.txtDocId.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtDocId.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtDocId.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocId.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocId.UseBorderColorOnFocus = true;
            this.txtDocId.TextChanged += new System.EventHandler(this.txtDocId_TextChanged);
            this.txtDocId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocId_KeyPress);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblUser.Location = new System.Drawing.Point(22, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 13);
            this.lblUser.TabIndex = 194;
            this.lblUser.Text = "Documento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 17);
            this.label10.TabIndex = 193;
            this.label10.Text = "1.Información Personal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(12, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 17);
            this.label12.TabIndex = 193;
            this.label12.Text = "3.Información del Sistema";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtPass.BorderColor = System.Drawing.Color.DimGray;
            this.txtPass.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPass.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(272, 293);
            this.txtPass.MaxLength = 20;
            this.txtPass.Metrocolor = System.Drawing.Color.Silver;
            this.txtPass.Name = "txtPass";
            this.txtPass.NearImage = global::MiNegocio.Desktop.Properties.Resources.Desbloqueo;
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.TabIndex = 7;
            this.txtPass.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.ThemeStyle.CornerRadius = 0;
            this.txtPass.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtPass.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtPass.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPass.UseBorderColorOnFocus = true;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(269, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 204;
            this.label14.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsuario.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUsuario.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(25, 293);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Metrocolor = System.Drawing.Color.Silver;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.NearImage = global::MiNegocio.Desktop.Properties.Resources.UserIcon;
            this.txtUsuario.Size = new System.Drawing.Size(200, 23);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.ThemeStyle.CornerRadius = 0;
            this.txtUsuario.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtUsuario.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtUsuario.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuario.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsuario.UseBorderColorOnFocus = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(22, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 204;
            this.label15.Text = "Usuario";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(516, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 184;
            this.label16.Text = "Perfil";
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.BackColor = System.Drawing.Color.White;
            this.cmbPerfil.Location = new System.Drawing.Point(519, 292);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(200, 24);
            this.cmbPerfil.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbPerfil.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.cmbPerfil.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbPerfil.TabIndex = 8;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbInactivo);
            this.gbEstado.Controls.Add(this.rbActivo);
            this.gbEstado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbEstado.Location = new System.Drawing.Point(25, 337);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(200, 35);
            this.gbEstado.TabIndex = 9;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado";
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(105, 13);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(65, 17);
            this.rbInactivo.TabIndex = 1;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(27, 13);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(56, 17);
            this.rbActivo.TabIndex = 0;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // errorUsuario
            // 
            this.errorUsuario.ContainerControl = this;
            this.errorUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("errorUsuario.Icon")));
            // 
            // frmMasterUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 561);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dpFcha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMasterUsuario";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Shown += new System.EventHandler(this.MasterUsuario_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPerfil)).EndInit();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvUsuario;
        private Syncfusion.WinForms.Controls.SfButton btnActualizar;
        private Syncfusion.WinForms.Controls.SfButton btnGuardar;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dpFcha;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDireccion;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtApellido;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNombre;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDocId;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPass;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private Syncfusion.WinForms.ListView.SfComboBox cmbPerfil;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.ErrorProvider errorUsuario;
    }
}