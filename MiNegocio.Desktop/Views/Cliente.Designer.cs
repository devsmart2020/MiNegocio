namespace MiNegocio.Desktop.Views
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtNombre = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelAlterno = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCliente = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbLoad = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.errorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.dpFcha = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnGuardar = new Syncfusion.WinForms.Controls.SfButton();
            this.btnActualizar = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelAlterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(28, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "1.Información Personal";
            // 
            // txtDocId
            // 
            this.txtDocId.BackColor = System.Drawing.Color.White;
            this.txtDocId.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtDocId.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocId.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDocId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDocId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDocId.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtDocId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDocId.ForeColor = System.Drawing.Color.Black;
            this.txtDocId.Location = new System.Drawing.Point(31, 53);
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
            this.txtDocId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocId_KeyUp);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblUser.Location = new System.Drawing.Point(28, 37);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(67, 13);
            this.lblUser.TabIndex = 25;
            this.lblUser.Text = "Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombre.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtNombre.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(278, 53);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(275, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombres";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtApellido.BorderColor = System.Drawing.Color.DimGray;
            this.txtApellido.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtApellido.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(525, 53);
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
            this.label2.Location = new System.Drawing.Point(522, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Apellidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(28, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 17);
            this.label8.TabIndex = 30;
            this.label8.Text = "2.Información de Contacto";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            this.txtTelefono.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtTelefono.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefono.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTelefono.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(31, 148);
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
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(28, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Teléfono";
            // 
            // txtTelAlterno
            // 
            this.txtTelAlterno.BackColor = System.Drawing.Color.White;
            this.txtTelAlterno.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtTelAlterno.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelAlterno.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtTelAlterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelAlterno.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtTelAlterno.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtTelAlterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelAlterno.ForeColor = System.Drawing.Color.Black;
            this.txtTelAlterno.Location = new System.Drawing.Point(278, 148);
            this.txtTelAlterno.MaxLength = 12;
            this.txtTelAlterno.Metrocolor = System.Drawing.Color.Silver;
            this.txtTelAlterno.Name = "txtTelAlterno";
            this.txtTelAlterno.NearImage = global::MiNegocio.Desktop.Properties.Resources.Telefono;
            this.txtTelAlterno.Size = new System.Drawing.Size(200, 23);
            this.txtTelAlterno.TabIndex = 4;
            this.txtTelAlterno.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtTelAlterno.ThemeStyle.CornerRadius = 0;
            this.txtTelAlterno.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtTelAlterno.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtTelAlterno.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelAlterno.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelAlterno.UseBorderColorOnFocus = true;
            this.txtTelAlterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelAlterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label5.Location = new System.Drawing.Point(275, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Teléfono Alterno";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtEmail.BorderColor = System.Drawing.Color.DimGray;
            this.txtEmail.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEmail.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(525, 148);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Metrocolor = System.Drawing.Color.Silver;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.NearImage = global::MiNegocio.Desktop.Properties.Resources.Email;
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.ThemeStyle.CornerRadius = 0;
            this.txtEmail.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtEmail.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtEmail.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.UseBorderColorOnFocus = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label6.Location = new System.Drawing.Point(522, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            this.txtDireccion.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtDireccion.BorderColor = System.Drawing.Color.DimGray;
            this.txtDireccion.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDireccion.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(31, 204);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Metrocolor = System.Drawing.Color.Silver;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.NearImage = global::MiNegocio.Desktop.Properties.Resources.Gps;
            this.txtDireccion.Size = new System.Drawing.Size(447, 23);
            this.txtDireccion.TabIndex = 6;
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
            this.label3.Location = new System.Drawing.Point(28, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Dirección";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(28, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "3.Detalle de Clientes";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BeforeTouchSize = new System.Drawing.Size(200, 23);
            this.txtBuscar.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBuscar.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(31, 290);
            this.txtBuscar.MaxLength = 40;
            this.txtBuscar.Metrocolor = System.Drawing.Color.Silver;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.NearImage = global::MiNegocio.Desktop.Properties.Resources.BuscaPersona;
            this.txtBuscar.Size = new System.Drawing.Size(200, 23);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.ThemeStyle.CornerRadius = 0;
            this.txtBuscar.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.UseBorderColorOnFocus = true;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label9.Location = new System.Drawing.Point(28, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Buscar";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AccessibleName = "Table";
            this.dgvCliente.AllowDeleting = true;
            this.dgvCliente.AllowFiltering = true;
            this.dgvCliente.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvCliente.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCliente.Location = new System.Drawing.Point(12, 319);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvCliente.Size = new System.Drawing.Size(866, 264);
            this.dgvCliente.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvCliente.TabIndex = 12;
            this.dgvCliente.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::MiNegocio.Desktop.Properties.Resources._128x128;
            this.pbLoading.Location = new System.Drawing.Point(377, 374);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(136, 99);
            this.pbLoading.TabIndex = 125;
            this.pbLoading.TabStop = false;
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
            this.pbLoad.Location = new System.Drawing.Point(752, 192);
            this.pbLoad.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(179)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))))};
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.pbLoad.SegmentWidth = 12;
            this.pbLoad.Size = new System.Drawing.Size(126, 6);
            this.pbLoad.TabIndex = 130;
            this.pbLoad.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.pbLoad.ThemeName = "WaitingGradient";
            this.pbLoad.ThemeStyle.BorderThickness = 0;
            this.pbLoad.WaitingGradientEnabled = true;
            this.pbLoad.WaitingGradientInterval = 70;
            this.pbLoad.WaitingGradientWidth = 100;
            // 
            // errorCliente
            // 
            this.errorCliente.ContainerControl = this;
            this.errorCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("errorCliente.Icon")));
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label13.Location = new System.Drawing.Point(522, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 172;
            this.label13.Text = "Cumpleaños";
            // 
            // dpFcha
            // 
            this.dpFcha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dpFcha.DateTimePattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.LongDate;
            this.dpFcha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dpFcha.Location = new System.Drawing.Point(525, 204);
            this.dpFcha.Name = "dpFcha";
            this.dpFcha.Size = new System.Drawing.Size(200, 23);
            this.dpFcha.Style.BackColor = System.Drawing.Color.White;
            this.dpFcha.Style.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.FocusedBorderColor = System.Drawing.Color.OrangeRed;
            this.dpFcha.Style.ForeColor = System.Drawing.Color.Black;
            this.dpFcha.Style.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.UpDownBackColor = System.Drawing.Color.White;
            this.dpFcha.Style.UpDownForeColor = System.Drawing.Color.WhiteSmoke;
            this.dpFcha.Style.UpDownHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.dpFcha.Style.UpDownHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.dpFcha.TabIndex = 7;
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
            this.btnGuardar.Location = new System.Drawing.Point(752, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 35);
            this.btnGuardar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnGuardar.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnGuardar.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnGuardar.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnGuardar.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Guardar;
            this.btnGuardar.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnGuardar.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnActualizar.Location = new System.Drawing.Point(752, 153);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(126, 35);
            this.btnActualizar.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(47)))), ((int)(((byte)(73)))));
            this.btnActualizar.Style.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnActualizar.Style.DisabledForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.btnActualizar.Style.FocusedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.btnActualizar.Style.HoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Style.Image = global::MiNegocio.Desktop.Properties.Resources.Actualizar;
            this.btnActualizar.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.btnActualizar.Style.PressedForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 590);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dpFcha);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelAlterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocId);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Shown += new System.EventHandler(this.frmCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtDocId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelAlterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDocId;
        private System.Windows.Forms.Label lblUser;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtNombre;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTelefono;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTelAlterno;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private System.Windows.Forms.Label label6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBuscar;
        private System.Windows.Forms.Label label9;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvCliente;
        private System.Windows.Forms.PictureBox pbLoading;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv pbLoad;
        private System.Windows.Forms.ErrorProvider errorCliente;
        private System.Windows.Forms.Label label13;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dpFcha;
        private Syncfusion.WinForms.Controls.SfButton btnGuardar;
        private Syncfusion.WinForms.Controls.SfButton btnActualizar;
    }
}