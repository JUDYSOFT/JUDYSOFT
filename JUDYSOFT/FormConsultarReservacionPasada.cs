using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUDYSOFT
{
    public partial class reservacionesPasadas : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();

        public reservacionesPasadas()
        {
            InitializeComponent();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void reservacionesPasadas_Load(object sender, EventArgs e)
        {
            tablaReservacionesPasadas.DataSource = bindingSource1;
            GetData("SELECT R.CODRESERVACION,C.NOMBRE1CLIENTE,C.APELLIDO1CLIENTE,R.FECHAINGRESORESERVACION,R.FECHASALIDARESERVACION FROM  CLIENTE C JOIN RESERVACION R ON R.CODCLIENTE = C.CODCLIENTEWHERE R.FECHASALIDARESERVACION < GETDATE()");
        }

        private void tablaReservacionesPasadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString =
                    "Data Source=DESKTOP-P6D1EH2\\SQLEXPRESS;Initial Catalog=JUDYSOFT;Integrated Security=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                tablaReservacionesPasadas.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }
    }

}