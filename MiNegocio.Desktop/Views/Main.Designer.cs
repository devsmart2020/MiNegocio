namespace MiNegocio.Desktop.Views
{
    partial class frmMain
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
            this.pnlHead = new System.Windows.Forms.Panel();
            this.lblUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.Drag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCliente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOrden = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVenta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnServicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCredito = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAjuste = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.pnlHead.Controls.Add(this.lblUser);
            this.pnlHead.Controls.Add(this.pictureBox1);
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1080, 35);
            this.pnlHead.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.BeforeTouchSize = new System.Drawing.Size(238, 22);
            this.lblUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblUser.Enabled = false;
            this.lblUser.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(713, 6);
            this.lblUser.MaxLength = 20;
            this.lblUser.Metrocolor = System.Drawing.Color.Silver;
            this.lblUser.Name = "lblUser";
            this.lblUser.ReadOnly = true;
            this.lblUser.Size = new System.Drawing.Size(238, 22);
            this.lblUser.TabIndex = 17;
            this.lblUser.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.ThemeStyle.CornerRadius = 0;
            this.lblUser.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.ThemeStyle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.ThemeStyle.DisabledForeColor = System.Drawing.Color.White;
            this.lblUser.ThemeStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.lblUser.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ThemeStyle.ForeColor = System.Drawing.Color.White;
            this.lblUser.ThemeStyle.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MiNegocio.Desktop.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(683, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Image = global::MiNegocio.Desktop.Properties.Resources.Minimize;
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1012, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 20;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::MiNegocio.Desktop.Properties.Resources.Close;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1047, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 17;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 20;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.btnSesion);
            this.pnlMenu.Controls.Add(this.btnAjuste);
            this.pnlMenu.Controls.Add(this.btnCredito);
            this.pnlMenu.Controls.Add(this.btnServicio);
            this.pnlMenu.Controls.Add(this.btnInventario);
            this.pnlMenu.Controls.Add(this.btnVenta);
            this.pnlMenu.Controls.Add(this.btnOrden);
            this.pnlMenu.Controls.Add(this.btnCliente);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(170, 615);
            this.pnlMenu.TabIndex = 6;
            // 
            // Drag
            // 
            this.Drag.Fixed = true;
            this.Drag.Horizontal = true;
            this.Drag.TargetControl = this.pnlHead;
            this.Drag.Vertical = true;
            // 
            // btnSesion
            // 
            this.btnSesion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSesion.BorderRadius = 0;
            this.btnSesion.ButtonText = "   Cerrar sesión";
            this.btnSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSesion.DisabledColor = System.Drawing.Color.Gray;
            this.btnSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSesion.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Logout;
            this.btnSesion.Iconimage_right = null;
            this.btnSesion.Iconimage_right_Selected = null;
            this.btnSesion.Iconimage_Selected = null;
            this.btnSesion.IconMarginLeft = 25;
            this.btnSesion.IconMarginRight = 0;
            this.btnSesion.IconRightVisible = false;
            this.btnSesion.IconRightZoom = 0D;
            this.btnSesion.IconVisible = true;
            this.btnSesion.IconZoom = 40D;
            this.btnSesion.IsTab = true;
            this.btnSesion.Location = new System.Drawing.Point(0, 570);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnSesion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSesion.selected = false;
            this.btnSesion.Size = new System.Drawing.Size(170, 40);
            this.btnSesion.TabIndex = 14;
            this.btnSesion.Text = "   Cerrar sesión";
            this.btnSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSesion.Textcolor = System.Drawing.Color.White;
            this.btnSesion.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::MiNegocio.Desktop.Properties.Resources.MiNegocioTitle;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(170, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnCliente
            // 
            this.btnCliente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.BorderRadius = 0;
            this.btnCliente.ButtonText = "   Clientes";
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.DisabledColor = System.Drawing.Color.Gray;
            this.btnCliente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCliente.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Peoples;
            this.btnCliente.Iconimage_right = null;
            this.btnCliente.Iconimage_right_Selected = null;
            this.btnCliente.Iconimage_Selected = null;
            this.btnCliente.IconMarginLeft = 25;
            this.btnCliente.IconMarginRight = 0;
            this.btnCliente.IconRightVisible = false;
            this.btnCliente.IconRightZoom = 0D;
            this.btnCliente.IconVisible = true;
            this.btnCliente.IconZoom = 40D;
            this.btnCliente.IsTab = true;
            this.btnCliente.Location = new System.Drawing.Point(0, 107);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnCliente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnCliente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCliente.selected = false;
            this.btnCliente.Size = new System.Drawing.Size(170, 40);
            this.btnCliente.TabIndex = 13;
            this.btnCliente.Text = "   Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Textcolor = System.Drawing.Color.White;
            this.btnCliente.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnOrden
            // 
            this.btnOrden.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrden.BorderRadius = 0;
            this.btnOrden.ButtonText = "   Órdenes";
            this.btnOrden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrden.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrden.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrden.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Ordenes;
            this.btnOrden.Iconimage_right = null;
            this.btnOrden.Iconimage_right_Selected = null;
            this.btnOrden.Iconimage_Selected = null;
            this.btnOrden.IconMarginLeft = 25;
            this.btnOrden.IconMarginRight = 0;
            this.btnOrden.IconRightVisible = false;
            this.btnOrden.IconRightZoom = 0D;
            this.btnOrden.IconVisible = true;
            this.btnOrden.IconZoom = 40D;
            this.btnOrden.IsTab = true;
            this.btnOrden.Location = new System.Drawing.Point(0, 161);
            this.btnOrden.Name = "btnOrden";
            this.btnOrden.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnOrden.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnOrden.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrden.selected = false;
            this.btnOrden.Size = new System.Drawing.Size(170, 40);
            this.btnOrden.TabIndex = 14;
            this.btnOrden.Text = "   Órdenes";
            this.btnOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrden.Textcolor = System.Drawing.Color.White;
            this.btnOrden.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrden.Click += new System.EventHandler(this.btnOrden_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenta.BorderRadius = 0;
            this.btnVenta.ButtonText = "   Ventas";
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.DisabledColor = System.Drawing.Color.Gray;
            this.btnVenta.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVenta.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Vender;
            this.btnVenta.Iconimage_right = null;
            this.btnVenta.Iconimage_right_Selected = null;
            this.btnVenta.Iconimage_Selected = null;
            this.btnVenta.IconMarginLeft = 25;
            this.btnVenta.IconMarginRight = 0;
            this.btnVenta.IconRightVisible = false;
            this.btnVenta.IconRightZoom = 0D;
            this.btnVenta.IconVisible = true;
            this.btnVenta.IconZoom = 40D;
            this.btnVenta.IsTab = true;
            this.btnVenta.Location = new System.Drawing.Point(0, 215);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnVenta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnVenta.OnHoverTextColor = System.Drawing.Color.White;
            this.btnVenta.selected = false;
            this.btnVenta.Size = new System.Drawing.Size(170, 40);
            this.btnVenta.TabIndex = 14;
            this.btnVenta.Text = "   Ventas";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Textcolor = System.Drawing.Color.White;
            this.btnVenta.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventario.BorderRadius = 0;
            this.btnInventario.ButtonText = "   Inventario";
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventario.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventario.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Inventario;
            this.btnInventario.Iconimage_right = null;
            this.btnInventario.Iconimage_right_Selected = null;
            this.btnInventario.Iconimage_Selected = null;
            this.btnInventario.IconMarginLeft = 25;
            this.btnInventario.IconMarginRight = 0;
            this.btnInventario.IconRightVisible = false;
            this.btnInventario.IconRightZoom = 0D;
            this.btnInventario.IconVisible = true;
            this.btnInventario.IconZoom = 40D;
            this.btnInventario.IsTab = true;
            this.btnInventario.Location = new System.Drawing.Point(0, 269);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnInventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnInventario.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventario.selected = false;
            this.btnInventario.Size = new System.Drawing.Size(170, 40);
            this.btnInventario.TabIndex = 14;
            this.btnInventario.Text = "   Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Textcolor = System.Drawing.Color.White;
            this.btnInventario.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnServicio
            // 
            this.btnServicio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicio.BorderRadius = 0;
            this.btnServicio.ButtonText = "   Servicios";
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicio.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Devices;
            this.btnServicio.Iconimage_right = null;
            this.btnServicio.Iconimage_right_Selected = null;
            this.btnServicio.Iconimage_Selected = null;
            this.btnServicio.IconMarginLeft = 25;
            this.btnServicio.IconMarginRight = 0;
            this.btnServicio.IconRightVisible = false;
            this.btnServicio.IconRightZoom = 0D;
            this.btnServicio.IconVisible = true;
            this.btnServicio.IconZoom = 40D;
            this.btnServicio.IsTab = true;
            this.btnServicio.Location = new System.Drawing.Point(0, 323);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnServicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnServicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicio.selected = false;
            this.btnServicio.Size = new System.Drawing.Size(170, 40);
            this.btnServicio.TabIndex = 14;
            this.btnServicio.Text = "   Servicios";
            this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Textcolor = System.Drawing.Color.White;
            this.btnServicio.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // btnCredito
            // 
            this.btnCredito.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnCredito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnCredito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCredito.BorderRadius = 0;
            this.btnCredito.ButtonText = "   Créditos";
            this.btnCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCredito.DisabledColor = System.Drawing.Color.Gray;
            this.btnCredito.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCredito.Iconimage = global::MiNegocio.Desktop.Properties.Resources.CreditCard;
            this.btnCredito.Iconimage_right = null;
            this.btnCredito.Iconimage_right_Selected = null;
            this.btnCredito.Iconimage_Selected = null;
            this.btnCredito.IconMarginLeft = 25;
            this.btnCredito.IconMarginRight = 0;
            this.btnCredito.IconRightVisible = false;
            this.btnCredito.IconRightZoom = 0D;
            this.btnCredito.IconVisible = true;
            this.btnCredito.IconZoom = 40D;
            this.btnCredito.IsTab = true;
            this.btnCredito.Location = new System.Drawing.Point(0, 377);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnCredito.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnCredito.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCredito.selected = false;
            this.btnCredito.Size = new System.Drawing.Size(170, 40);
            this.btnCredito.TabIndex = 14;
            this.btnCredito.Text = "   Créditos";
            this.btnCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCredito.Textcolor = System.Drawing.Color.White;
            this.btnCredito.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCredito.Click += new System.EventHandler(this.btnCredito_Click);
            // 
            // btnAjuste
            // 
            this.btnAjuste.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.btnAjuste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnAjuste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAjuste.BorderRadius = 0;
            this.btnAjuste.ButtonText = "   Ajustes";
            this.btnAjuste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjuste.DisabledColor = System.Drawing.Color.Gray;
            this.btnAjuste.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAjuste.Iconimage = global::MiNegocio.Desktop.Properties.Resources.Ajustes;
            this.btnAjuste.Iconimage_right = null;
            this.btnAjuste.Iconimage_right_Selected = null;
            this.btnAjuste.Iconimage_Selected = null;
            this.btnAjuste.IconMarginLeft = 25;
            this.btnAjuste.IconMarginRight = 0;
            this.btnAjuste.IconRightVisible = false;
            this.btnAjuste.IconRightZoom = 0D;
            this.btnAjuste.IconVisible = true;
            this.btnAjuste.IconZoom = 40D;
            this.btnAjuste.IsTab = true;
            this.btnAjuste.Location = new System.Drawing.Point(0, 431);
            this.btnAjuste.Name = "btnAjuste";
            this.btnAjuste.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(32)))), ((int)(((byte)(80)))));
            this.btnAjuste.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.btnAjuste.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAjuste.selected = false;
            this.btnAjuste.Size = new System.Drawing.Size(170, 40);
            this.btnAjuste.TabIndex = 14;
            this.btnAjuste.Text = "   Ajustes";
            this.btnAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuste.Textcolor = System.Drawing.Color.White;
            this.btnAjuste.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjuste.Click += new System.EventHandler(this.btnAjuste_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 650);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt lblUser;
        private Bunifu.Framework.UI.BunifuDragControl Drag;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSesion;
        private Bunifu.Framework.UI.BunifuFlatButton btnAjuste;
        private Bunifu.Framework.UI.BunifuFlatButton btnCredito;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventario;
        private Bunifu.Framework.UI.BunifuFlatButton btnVenta;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrden;
        private Bunifu.Framework.UI.BunifuFlatButton btnCliente;
    }
}