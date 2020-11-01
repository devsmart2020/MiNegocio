namespace MiNegocio.Desktop.Masters
{
    partial class frmMasterEquipo
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
            this.label14 = new System.Windows.Forms.Label();
            this.txtNomTipoEquipo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomMarca = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomModelo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.cmbMarca = new Syncfusion.WinForms.ListView.SfComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTE = new Syncfusion.WinForms.ListView.SfComboBox();
            this.pbLoadModel = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.dgvTipoEquipo = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dgvMarca = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pbLoadTE = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.pbLoadMarca = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.dgvModelo = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnGuardaTE = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdateTE = new Syncfusion.WinForms.Controls.SfButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardaMarca = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdateMarca = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdateModelo = new Syncfusion.WinForms.Controls.SfButton();
            this.btnGuardaModelo = new Syncfusion.WinForms.Controls.SfButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteModelo = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomTipoEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEquipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(16, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 145;
            this.label14.Text = "1.Tipo de Equipo";
            // 
            // txtNomTipoEquipo
            // 
            this.txtNomTipoEquipo.BackColor = System.Drawing.Color.White;
            this.txtNomTipoEquipo.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtNomTipoEquipo.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomTipoEquipo.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNomTipoEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomTipoEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomTipoEquipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNomTipoEquipo.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtNomTipoEquipo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomTipoEquipo.ForeColor = System.Drawing.Color.Black;
            this.txtNomTipoEquipo.Location = new System.Drawing.Point(31, 52);
            this.txtNomTipoEquipo.MaxLength = 20;
            this.txtNomTipoEquipo.Metrocolor = System.Drawing.Color.Silver;
            this.txtNomTipoEquipo.Name = "txtNomTipoEquipo";
            this.txtNomTipoEquipo.NearImage = global::MiNegocio.Desktop.Properties.Resources.Texto;
            this.txtNomTipoEquipo.Size = new System.Drawing.Size(181, 23);
            this.txtNomTipoEquipo.TabIndex = 0;
            this.txtNomTipoEquipo.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtNomTipoEquipo.ThemeStyle.CornerRadius = 0;
            this.txtNomTipoEquipo.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtNomTipoEquipo.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtNomTipoEquipo.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomTipoEquipo.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomTipoEquipo.UseBorderColorOnFocus = true;
            this.txtNomTipoEquipo.TextChanged += new System.EventHandler(this.txtNomTipoEquipo_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblUser.Location = new System.Drawing.Point(28, 36);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(48, 13);
            this.lblUser.TabIndex = 156;
            this.lblUser.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 145;
            this.label1.Text = "2.Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(275, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Nombre";
            // 
            // txtNomMarca
            // 
            this.txtNomMarca.BackColor = System.Drawing.Color.White;
            this.txtNomMarca.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtNomMarca.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomMarca.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNomMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomMarca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomMarca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNomMarca.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtNomMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomMarca.ForeColor = System.Drawing.Color.Black;
            this.txtNomMarca.Location = new System.Drawing.Point(278, 52);
            this.txtNomMarca.MaxLength = 20;
            this.txtNomMarca.Metrocolor = System.Drawing.Color.Silver;
            this.txtNomMarca.Name = "txtNomMarca";
            this.txtNomMarca.NearImage = global::MiNegocio.Desktop.Properties.Resources.Texto;
            this.txtNomMarca.Size = new System.Drawing.Size(181, 23);
            this.txtNomMarca.TabIndex = 3;
            this.txtNomMarca.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtNomMarca.ThemeStyle.CornerRadius = 0;
            this.txtNomMarca.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtNomMarca.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtNomMarca.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomMarca.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomMarca.UseBorderColorOnFocus = true;
            this.txtNomMarca.TextChanged += new System.EventHandler(this.txtNomMarca_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(16, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 145;
            this.label3.Text = "3.Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(28, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 156;
            this.label4.Text = "Nombre";
            // 
            // txtNomModelo
            // 
            this.txtNomModelo.BackColor = System.Drawing.Color.White;
            this.txtNomModelo.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtNomModelo.BorderColor = System.Drawing.Color.DimGray;
            this.txtNomModelo.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNomModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomModelo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNomModelo.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtNomModelo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomModelo.ForeColor = System.Drawing.Color.Black;
            this.txtNomModelo.Location = new System.Drawing.Point(31, 338);
            this.txtNomModelo.MaxLength = 20;
            this.txtNomModelo.Metrocolor = System.Drawing.Color.Silver;
            this.txtNomModelo.Name = "txtNomModelo";
            this.txtNomModelo.NearImage = global::MiNegocio.Desktop.Properties.Resources.Telefono;
            this.txtNomModelo.Size = new System.Drawing.Size(181, 23);
            this.txtNomModelo.TabIndex = 6;
            this.txtNomModelo.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtNomModelo.ThemeStyle.CornerRadius = 0;
            this.txtNomModelo.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtNomModelo.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtNomModelo.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNomModelo.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNomModelo.UseBorderColorOnFocus = true;
            this.txtNomModelo.TextChanged += new System.EventHandler(this.txtNomModelo_TextChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Location = new System.Drawing.Point(278, 339);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(181, 24);
            this.cmbMarca.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbMarca.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMarca.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(275, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 169;
            this.label6.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(275, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 169;
            this.label5.Text = "Tipo de Equipo";
            // 
            // cmbTE
            // 
            this.cmbTE.Location = new System.Drawing.Point(278, 395);
            this.cmbTE.Name = "cmbTE";
            this.cmbTE.Size = new System.Drawing.Size(181, 24);
            this.cmbTE.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.cmbTE.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTE.TabIndex = 8;
            // 
            // pbLoadModel
            // 
            this.pbLoadModel.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadModel.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016DarkGray;
            this.pbLoadModel.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoadModel.BackSegments = false;
            this.pbLoadModel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.pbLoadModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbLoadModel.CustomText = null;
            this.pbLoadModel.CustomWaitingRender = false;
            this.pbLoadModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoadModel.ForeColor = System.Drawing.Color.White;
            this.pbLoadModel.ForegroundImage = null;
            this.pbLoadModel.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadModel.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadModel.Location = new System.Drawing.Point(55, 422);
            this.pbLoadModel.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoadModel.Name = "pbLoadModel";
            this.pbLoadModel.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoadModel.SegmentWidth = 12;
            this.pbLoadModel.Size = new System.Drawing.Size(126, 6);
            this.pbLoadModel.TabIndex = 172;
            this.pbLoadModel.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoadModel.ThemeName = "WaitingGradient";
            this.pbLoadModel.ThemeStyle.BorderThickness = 0;
            this.pbLoadModel.WaitingGradientEnabled = true;
            this.pbLoadModel.WaitingGradientInterval = 70;
            this.pbLoadModel.WaitingGradientWidth = 100;
            // 
            // dgvTipoEquipo
            // 
            this.dgvTipoEquipo.AccessibleName = "Table";
            this.dgvTipoEquipo.AllowDeleting = true;
            this.dgvTipoEquipo.AllowFiltering = true;
            this.dgvTipoEquipo.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dgvTipoEquipo.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvTipoEquipo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTipoEquipo.Location = new System.Drawing.Point(31, 81);
            this.dgvTipoEquipo.Name = "dgvTipoEquipo";
            this.dgvTipoEquipo.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvTipoEquipo.Size = new System.Drawing.Size(181, 149);
            this.dgvTipoEquipo.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvTipoEquipo.TabIndex = 173;
            this.dgvTipoEquipo.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvTipoEquipo_CellDoubleClick);
            // 
            // dgvMarca
            // 
            this.dgvMarca.AccessibleName = "Table";
            this.dgvMarca.AllowDeleting = true;
            this.dgvMarca.AllowFiltering = true;
            this.dgvMarca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarca.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dgvMarca.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvMarca.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMarca.Location = new System.Drawing.Point(278, 81);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvMarca.Size = new System.Drawing.Size(181, 149);
            this.dgvMarca.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvMarca.TabIndex = 173;
            this.dgvMarca.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvMarca_CellDoubleClick);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::MiNegocio.Desktop.Properties.Resources._128x128;
            this.pbLoading.Location = new System.Drawing.Point(177, 229);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(136, 99);
            this.pbLoading.TabIndex = 174;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(64, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 176;
            this.label11.Text = "Guardar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(116, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 12);
            this.label7.TabIndex = 176;
            this.label7.Text = "Actualizar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label16.Location = new System.Drawing.Point(155, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 12);
            this.label16.TabIndex = 176;
            this.label16.Text = "Eliminar";
            // 
            // pbLoadTE
            // 
            this.pbLoadTE.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadTE.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016DarkGray;
            this.pbLoadTE.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoadTE.BackSegments = false;
            this.pbLoadTE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.pbLoadTE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbLoadTE.CustomText = null;
            this.pbLoadTE.CustomWaitingRender = false;
            this.pbLoadTE.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoadTE.ForeColor = System.Drawing.Color.White;
            this.pbLoadTE.ForegroundImage = null;
            this.pbLoadTE.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadTE.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadTE.Location = new System.Drawing.Point(59, 279);
            this.pbLoadTE.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoadTE.Name = "pbLoadTE";
            this.pbLoadTE.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoadTE.SegmentWidth = 12;
            this.pbLoadTE.Size = new System.Drawing.Size(126, 6);
            this.pbLoadTE.TabIndex = 177;
            this.pbLoadTE.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoadTE.ThemeName = "WaitingGradient";
            this.pbLoadTE.ThemeStyle.BorderThickness = 0;
            this.pbLoadTE.WaitingGradientEnabled = true;
            this.pbLoadTE.WaitingGradientInterval = 70;
            this.pbLoadTE.WaitingGradientWidth = 100;
            // 
            // pbLoadMarca
            // 
            this.pbLoadMarca.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadMarca.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Office2016DarkGray;
            this.pbLoadMarca.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.pbLoadMarca.BackSegments = false;
            this.pbLoadMarca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.pbLoadMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pbLoadMarca.CustomText = null;
            this.pbLoadMarca.CustomWaitingRender = false;
            this.pbLoadMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbLoadMarca.ForeColor = System.Drawing.Color.White;
            this.pbLoadMarca.ForegroundImage = null;
            this.pbLoadMarca.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadMarca.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.pbLoadMarca.Location = new System.Drawing.Point(301, 277);
            this.pbLoadMarca.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoadMarca.Name = "pbLoadMarca";
            this.pbLoadMarca.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoadMarca.SegmentWidth = 12;
            this.pbLoadMarca.Size = new System.Drawing.Size(126, 6);
            this.pbLoadMarca.TabIndex = 178;
            this.pbLoadMarca.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoadMarca.ThemeName = "WaitingGradient";
            this.pbLoadMarca.ThemeStyle.BorderThickness = 0;
            this.pbLoadMarca.WaitingGradientEnabled = true;
            this.pbLoadMarca.WaitingGradientInterval = 70;
            this.pbLoadMarca.WaitingGradientWidth = 100;
            // 
            // dgvModelo
            // 
            this.dgvModelo.AccessibleName = "Table";
            this.dgvModelo.AllowDeleting = true;
            this.dgvModelo.AllowFiltering = true;
            this.dgvModelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvModelo.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.dgvModelo.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvModelo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvModelo.Location = new System.Drawing.Point(31, 434);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvModelo.Size = new System.Drawing.Size(428, 117);
            this.dgvModelo.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvModelo.TabIndex = 179;
            this.dgvModelo.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvModelo_CellDoubleClick);
            // 
            // btnGuardaTE
            // 
            this.btnGuardaTE.AccessibleName = "Button";
            this.btnGuardaTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaTE.FocusRectangleVisible = true;
            this.btnGuardaTE.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnGuardaTE.ForeColor = System.Drawing.Color.White;
            this.btnGuardaTE.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaTE.ImageSize = new System.Drawing.Size(18, 18);
            this.btnGuardaTE.Location = new System.Drawing.Point(67, 236);
            this.btnGuardaTE.Name = "btnGuardaTE";
            this.btnGuardaTE.Size = new System.Drawing.Size(30, 30);
            this.btnGuardaTE.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaTE.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnGuardaTE.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaTE.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaTE.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaTE.Style.ForeColor = System.Drawing.Color.White;
            this.btnGuardaTE.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnGuardaTE.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaTE.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Guardar;
            this.btnGuardaTE.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnGuardaTE.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaTE.TabIndex = 1;
            this.btnGuardaTE.UseVisualStyleBackColor = false;
            this.btnGuardaTE.Click += new System.EventHandler(this.btnGuardaTE_Click);
            // 
            // btnUpdateTE
            // 
            this.btnUpdateTE.AccessibleName = "Button";
            this.btnUpdateTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTE.FocusRectangleVisible = true;
            this.btnUpdateTE.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnUpdateTE.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTE.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateTE.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateTE.Location = new System.Drawing.Point(122, 236);
            this.btnUpdateTE.Name = "btnUpdateTE";
            this.btnUpdateTE.Size = new System.Drawing.Size(30, 30);
            this.btnUpdateTE.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateTE.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnUpdateTE.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateTE.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateTE.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateTE.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTE.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnUpdateTE.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateTE.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Actualizar;
            this.btnUpdateTE.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnUpdateTE.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateTE.TabIndex = 2;
            this.btnUpdateTE.UseVisualStyleBackColor = false;
            this.btnUpdateTE.Click += new System.EventHandler(this.btnUpdateTE_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(311, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 176;
            this.label8.Text = "Guardar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(363, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 12);
            this.label9.TabIndex = 176;
            this.label9.Text = "Actualizar";
            // 
            // btnGuardaMarca
            // 
            this.btnGuardaMarca.AccessibleName = "Button";
            this.btnGuardaMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaMarca.FocusRectangleVisible = true;
            this.btnGuardaMarca.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnGuardaMarca.ForeColor = System.Drawing.Color.White;
            this.btnGuardaMarca.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaMarca.ImageSize = new System.Drawing.Size(18, 18);
            this.btnGuardaMarca.Location = new System.Drawing.Point(314, 236);
            this.btnGuardaMarca.Name = "btnGuardaMarca";
            this.btnGuardaMarca.Size = new System.Drawing.Size(30, 30);
            this.btnGuardaMarca.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaMarca.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnGuardaMarca.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaMarca.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaMarca.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaMarca.Style.ForeColor = System.Drawing.Color.White;
            this.btnGuardaMarca.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnGuardaMarca.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaMarca.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Guardar;
            this.btnGuardaMarca.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnGuardaMarca.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaMarca.TabIndex = 4;
            this.btnGuardaMarca.UseVisualStyleBackColor = false;
            this.btnGuardaMarca.Click += new System.EventHandler(this.btnGuardaMarca_Click);
            // 
            // btnUpdateMarca
            // 
            this.btnUpdateMarca.AccessibleName = "Button";
            this.btnUpdateMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMarca.FocusRectangleVisible = true;
            this.btnUpdateMarca.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnUpdateMarca.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMarca.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateMarca.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateMarca.Location = new System.Drawing.Point(369, 236);
            this.btnUpdateMarca.Name = "btnUpdateMarca";
            this.btnUpdateMarca.Size = new System.Drawing.Size(30, 30);
            this.btnUpdateMarca.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateMarca.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnUpdateMarca.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarca.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateMarca.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarca.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateMarca.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnUpdateMarca.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarca.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Actualizar;
            this.btnUpdateMarca.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnUpdateMarca.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarca.TabIndex = 5;
            this.btnUpdateMarca.UseVisualStyleBackColor = false;
            this.btnUpdateMarca.Click += new System.EventHandler(this.btnUpdateMarca_Click);
            // 
            // btnUpdateModelo
            // 
            this.btnUpdateModelo.AccessibleName = "Button";
            this.btnUpdateModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateModelo.FocusRectangleVisible = true;
            this.btnUpdateModelo.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnUpdateModelo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateModelo.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateModelo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdateModelo.Location = new System.Drawing.Point(102, 378);
            this.btnUpdateModelo.Name = "btnUpdateModelo";
            this.btnUpdateModelo.Size = new System.Drawing.Size(30, 30);
            this.btnUpdateModelo.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateModelo.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnUpdateModelo.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateModelo.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnUpdateModelo.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateModelo.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateModelo.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnUpdateModelo.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateModelo.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Actualizar;
            this.btnUpdateModelo.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnUpdateModelo.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateModelo.TabIndex = 10;
            this.btnUpdateModelo.UseVisualStyleBackColor = false;
            this.btnUpdateModelo.Click += new System.EventHandler(this.btnUpdateModelo_Click);
            // 
            // btnGuardaModelo
            // 
            this.btnGuardaModelo.AccessibleName = "Button";
            this.btnGuardaModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaModelo.FocusRectangleVisible = true;
            this.btnGuardaModelo.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnGuardaModelo.ForeColor = System.Drawing.Color.White;
            this.btnGuardaModelo.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardaModelo.ImageSize = new System.Drawing.Size(18, 18);
            this.btnGuardaModelo.Location = new System.Drawing.Point(46, 378);
            this.btnGuardaModelo.Name = "btnGuardaModelo";
            this.btnGuardaModelo.Size = new System.Drawing.Size(30, 30);
            this.btnGuardaModelo.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaModelo.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnGuardaModelo.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaModelo.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardaModelo.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaModelo.Style.ForeColor = System.Drawing.Color.White;
            this.btnGuardaModelo.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnGuardaModelo.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaModelo.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Guardar;
            this.btnGuardaModelo.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnGuardaModelo.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardaModelo.TabIndex = 9;
            this.btnGuardaModelo.UseVisualStyleBackColor = false;
            this.btnGuardaModelo.Click += new System.EventHandler(this.btnGuardaModelo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(96, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 12);
            this.label10.TabIndex = 182;
            this.label10.Text = "Actualizar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label12.Location = new System.Drawing.Point(43, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 12);
            this.label12.TabIndex = 183;
            this.label12.Text = "Guardar";
            // 
            // btnDeleteModelo
            // 
            this.btnDeleteModelo.AccessibleName = "Button";
            this.btnDeleteModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnDeleteModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModelo.FocusRectangleVisible = true;
            this.btnDeleteModelo.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btnDeleteModelo.ForeColor = System.Drawing.Color.White;
            this.btnDeleteModelo.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteModelo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDeleteModelo.Location = new System.Drawing.Point(157, 378);
            this.btnDeleteModelo.Name = "btnDeleteModelo";
            this.btnDeleteModelo.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteModelo.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnDeleteModelo.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnDeleteModelo.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteModelo.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnDeleteModelo.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteModelo.Style.ForeColor = System.Drawing.Color.White;
            this.btnDeleteModelo.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnDeleteModelo.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteModelo.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Eliminar;
            this.btnDeleteModelo.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnDeleteModelo.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteModelo.TabIndex = 11;
            this.btnDeleteModelo.UseVisualStyleBackColor = false;
            // 
            // frmMasterEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 556);
            this.Controls.Add(this.btnDeleteModelo);
            this.Controls.Add(this.btnUpdateModelo);
            this.Controls.Add(this.btnGuardaModelo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnUpdateMarca);
            this.Controls.Add(this.btnGuardaMarca);
            this.Controls.Add(this.btnUpdateTE);
            this.Controls.Add(this.btnGuardaTE);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.dgvModelo);
            this.Controls.Add(this.pbLoadMarca);
            this.Controls.Add(this.pbLoadTE);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvMarca);
            this.Controls.Add(this.dgvTipoEquipo);
            this.Controls.Add(this.pbLoadModel);
            this.Controls.Add(this.cmbTE);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNomModelo);
            this.Controls.Add(this.txtNomMarca);
            this.Controls.Add(this.txtNomTipoEquipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMasterEquipo";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maestro de Equipos";
            this.Shown += new System.EventHandler(this.frmMasterEquipo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomTipoEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoEquipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNomTipoEquipo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNomMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNomModelo;
        private Syncfusion.WinForms.ListView.SfComboBox cmbMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Syncfusion.WinForms.ListView.SfComboBox cmbTE;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoadModel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvTipoEquipo;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvMarca;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoadTE;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoadMarca;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvModelo;
        private Syncfusion.WinForms.Controls.SfButton btnGuardaTE;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateTE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Syncfusion.WinForms.Controls.SfButton btnGuardaMarca;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateMarca;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateModelo;
        private Syncfusion.WinForms.Controls.SfButton btnGuardaModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteModelo;
    }
}