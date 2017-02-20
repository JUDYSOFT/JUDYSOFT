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
    public partial class FormReservas : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource1 = new BindingSource();
        public FormReservas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reservacionesPasadas nueva = new reservacionesPasadas();
            nueva.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está seguro que desea cancelar la reserva?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FormNuevaReservacion nueva = new FormNuevaReservacion();
            nueva.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            tablaReservaciones.DataSource = bindingSource1;
            GetData("SELECT R.CODRESERVACION,C.NOMBRE1CLIENTE,C.APELLIDO1CLIENTE,R.FECHAINGRESORESERVACION,R.FECHASALIDARESERVACION FROM  CLIENTE C JOIN RESERVACION R ON R.CODCLIENTE=C.CODCLIENTE");
        }
            
        private void FormReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea salir", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                Dispose();
                MenuSettings.EnableMenuItem("habitacionesToolStripMenuItem", "reservacionesToolStripMenuItem");
            }
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
                tablaReservaciones.AutoResizeColumns(
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
