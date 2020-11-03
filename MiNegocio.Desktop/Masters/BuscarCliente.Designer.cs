namespace MiNegocio.Desktop.Masters
{
    partial class frmBuscarCliente
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
            this.txtBusca = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCliente = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.BackColor = System.Drawing.Color.White;
            this.txtBusca.BeforeTouchSize = new System.Drawing.Size(204, 23);
            this.txtBusca.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusca.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusca.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBusca.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtBusca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusca.ForeColor = System.Drawing.Color.Black;
            this.txtBusca.Location = new System.Drawing.Point(15, 25);
            this.txtBusca.MaxLength = 10;
            this.txtBusca.Metrocolor = System.Drawing.Color.Silver;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.NearImage = global::MiNegocio.Desktop.Properties.Resources.UserIcon;
            this.txtBusca.Size = new System.Drawing.Size(204, 23);
            this.txtBusca.TabIndex = 153;
            this.txtBusca.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtBusca.ThemeStyle.CornerRadius = 0;
            this.txtBusca.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtBusca.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtBusca.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusca.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBusca.UseBorderColorOnFocus = true;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 154;
            this.label4.Text = "Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AccessibleName = "Table";
            this.dgvCliente.AllowDeleting = true;
            this.dgvCliente.AllowFiltering = true;
            this.dgvCliente.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvCliente.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvCliente.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCliente.Location = new System.Drawing.Point(14, 54);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvCliente.Size = new System.Drawing.Size(948, 419);
            this.dgvCliente.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvCliente.TabIndex = 155;
            this.dgvCliente.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvCliente_CellDoubleClick);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.Image = global::MiNegocio.Desktop.Properties.Resources._128x128;
            this.pbLoading.Location = new System.Drawing.Point(419, 193);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(136, 99);
            this.pbLoading.TabIndex = 175;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // frmBuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(974, 485);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarCliente";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda de Clientes";
            this.Shown += new System.EventHandler(this.frmBuscarCliente_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBusca;
        private System.Windows.Forms.Label label4;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvCliente;
        private System.Windows.Forms.PictureBox pbLoading;
    }
}