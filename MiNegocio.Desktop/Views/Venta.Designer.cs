namespace MiNegocio.Desktop.Views
{
    partial class frmVenta
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
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.txtObservaciones = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCodProducto = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.txtCliente = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnBuscaCliente = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuscaProducto = new Bunifu.Framework.UI.BunifuImageButton();
            this.gbPrint = new System.Windows.Forms.GroupBox();
            this.rbRemision = new System.Windows.Forms.RadioButton();
            this.rbOficial = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblMsjDetalle = new System.Windows.Forms.RichTextBox();
            this.lblMsj = new System.Windows.Forms.RichTextBox();
            this.txtDescuento = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.txtCantidad = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnReporte = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscaFactura = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnularVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.gbNomProducto = new System.Windows.Forms.GroupBox();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.gbDisponible = new System.Windows.Forms.GroupBox();
            this.lblDisponible = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbVlrUnitario = new System.Windows.Forms.GroupBox();
            this.lblVlrUnitario = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbTipoProd = new System.Windows.Forms.GroupBox();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.gbCantItem = new System.Windows.Forms.GroupBox();
            this.lblCantItem = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbDcto = new System.Windows.Forms.GroupBox();
            this.lblDcto = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbSubTotal = new System.Windows.Forms.GroupBox();
            this.lblSubTotal = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.gbStockMin = new System.Windows.Forms.GroupBox();
            this.lblStockMin = new Syncfusion.WinForms.Input.SfNumericTextBox();
            this.btnVender = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvDetalle = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.sfComboBox2 = new Syncfusion.WinForms.ListView.SfComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaProducto)).BeginInit();
            this.gbPrint.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNomProducto.SuspendLayout();
            this.gbDisponible.SuspendLayout();
            this.gbVlrUnitario.SuspendLayout();
            this.gbTipoProd.SuspendLayout();
            this.gbCantItem.SuspendLayout();
            this.gbDcto.SuspendLayout();
            this.gbSubTotal.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.gbStockMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbLoading.Image = global::MiNegocio.Desktop.Properties.Resources._128x128;
            this.pbLoading.Location = new System.Drawing.Point(377, 246);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(136, 99);
            this.pbLoading.TabIndex = 164;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 169;
            this.label6.Text = "4.Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 17);
            this.label5.TabIndex = 168;
            this.label5.Text = "3.Observaciones y Forma de Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 167;
            this.label4.Text = "2.Datos del Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 166;
            this.label3.Text = "1.Datos del Cliente";
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
            this.pbLoad.Location = new System.Drawing.Point(761, 231);
            this.pbLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoad.SegmentWidth = 12;
            this.pbLoad.Size = new System.Drawing.Size(100, 6);
            this.pbLoad.TabIndex = 165;
            this.pbLoad.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoad.ThemeName = "WaitingGradient";
            this.pbLoad.ThemeStyle.BorderThickness = 0;
            this.pbLoad.WaitingGradientEnabled = true;
            this.pbLoad.WaitingGradientInterval = 70;
            this.pbLoad.WaitingGradientWidth = 100;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.White;
            this.txtObservaciones.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtObservaciones.BorderColor = System.Drawing.Color.DimGray;
            this.txtObservaciones.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservaciones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtObservaciones.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.ForeColor = System.Drawing.Color.Black;
            this.txtObservaciones.Location = new System.Drawing.Point(42, 264);
            this.txtObservaciones.MaxLength = 1000;
            this.txtObservaciones.Metrocolor = System.Drawing.Color.Silver;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.NearImage = global::MiNegocio.Desktop.Properties.Resources.Observaciones;
            this.txtObservaciones.Size = new System.Drawing.Size(437, 23);
            this.txtObservaciones.TabIndex = 134;
            this.txtObservaciones.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtObservaciones.ThemeStyle.CornerRadius = 0;
            this.txtObservaciones.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtObservaciones.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtObservaciones.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtObservaciones.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtObservaciones.UseBorderColorOnFocus = true;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.Color.White;
            this.txtCodProducto.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtCodProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodProducto.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodProducto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCodProducto.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtCodProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodProducto.ForeColor = System.Drawing.Color.Black;
            this.txtCodProducto.Location = new System.Drawing.Point(42, 132);
            this.txtCodProducto.MaxLength = 10;
            this.txtCodProducto.Metrocolor = System.Drawing.Color.Silver;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.NearImage = global::MiNegocio.Desktop.Properties.Resources.Serial;
            this.txtCodProducto.Size = new System.Drawing.Size(181, 23);
            this.txtCodProducto.TabIndex = 131;
            this.txtCodProducto.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtCodProducto.ThemeStyle.CornerRadius = 0;
            this.txtCodProducto.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtCodProducto.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtCodProducto.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodProducto.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodProducto.UseBorderColorOnFocus = true;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BeforeTouchSize = new System.Drawing.Size(181, 23);
            this.txtCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtCliente.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtCliente.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(42, 47);
            this.txtCliente.MaxLength = 10;
            this.txtCliente.Metrocolor = System.Drawing.Color.Silver;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.NearImage = global::MiNegocio.Desktop.Properties.Resources.UserIcon;
            this.txtCliente.Size = new System.Drawing.Size(181, 23);
            this.txtCliente.TabIndex = 130;
            this.txtCliente.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtCliente.ThemeStyle.CornerRadius = 0;
            this.txtCliente.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtCliente.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtCliente.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCliente.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCliente.UseBorderColorOnFocus = true;
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaCliente.Image = global::MiNegocio.Desktop.Properties.Resources.buscarBlackGrande;
            this.btnBuscaCliente.ImageActive = null;
            this.btnBuscaCliente.Location = new System.Drawing.Point(13, 52);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(20, 20);
            this.btnBuscaCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscaCliente.TabIndex = 163;
            this.btnBuscaCliente.TabStop = false;
            this.btnBuscaCliente.Zoom = 20;
            // 
            // btnBuscaProducto
            // 
            this.btnBuscaProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscaProducto.Image = global::MiNegocio.Desktop.Properties.Resources.buscarBlackGrande;
            this.btnBuscaProducto.ImageActive = null;
            this.btnBuscaProducto.Location = new System.Drawing.Point(16, 137);
            this.btnBuscaProducto.Name = "btnBuscaProducto";
            this.btnBuscaProducto.Size = new System.Drawing.Size(20, 20);
            this.btnBuscaProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscaProducto.TabIndex = 162;
            this.btnBuscaProducto.TabStop = false;
            this.btnBuscaProducto.Zoom = 20;
            // 
            // gbPrint
            // 
            this.gbPrint.Controls.Add(this.rbRemision);
            this.gbPrint.Controls.Add(this.rbOficial);
            this.gbPrint.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbPrint.Location = new System.Drawing.Point(763, 17);
            this.gbPrint.Name = "gbPrint";
            this.gbPrint.Size = new System.Drawing.Size(98, 55);
            this.gbPrint.TabIndex = 161;
            this.gbPrint.TabStop = false;
            this.gbPrint.Text = "Impresión";
            // 
            // rbRemision
            // 
            this.rbRemision.AutoSize = true;
            this.rbRemision.Checked = true;
            this.rbRemision.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbRemision.ForeColor = System.Drawing.Color.Black;
            this.rbRemision.Location = new System.Drawing.Point(6, 13);
            this.rbRemision.Name = "rbRemision";
            this.rbRemision.Size = new System.Drawing.Size(72, 17);
            this.rbRemision.TabIndex = 91;
            this.rbRemision.TabStop = true;
            this.rbRemision.Text = "Remisión";
            this.rbRemision.UseVisualStyleBackColor = true;
            // 
            // rbOficial
            // 
            this.rbOficial.AutoSize = true;
            this.rbOficial.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbOficial.ForeColor = System.Drawing.Color.Black;
            this.rbOficial.Location = new System.Drawing.Point(6, 34);
            this.rbOficial.Name = "rbOficial";
            this.rbOficial.Size = new System.Drawing.Size(58, 17);
            this.rbOficial.TabIndex = 91;
            this.rbOficial.Text = "Oficial";
            this.rbOficial.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.lblMsjDetalle);
            this.groupBox6.Controls.Add(this.lblMsj);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.groupBox6.Location = new System.Drawing.Point(12, 539);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(350, 41);
            this.groupBox6.TabIndex = 160;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // lblMsjDetalle
            // 
            this.lblMsjDetalle.BackColor = System.Drawing.Color.White;
            this.lblMsjDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMsjDetalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMsjDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblMsjDetalle.Location = new System.Drawing.Point(6, 15);
            this.lblMsjDetalle.MaxLength = 2000;
            this.lblMsjDetalle.Name = "lblMsjDetalle";
            this.lblMsjDetalle.ReadOnly = true;
            this.lblMsjDetalle.Size = new System.Drawing.Size(338, 19);
            this.lblMsjDetalle.TabIndex = 90;
            this.lblMsjDetalle.Text = "A";
            // 
            // lblMsj
            // 
            this.lblMsj.BackColor = System.Drawing.Color.White;
            this.lblMsj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMsj.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.lblMsj.Location = new System.Drawing.Point(6, 15);
            this.lblMsj.MaxLength = 2000;
            this.lblMsj.Name = "lblMsj";
            this.lblMsj.ReadOnly = true;
            this.lblMsj.Size = new System.Drawing.Size(338, 19);
            this.lblMsj.TabIndex = 90;
            this.lblMsj.Text = "A";
            // 
            // txtDescuento
            // 
            this.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescuento.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtDescuento.ForeColor = System.Drawing.Color.Black;
            this.txtDescuento.HideTrailingZeros = true;
            this.txtDescuento.Location = new System.Drawing.Point(155, 183);
            this.txtDescuento.MaxLength = 9;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(68, 27);
            this.txtDescuento.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.txtDescuento.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.txtDescuento.Style.NegativeForeColor = System.Drawing.Color.DarkGreen;
            this.txtDescuento.Style.PositiveForeColor = System.Drawing.Color.Red;
            this.txtDescuento.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.txtDescuento.TabIndex = 133;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescuento.WatermarkText = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.txtCantidad.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtCantidad.HideTrailingZeros = true;
            this.txtCantidad.Location = new System.Drawing.Point(42, 183);
            this.txtCantidad.MaxLength = 9;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 27);
            this.txtCantidad.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.txtCantidad.Style.DisabledBorderColor = System.Drawing.Color.OrangeRed;
            this.txtCantidad.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCantidad.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.txtCantidad.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.txtCantidad.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.txtCantidad.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.txtCantidad.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.txtCantidad.TabIndex = 132;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.Value = 1D;
            this.txtCantidad.WatermarkText = "";
            // 
            // btnReporte
            // 
            this.btnReporte.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.BorderRadius = 4;
            this.btnReporte.ButtonText = "";
            this.btnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporte.DisabledColor = System.Drawing.Color.Gray;
            this.btnReporte.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReporte.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Reportes;
            this.btnReporte.Iconimage_right = null;
            this.btnReporte.Iconimage_right_Selected = null;
            this.btnReporte.Iconimage_Selected = null;
            this.btnReporte.IconMarginLeft = 0;
            this.btnReporte.IconMarginRight = 0;
            this.btnReporte.IconRightVisible = true;
            this.btnReporte.IconRightZoom = 0D;
            this.btnReporte.IconVisible = true;
            this.btnReporte.IconZoom = 55D;
            this.btnReporte.IsTab = false;
            this.btnReporte.Location = new System.Drawing.Point(828, 177);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnReporte.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btnReporte.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReporte.selected = false;
            this.btnReporte.Size = new System.Drawing.Size(35, 35);
            this.btnReporte.TabIndex = 138;
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReporte.Textcolor = System.Drawing.Color.White;
            this.btnReporte.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnBuscaFactura
            // 
            this.btnBuscaFactura.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.btnBuscaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnBuscaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscaFactura.BorderRadius = 4;
            this.btnBuscaFactura.ButtonText = "";
            this.btnBuscaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaFactura.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscaFactura.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscaFactura.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Buscar;
            this.btnBuscaFactura.Iconimage_right = null;
            this.btnBuscaFactura.Iconimage_right_Selected = null;
            this.btnBuscaFactura.Iconimage_Selected = null;
            this.btnBuscaFactura.IconMarginLeft = 0;
            this.btnBuscaFactura.IconMarginRight = 0;
            this.btnBuscaFactura.IconRightVisible = true;
            this.btnBuscaFactura.IconRightZoom = 0D;
            this.btnBuscaFactura.IconVisible = true;
            this.btnBuscaFactura.IconZoom = 55D;
            this.btnBuscaFactura.IsTab = false;
            this.btnBuscaFactura.Location = new System.Drawing.Point(828, 122);
            this.btnBuscaFactura.Name = "btnBuscaFactura";
            this.btnBuscaFactura.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnBuscaFactura.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btnBuscaFactura.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscaFactura.selected = false;
            this.btnBuscaFactura.Size = new System.Drawing.Size(35, 35);
            this.btnBuscaFactura.TabIndex = 136;
            this.btnBuscaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscaFactura.Textcolor = System.Drawing.Color.White;
            this.btnBuscaFactura.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAnularVenta
            // 
            this.btnAnularVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.btnAnularVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnAnularVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnularVenta.BorderRadius = 4;
            this.btnAnularVenta.ButtonText = "";
            this.btnAnularVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularVenta.DisabledColor = System.Drawing.SystemColors.GrayText;
            this.btnAnularVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnularVenta.Iconimage = global::MiNegocio.Desktop.Properties.Resources.AnularVenta;
            this.btnAnularVenta.Iconimage_right = null;
            this.btnAnularVenta.Iconimage_right_Selected = null;
            this.btnAnularVenta.Iconimage_Selected = null;
            this.btnAnularVenta.IconMarginLeft = 0;
            this.btnAnularVenta.IconMarginRight = 0;
            this.btnAnularVenta.IconRightVisible = true;
            this.btnAnularVenta.IconRightZoom = 0D;
            this.btnAnularVenta.IconVisible = true;
            this.btnAnularVenta.IconZoom = 55D;
            this.btnAnularVenta.IsTab = false;
            this.btnAnularVenta.Location = new System.Drawing.Point(763, 177);
            this.btnAnularVenta.Name = "btnAnularVenta";
            this.btnAnularVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnAnularVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btnAnularVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnularVenta.selected = false;
            this.btnAnularVenta.Size = new System.Drawing.Size(35, 35);
            this.btnAnularVenta.TabIndex = 137;
            this.btnAnularVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnularVenta.Textcolor = System.Drawing.Color.White;
            this.btnAnularVenta.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNomCliente);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.groupBox1.Location = new System.Drawing.Point(258, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 41);
            this.groupBox1.TabIndex = 154;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNomCliente.ForeColor = System.Drawing.Color.Red;
            this.lblNomCliente.Location = new System.Drawing.Point(6, 15);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(18, 19);
            this.lblNomCliente.TabIndex = 44;
            this.lblNomCliente.Text = "C";
            // 
            // gbNomProducto
            // 
            this.gbNomProducto.BackColor = System.Drawing.Color.Transparent;
            this.gbNomProducto.Controls.Add(this.lblNomProducto);
            this.gbNomProducto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNomProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbNomProducto.Location = new System.Drawing.Point(258, 116);
            this.gbNomProducto.Name = "gbNomProducto";
            this.gbNomProducto.Size = new System.Drawing.Size(481, 41);
            this.gbNomProducto.TabIndex = 158;
            this.gbNomProducto.TabStop = false;
            this.gbNomProducto.Text = "Producto";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNomProducto.ForeColor = System.Drawing.Color.Red;
            this.lblNomProducto.Location = new System.Drawing.Point(6, 17);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(18, 19);
            this.lblNomProducto.TabIndex = 59;
            this.lblNomProducto.Text = "C";
            // 
            // gbDisponible
            // 
            this.gbDisponible.BackColor = System.Drawing.Color.Transparent;
            this.gbDisponible.Controls.Add(this.lblDisponible);
            this.gbDisponible.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDisponible.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbDisponible.Location = new System.Drawing.Point(386, 163);
            this.gbDisponible.Name = "gbDisponible";
            this.gbDisponible.Size = new System.Drawing.Size(104, 45);
            this.gbDisponible.TabIndex = 157;
            this.gbDisponible.TabStop = false;
            this.gbDisponible.Text = "Disponible";
            // 
            // lblDisponible
            // 
            this.lblDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisponible.Enabled = false;
            this.lblDisponible.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDisponible.ForeColor = System.Drawing.Color.Black;
            this.lblDisponible.HideTrailingZeros = true;
            this.lblDisponible.Location = new System.Drawing.Point(6, 21);
            this.lblDisponible.MaxLength = 9;
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(87, 20);
            this.lblDisponible.Style.BorderColor = System.Drawing.Color.White;
            this.lblDisponible.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblDisponible.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblDisponible.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblDisponible.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblDisponible.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblDisponible.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblDisponible.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisponible.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblDisponible.TabIndex = 2;
            this.lblDisponible.Text = "0";
            this.lblDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblDisponible.WatermarkText = "";
            // 
            // gbVlrUnitario
            // 
            this.gbVlrUnitario.BackColor = System.Drawing.Color.Transparent;
            this.gbVlrUnitario.Controls.Add(this.lblVlrUnitario);
            this.gbVlrUnitario.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVlrUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbVlrUnitario.Location = new System.Drawing.Point(258, 163);
            this.gbVlrUnitario.Name = "gbVlrUnitario";
            this.gbVlrUnitario.Size = new System.Drawing.Size(122, 45);
            this.gbVlrUnitario.TabIndex = 156;
            this.gbVlrUnitario.TabStop = false;
            this.gbVlrUnitario.Text = "Valor unitario";
            // 
            // lblVlrUnitario
            // 
            this.lblVlrUnitario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVlrUnitario.Enabled = false;
            this.lblVlrUnitario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblVlrUnitario.ForeColor = System.Drawing.Color.Black;
            this.lblVlrUnitario.HideTrailingZeros = true;
            this.lblVlrUnitario.Location = new System.Drawing.Point(6, 21);
            this.lblVlrUnitario.MaxLength = 9;
            this.lblVlrUnitario.Name = "lblVlrUnitario";
            this.lblVlrUnitario.Size = new System.Drawing.Size(109, 20);
            this.lblVlrUnitario.Style.BorderColor = System.Drawing.Color.White;
            this.lblVlrUnitario.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblVlrUnitario.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblVlrUnitario.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblVlrUnitario.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblVlrUnitario.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblVlrUnitario.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblVlrUnitario.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblVlrUnitario.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblVlrUnitario.TabIndex = 2;
            this.lblVlrUnitario.Text = "0";
            this.lblVlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblVlrUnitario.WatermarkText = "";
            // 
            // gbTipoProd
            // 
            this.gbTipoProd.BackColor = System.Drawing.Color.Transparent;
            this.gbTipoProd.Controls.Add(this.lblTipoProd);
            this.gbTipoProd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbTipoProd.Location = new System.Drawing.Point(606, 163);
            this.gbTipoProd.Name = "gbTipoProd";
            this.gbTipoProd.Size = new System.Drawing.Size(133, 45);
            this.gbTipoProd.TabIndex = 155;
            this.gbTipoProd.TabStop = false;
            this.gbTipoProd.Text = "Tipo de producto";
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProd.ForeColor = System.Drawing.Color.Black;
            this.lblTipoProd.Location = new System.Drawing.Point(6, 24);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(0, 17);
            this.lblTipoProd.TabIndex = 59;
            // 
            // gbCantItem
            // 
            this.gbCantItem.BackColor = System.Drawing.Color.Transparent;
            this.gbCantItem.Controls.Add(this.lblCantItem);
            this.gbCantItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCantItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbCantItem.Location = new System.Drawing.Point(368, 539);
            this.gbCantItem.Name = "gbCantItem";
            this.gbCantItem.Size = new System.Drawing.Size(123, 41);
            this.gbCantItem.TabIndex = 159;
            this.gbCantItem.TabStop = false;
            this.gbCantItem.Text = "Cantidad items";
            // 
            // lblCantItem
            // 
            this.lblCantItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCantItem.Enabled = false;
            this.lblCantItem.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblCantItem.ForeColor = System.Drawing.Color.Black;
            this.lblCantItem.HideTrailingZeros = true;
            this.lblCantItem.Location = new System.Drawing.Point(21, 16);
            this.lblCantItem.MaxLength = 9;
            this.lblCantItem.Name = "lblCantItem";
            this.lblCantItem.Size = new System.Drawing.Size(80, 20);
            this.lblCantItem.Style.BorderColor = System.Drawing.Color.White;
            this.lblCantItem.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblCantItem.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblCantItem.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblCantItem.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblCantItem.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblCantItem.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblCantItem.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblCantItem.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblCantItem.TabIndex = 2;
            this.lblCantItem.Text = "0";
            this.lblCantItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblCantItem.WatermarkText = "Cantidad";
            // 
            // gbDcto
            // 
            this.gbDcto.BackColor = System.Drawing.Color.Transparent;
            this.gbDcto.Controls.Add(this.lblDcto);
            this.gbDcto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDcto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbDcto.Location = new System.Drawing.Point(626, 539);
            this.gbDcto.Name = "gbDcto";
            this.gbDcto.Size = new System.Drawing.Size(123, 41);
            this.gbDcto.TabIndex = 153;
            this.gbDcto.TabStop = false;
            this.gbDcto.Text = "Descuentos";
            // 
            // lblDcto
            // 
            this.lblDcto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDcto.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblDcto.ForeColor = System.Drawing.Color.Black;
            this.lblDcto.HideTrailingZeros = true;
            this.lblDcto.Location = new System.Drawing.Point(6, 16);
            this.lblDcto.MaxLength = 9;
            this.lblDcto.Name = "lblDcto";
            this.lblDcto.ReadOnly = true;
            this.lblDcto.Size = new System.Drawing.Size(111, 20);
            this.lblDcto.Style.BorderColor = System.Drawing.Color.White;
            this.lblDcto.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblDcto.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblDcto.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblDcto.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblDcto.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblDcto.Style.NegativeForeColor = System.Drawing.Color.Black;
            this.lblDcto.Style.PositiveForeColor = System.Drawing.Color.Red;
            this.lblDcto.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblDcto.TabIndex = 2;
            this.lblDcto.Text = "0";
            this.lblDcto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblDcto.ValueChangeMode = Syncfusion.WinForms.Input.Enums.ValueChangeMode.KeyPress;
            this.lblDcto.WatermarkText = "";
            // 
            // gbSubTotal
            // 
            this.gbSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.gbSubTotal.Controls.Add(this.lblSubTotal);
            this.gbSubTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbSubTotal.Location = new System.Drawing.Point(497, 539);
            this.gbSubTotal.Name = "gbSubTotal";
            this.gbSubTotal.Size = new System.Drawing.Size(123, 41);
            this.gbSubTotal.TabIndex = 152;
            this.gbSubTotal.TabStop = false;
            this.gbSubTotal.Text = "SubTotal";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSubTotal.Enabled = false;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.HideTrailingZeros = true;
            this.lblSubTotal.Location = new System.Drawing.Point(6, 17);
            this.lblSubTotal.MaxLength = 9;
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(111, 20);
            this.lblSubTotal.Style.BorderColor = System.Drawing.Color.White;
            this.lblSubTotal.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblSubTotal.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblSubTotal.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblSubTotal.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblSubTotal.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblSubTotal.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblSubTotal.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblSubTotal.TabIndex = 2;
            this.lblSubTotal.Text = "0";
            this.lblSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblSubTotal.WatermarkText = "Cantidad";
            // 
            // gbTotal
            // 
            this.gbTotal.BackColor = System.Drawing.Color.Transparent;
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbTotal.Location = new System.Drawing.Point(755, 539);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(123, 41);
            this.gbTotal.TabIndex = 151;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTotal.Enabled = false;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.HideTrailingZeros = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 17);
            this.lblTotal.MaxLength = 9;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(111, 20);
            this.lblTotal.Style.BorderColor = System.Drawing.Color.White;
            this.lblTotal.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblTotal.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblTotal.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblTotal.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblTotal.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblTotal.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblTotal.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotal.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblTotal.WatermarkText = "Cantidad";
            // 
            // gbStockMin
            // 
            this.gbStockMin.BackColor = System.Drawing.Color.Transparent;
            this.gbStockMin.Controls.Add(this.lblStockMin);
            this.gbStockMin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStockMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.gbStockMin.Location = new System.Drawing.Point(496, 163);
            this.gbStockMin.Name = "gbStockMin";
            this.gbStockMin.Size = new System.Drawing.Size(104, 45);
            this.gbStockMin.TabIndex = 150;
            this.gbStockMin.TabStop = false;
            this.gbStockMin.Text = "Stock mínimo";
            // 
            // lblStockMin
            // 
            this.lblStockMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStockMin.Enabled = false;
            this.lblStockMin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblStockMin.ForeColor = System.Drawing.Color.Black;
            this.lblStockMin.HideTrailingZeros = true;
            this.lblStockMin.Location = new System.Drawing.Point(6, 21);
            this.lblStockMin.MaxLength = 9;
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(87, 20);
            this.lblStockMin.Style.BorderColor = System.Drawing.Color.White;
            this.lblStockMin.Style.DisabledBackColor = System.Drawing.Color.White;
            this.lblStockMin.Style.DisabledBorderColor = System.Drawing.Color.White;
            this.lblStockMin.Style.DisabledForeColor = System.Drawing.Color.Black;
            this.lblStockMin.Style.FocusBorderColor = System.Drawing.Color.OrangeRed;
            this.lblStockMin.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.lblStockMin.Style.NegativeForeColor = System.Drawing.Color.Red;
            this.lblStockMin.Style.PositiveForeColor = System.Drawing.Color.DarkGreen;
            this.lblStockMin.Style.ZeroForeColor = System.Drawing.Color.Black;
            this.lblStockMin.TabIndex = 2;
            this.lblStockMin.Text = "0";
            this.lblStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblStockMin.WatermarkText = "";
            // 
            // btnVender
            // 
            this.btnVender.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(90)))), ((int)(((byte)(151)))));
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVender.BorderRadius = 4;
            this.btnVender.ButtonText = "";
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.DisabledColor = System.Drawing.Color.Gray;
            this.btnVender.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVender.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Vender;
            this.btnVender.Iconimage_right = null;
            this.btnVender.Iconimage_right_Selected = null;
            this.btnVender.Iconimage_Selected = null;
            this.btnVender.IconMarginLeft = 0;
            this.btnVender.IconMarginRight = 0;
            this.btnVender.IconRightVisible = true;
            this.btnVender.IconRightZoom = 0D;
            this.btnVender.IconVisible = true;
            this.btnVender.IconZoom = 55D;
            this.btnVender.IsTab = false;
            this.btnVender.Location = new System.Drawing.Point(763, 122);
            this.btnVender.Name = "btnVender";
            this.btnVender.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnVender.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(73)))));
            this.btnVender.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVender.selected = false;
            this.btnVender.Size = new System.Drawing.Size(35, 35);
            this.btnVender.TabIndex = 135;
            this.btnVender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVender.Textcolor = System.Drawing.Color.White;
            this.btnVender.TextFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(39, 248);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 149;
            this.label8.Text = "Observaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(504, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 148;
            this.label2.Text = "Forma de pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(152, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 147;
            this.label10.Text = "Descuento";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(830, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 12);
            this.label15.TabIndex = 142;
            this.label15.Text = "Buscar";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label14.Location = new System.Drawing.Point(825, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 12);
            this.label14.TabIndex = 143;
            this.label14.Text = "Reportes";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(764, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 12);
            this.label13.TabIndex = 144;
            this.label13.Text = "Anular";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label11.Location = new System.Drawing.Point(765, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 12);
            this.label11.TabIndex = 145;
            this.label11.Text = "Venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(39, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 146;
            this.label9.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 141;
            this.label1.Text = "Cliente";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblUser.Location = new System.Drawing.Point(39, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 13);
            this.lblUser.TabIndex = 140;
            this.lblUser.Text = "Código/Serial";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AccessibleName = "Table";
            this.dgvDetalle.AllowDeleting = true;
            this.dgvDetalle.AllowFiltering = true;
            this.dgvDetalle.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvDetalle.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvDetalle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetalle.Location = new System.Drawing.Point(10, 329);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvDetalle.Size = new System.Drawing.Size(851, 204);
            this.dgvDetalle.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvDetalle.TabIndex = 170;
            // 
            // sfComboBox2
            // 
            this.sfComboBox2.Location = new System.Drawing.Point(507, 264);
            this.sfComboBox2.Name = "sfComboBox2";
            this.sfComboBox2.Size = new System.Drawing.Size(181, 23);
            this.sfComboBox2.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sfComboBox2.TabIndex = 171;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 590);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.sfComboBox2);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtCodProducto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnBuscaCliente);
            this.Controls.Add(this.btnBuscaProducto);
            this.Controls.Add(this.gbPrint);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnBuscaFactura);
            this.Controls.Add(this.btnAnularVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNomProducto);
            this.Controls.Add(this.gbDisponible);
            this.Controls.Add(this.gbVlrUnitario);
            this.Controls.Add(this.gbTipoProd);
            this.Controls.Add(this.gbCantItem);
            this.Controls.Add(this.gbDcto);
            this.Controls.Add(this.gbSubTotal);
            this.Controls.Add(this.gbTotal);
            this.Controls.Add(this.gbStockMin);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscaProducto)).EndInit();
            this.gbPrint.ResumeLayout(false);
            this.gbPrint.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbNomProducto.ResumeLayout(false);
            this.gbNomProducto.PerformLayout();
            this.gbDisponible.ResumeLayout(false);
            this.gbDisponible.PerformLayout();
            this.gbVlrUnitario.ResumeLayout(false);
            this.gbVlrUnitario.PerformLayout();
            this.gbTipoProd.ResumeLayout(false);
            this.gbTipoProd.PerformLayout();
            this.gbCantItem.ResumeLayout(false);
            this.gbCantItem.PerformLayout();
            this.gbDcto.ResumeLayout(false);
            this.gbDcto.PerformLayout();
            this.gbSubTotal.ResumeLayout(false);
            this.gbSubTotal.PerformLayout();
            this.gbTotal.ResumeLayout(false);
            this.gbTotal.PerformLayout();
            this.gbStockMin.ResumeLayout(false);
            this.gbStockMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sfComboBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoad;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtObservaciones;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCodProducto;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtCliente;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscaCliente;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscaProducto;
        private System.Windows.Forms.GroupBox gbPrint;
        private System.Windows.Forms.RadioButton rbRemision;
        private System.Windows.Forms.RadioButton rbOficial;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox lblMsjDetalle;
        private System.Windows.Forms.RichTextBox lblMsj;
        private Syncfusion.WinForms.Input.SfNumericTextBox txtDescuento;
        protected internal Syncfusion.WinForms.Input.SfNumericTextBox txtCantidad;
        private Bunifu.Framework.UI.BunifuFlatButton btnReporte;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscaFactura;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnularVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.GroupBox gbNomProducto;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.GroupBox gbDisponible;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblDisponible;
        private System.Windows.Forms.GroupBox gbVlrUnitario;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblVlrUnitario;
        private System.Windows.Forms.GroupBox gbTipoProd;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.GroupBox gbCantItem;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblCantItem;
        private System.Windows.Forms.GroupBox gbDcto;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblDcto;
        private System.Windows.Forms.GroupBox gbSubTotal;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblSubTotal;
        private System.Windows.Forms.GroupBox gbTotal;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblTotal;
        private System.Windows.Forms.GroupBox gbStockMin;
        private Syncfusion.WinForms.Input.SfNumericTextBox lblStockMin;
        private Bunifu.Framework.UI.BunifuFlatButton btnVender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvDetalle;
        private Syncfusion.WinForms.ListView.SfComboBox sfComboBox2;
    }
}