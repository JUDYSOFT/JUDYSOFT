using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace Libreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd) {

            SqlConnection con = new SqlConnection("Data Source=LENOVO-PC\\SQLEXPRESS;Initial Catalog=Administracion;Integrated Security=True");
            con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd,con);
            da.Fill(DS);

            con.Close();

            return DS;
        }
    }
}
