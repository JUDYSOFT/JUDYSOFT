using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Libreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd) {

            //Lista de conexiones a la base de datos------------------------------------------------------------------------------------
           

            SqlConnection con = new SqlConnection("Data Source='"+Environment.MachineName+"\\SQLEXPRESS';Initial Catalog=JUDYSOFT;Integrated Security=True");
            
            con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd,con);
            da.Fill(DS);

            con.Close();

            return DS;
        }

        public static Boolean ValidarFormulario(Control Objeto, ErrorProvider ErrorProvider)
        {
            Boolean band = false;

            foreach(Control Item in Objeto.Controls)
            {
                if (Item is ErrorTxtBox)
                {
                    ErrorTxtBox obj = (ErrorTxtBox)Item;
                    if(obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar vacío");
                            band = true;
                        }else
                        {
                            ErrorProvider.SetError(obj,"");
                        
                        }
                    }
                }
            }
        
            return band;
        } 
    }
}
