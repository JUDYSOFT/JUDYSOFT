using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Data;

namespace JUDYSOFT
{
    class Validaciones
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Validaciones()
        {
            try
            {

                con = new SqlConnection("Data Source=BRYANGERMANPC;Initial Catalog=JUDYSOFT;Integrated Security=True");

            }
            catch (Exception ex)
            {
                MessageBox.Show("No conectado");
            }
        }

        ToolTip toolTip1 = new ToolTip();
        public Boolean validarCadenasDeTexto(System.Windows.Forms.KeyPressEventArgs e, System.Windows.Forms.TextBox campoActual)
        {
            bool bandera = false;
            if (((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                campoActual.BackColor = Color.LightCoral;
                toolTip1.Show("No se permiten números ni caracteres especiales", campoActual, 1000);
                e.Handled = true;
            }
            else
            {
                campoActual.BackColor = Color.LightGreen;
                bandera = true;

            }

            return bandera;
        }
        public Boolean validarCamposNumericos(System.Windows.Forms.KeyPressEventArgs e, System.Windows.Forms.TextBox campoActual)
        {

            bool bandera = false;
            if (((char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                campoActual.BackColor = Color.LightCoral;
                toolTip1.Show("No se permiten letras ni caracteres especiales", campoActual, 1000);
                e.Handled = true;
            }
            else
            {
                campoActual.BackColor = Color.LightGreen;
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
        public Boolean decimales(String email)
        {
            String sFormato;
            sFormato = "\\d+(\\.\\d+)?$";
            if (Regex.IsMatch(email, sFormato))
            {

               // MessageBox.Show("ENTRE!");
                return true;

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

        public bool validarExistencia(String tabla, TextBox identificacion)
        {
            bool bandera = false;
            identificacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            identificacion.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            try
            {
                con.Open();
                cmd = new SqlCommand("select NUMERODOCUMENTOEMPLEADO from " + tabla, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String busqueda = dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                    //col.Add(busqueda);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede autocompletar el textBox");
            }
            //identificacion.AutoCompleteCustomSource = col;
            dr.Close();
            con.Close();
            return bandera;
        }


        public Boolean verificarCedula(string cedula)
        {
            char[] vector = cedula.ToCharArray();
            if (vector.Length == 10)
            {
                int sumatotal = 0;
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
                if (sumatotal == 10 || sumatotal == Convert.ToInt32(vector[9].ToString()))
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
