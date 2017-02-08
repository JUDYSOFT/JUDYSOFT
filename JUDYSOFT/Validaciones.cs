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
                
                toolTip1.Show("No se permiten números ni caracteres especiales", campoActual,1000);
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
        public Boolean validartelefono(string telefono)
        {
            string expresion = "^[+-]?\\d+(\\.\\d+)?$";
            if (Regex.IsMatch(telefono, expresion))
            {
                if (Regex.Replace(telefono, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }
        public void verificarCedula(string cedula,System.Windows.Forms.TextBox txtDocumento)
        {
            char[] vector = cedula.ToCharArray();
            int sumatotal = 0;
            if (vector.Length == 10)
            {
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    int numero = Convert.ToInt32(vector[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        numero = Convert.ToInt32(vector[i].ToString()) * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                if (sumatotal == Convert.ToInt32(vector[9].ToString()))
                {
                    toolTip1.Show("la cédula es correcta",txtDocumento,1000);
                }
                else
                {
                    toolTip1.Show("la cédula es incorrecta", txtDocumento, 1000);
                }
            }
            else //if(txtDocumento.Text==""||Convert.ToInt32 (txtDocumento.Text.Length)!=10)
            {
                toolTip1.Show("el número de cedula ingresado no contiene 10 dígitos", txtDocumento, 1000);

            }
        }



    }
}
