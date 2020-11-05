namespace MiNegocio.Desktop.Masters
{
    partial class frmBuscarOrden
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
            this.txtSearch = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvOrden = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BeforeTouchSize = new System.Drawing.Size(222, 23);
            this.txtSearch.BorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.BorderSides = System.Windows.Forms.Border3DSide.Bottom;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtSearch.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(70)))), ((int)(((byte)(0)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(15, 25);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Metrocolor = System.Drawing.Color.Silver;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NearImage = global::MiNegocio.Desktop.Properties.Resources.buscarBlackGrande;
            this.txtSearch.Size = new System.Drawing.Size(222, 23);
            this.txtSearch.TabIndex = 154;
            this.txtSearch.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.ThemeStyle.CornerRadius = 0;
            this.txtSearch.ThemeStyle.DisabledBackColor = System.Drawing.Color.Transparent;
            this.txtSearch.ThemeStyle.DisabledBorderColor = System.Drawing.Color.DimGray;
            this.txtSearch.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.ThemeStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.UseBorderColorOnFocus = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label24.Location = new System.Drawing.Point(12, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 155;
            this.label24.Text = "Buscar";
            // 
            // dgvOrden
            // 
            this.dgvOrden.AccessibleName = "Table";
            this.dgvOrden.AllowDeleting = true;
            this.dgvOrden.AllowFiltering = true;
            this.dgvOrden.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.dgvOrden.FilterRowPosition = Syncfusion.WinForms.DataGrid.Enums.RowPosition.FixedTop;
            this.dgvOrden.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrden.Location = new System.Drawing.Point(12, 54);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.NavigationMode = Syncfusion.WinForms.DataGrid.Enums.NavigationMode.Row;
            this.dgvOrden.Size = new System.Drawing.Size(940, 406);
            this.dgvOrden.Style.BorderColor = System.Drawing.Color.DarkGray;
            this.dgvOrden.TabIndex = 156;
            this.dgvOrden.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.dgvOrden_CellDoubleClick);
            // 
            // frmBuscarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 472);
            this.Controls.Add(this.dgvOrden);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label24);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBuscarOrden";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órdenes";
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtSearch;
        private System.Windows.Forms.Label label24;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvOrden;
    }
}