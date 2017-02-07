using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JUDYSOFT
{
    class Validaciones
    {
        ToolTip toolTip1 = new ToolTip();
        public Boolean validarCadenasDeTexto(System.Windows.Forms.KeyPressEventArgs e, System.Windows.Forms.TextBox campoActual)
        {
            bool bandera = false;
            if (((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                
                toolTip1.Show("No se permiten numeros ni caracteres especiales", campoActual,1000);
                e.Handled = true;
            }
            else
            {
                bandera = true;
            }
                      
            return bandera;
        }
        public Boolean validarCamposNumericos(System.Windows.Forms.KeyPressEventArgs e, System.Windows.Forms.TextBox campoActual)
        {
            
            bool bandera = false;
            if (((char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
               
                toolTip1.Show("No se permiten letras ni caracteres especiales", campoActual,1000);
                e.Handled = true;
            } 
            else
            {
                bandera = true;
            }
                  
            return bandera;
        }
        public Boolean emailBienEscrito(String email)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
