using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGridConverter;
using Syncfusion.XlsIO;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Helpers
{
    internal static class DataHelper
    {
        internal static void Textbox_KeyPress(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        internal static async Task ExportExcel(SfDataGrid sfDataGrid)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2016;
            var excelEngine = sfDataGrid.ExportToExcel(sfDataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.Worksheets[0].AutoFilters.FilterRange = workBook.Worksheets[0].UsedRange;

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 2013 File(*.xlsx) | *.xlsx | Excel 2016 File(*.xlsx) | *.xlsx | Excel 2019 File(*.Xlsx) | *.Xlsx "
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    if (saveFileDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel2013;
                    else if (saveFileDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2016;
                    else
                        workBook.Version = ExcelVersion.Xlsx;
                    workBook.SaveAs(stream);
                }

                //Message box confirmation to view the created workbook.
                if (MessageBox.Show(sfDataGrid, "Desea abrir el documento generado?", "Documento Generado con Éxito",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
            }
            await Task.Delay(1);
        }

        internal static async Task ExportPDF(SfDataGrid sfDataGrid)
        {
            PdfExportingOptions options = new PdfExportingOptions();
            options.FitAllColumnsInOnePage = true;
            var document = sfDataGrid.ExportToPdf();
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files(*.pdf)|*.pdf"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    document.Save(stream);
                }
                //Message box confirmation to view the created Pdf file.
                if (MessageBox.Show("Desea abrir el Pdf generado?", "Pdf Generado con Éxito", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //Launching the Pdf file using the default Application.
                    System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                await Task.Delay(1);
            }
        }

    }
}
