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
        

    }
}
