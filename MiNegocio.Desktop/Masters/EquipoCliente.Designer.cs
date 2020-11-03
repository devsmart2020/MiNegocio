namespace MiNegocio.Desktop.Masters
{
    partial class frmEquipoCliente
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
            this.dgvEquipos = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AccessibleName = "Table";
            this.dgvEquipos.AllowDeleting = true;
            this.dgvEquipos.AllowFiltering = true;
            this.dgvEquipos.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvEquipos.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvEquipos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEquipos.Location = new System.Drawing.Point(12, 81);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvEquipos.Size = new System.Drawing.Size(970, 353);
            this.dgvEquipos.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvEquipos.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label10.Location = new System.Drawing.Point(9, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(230, 17);
            this.label10.TabIndex = 194;
            this.label10.Text = "1.Información de Equipos por Cliente";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BeforeTouchSize = new System.Drawing.Size(227, 23);
            this.txtBuscar.BorderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBuscar.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Black;
            this.txtBuscar.Location = new System.Drawing.Point(12, 52);
            this.txtBuscar.MaxLength = 10;
            this.txtBuscar.Metrocolor = System.Drawing.Color.Silver;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.NearImage = global::MiNegocio.Desktop.Properties.Resources.Telefono;
            this.txtBuscar.Size = new System.Drawing.Size(227, 23);
            this.txtBuscar.TabIndex = 205;
            this.txtBuscar.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.ThemeStyle.CornerRadius = 0;
            this.txtBuscar.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtBuscar.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBuscar.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscar.UseBorderColorOnFocus = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label15.Location = new System.Drawing.Point(9, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 206;
            this.label15.Text = "Buscar";
            // 
            // frmEquipoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 446);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvEquipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEquipoCliente";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvEquipos;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtBuscar;
        private System.Windows.Forms.Label label15;
    }
}