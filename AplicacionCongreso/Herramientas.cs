using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.IO;
using System.Drawing.Imaging;
using AplicacionCongreso.Properties;
    

using System.Drawing.Printing;

namespace AplicacionCongreso
{
    public class Herramientas
    {
        /// <summary>
        /// Evento para validar la introduccion de caracteres de tipo numero y punto dentro de una caja de texto.
        /// </summary>
        /// <param name="e">Objeto de argumentos del evento de presionado de tecla.</param>
        /// <param name="sender">MaskedTextBox que se desea validar.</param>
        public static void keyPressNumeros(KeyPressEventArgs e, object sender)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public static string dgvValorString(DataGridView dgv, int row, int cell)
        {
            DataGridViewRow filaseleccionada = dgv.SelectedRows[row];
            string valor = (string)filaseleccionada.Cells[cell].Value;
            return valor;
        }
        public static int dgvValorInt(DataGridView dgv, int row, int cell)
        {
            DataGridViewRow filaseleccionada = dgv.SelectedRows[row];
            int valor = (int)filaseleccionada.Cells[cell].Value;
            return valor;
        }

        /// <summary>
        /// Herramienta que sirve para realizar los codigos de barra
        /// </summary>
        /// <param name="codigoRecibido"></param>
        public static void ImprimirCodigo (int codigoRecibido, PictureBox pbResultado)
        {
            string codigoBarras = codigoRecibido.ToString();
            //string codigoBarras = tbCodigo.Text;
            Bitmap codigo = new Bitmap(codigoBarras.Length * 60, 150); //Esta parte de aqui controla lo que se muestra en el picture box
            using (Graphics graficos = Graphics.FromImage(codigo))
            {
                Font oFont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 23);

                PointF punto = new PointF(2f, 2f);
                SolidBrush negro = new SolidBrush(Color.Black);
                SolidBrush blanco = new SolidBrush(Color.White);
                graficos.FillRectangle(blanco, 0, 0, codigo.Width, codigo.Height);
                graficos.DrawString("*" + codigoBarras + "*", oFont, negro, punto);
            }
            using (MemoryStream ms = new MemoryStream())
            {
                codigo.Save(ms, ImageFormat.Png);
                pbResultado.Image = codigo;
                pbResultado.Height = codigo.Height;
                pbResultado.Width = codigo.Width;
            }
        }
        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView
        /// </summary>
        /// <param name="grd">DataGridView que contiene los datos a exportar</param>
        public static void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo
                for (int i = 0; i < grd.Rows.Count; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 1, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }

    }
}
