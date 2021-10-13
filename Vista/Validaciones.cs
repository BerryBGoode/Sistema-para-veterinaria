using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public class Validaciones
    {               
        public static void Clave(KeyPressEventArgs a)
        {
            if (char.IsPunctuation(a.KeyChar) || char.IsSeparator(a.KeyChar) || char.IsSymbol(a.KeyChar))
            {
                a.Handled = true;
            }
            else if (a.KeyChar == ' ')
            {
                a.Handled = true;
            }           
            else
            {
                a.Handled = false;
            }
        }
        public static void NombreUsuario(KeyPressEventArgs a)
        {
            if (char.IsLetter(a.KeyChar) || char.IsNumber(a.KeyChar) || char.IsLowSurrogate(a.KeyChar) || char.IsControl(a.KeyChar))
            {
                a.Handled = false;
            }
            else
            {
                a.Handled = true;
            }
        }
        public static void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void SoloDecimales(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
