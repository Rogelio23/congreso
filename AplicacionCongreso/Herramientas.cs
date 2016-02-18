using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Mail;
using System.IO;

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
    }
}
