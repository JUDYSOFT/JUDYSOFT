using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JUDYSOFT
{
    public partial class FormIngresarNuevoEmpleado : Form
    {
        public FormIngresarNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Ingresados Correctamente", "JUDYSOFT");
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea cancelar", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
            }
            else if (confirmacion == System.Windows.Forms.DialogResult.Cancel)
            {

            }
        }

        private void FormIngresarNuevoEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("toolStripMenuItem1", "nuevoToolStripMenuItem");
        }

        private void panelNuevoEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormIngresarNuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProvincia.SelectedItem.Equals("Azuay"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Camilo Ponce");
                comboBoxCiudad.Items.Add("Chordeleg");
                comboBoxCiudad.Items.Add("Cuenca");
                comboBoxCiudad.Items.Add("Girón");
                comboBoxCiudad.Items.Add("Guachapala");
                comboBoxCiudad.Items.Add("Gualaceo");
                comboBoxCiudad.Items.Add("Nabón");
                comboBoxCiudad.Items.Add("Oña");
                comboBoxCiudad.Items.Add("Paute");
                comboBoxCiudad.Items.Add("Pucará");
                comboBoxCiudad.Items.Add("San Fernando");
                comboBoxCiudad.Items.Add("Santa Isabel");
                comboBoxCiudad.Items.Add("Sevilla De Oro");
                comboBoxCiudad.Items.Add("Sigsig");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Bolivar"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Caluma");
                comboBoxCiudad.Items.Add("Chillanes");
                comboBoxCiudad.Items.Add("Chimbo");
                comboBoxCiudad.Items.Add("Echeandía");
                comboBoxCiudad.Items.Add("Guaranda");
                comboBoxCiudad.Items.Add("Las Naves");
                comboBoxCiudad.Items.Add("San Miguel");                
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Cañar"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Azogues");
                comboBoxCiudad.Items.Add("Biblián");
                comboBoxCiudad.Items.Add("Cañar");
                comboBoxCiudad.Items.Add("Deleg");
                comboBoxCiudad.Items.Add("La Troncal");
                comboBoxCiudad.Items.Add("Suscal");
                comboBoxCiudad.Items.Add("Tambo");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Carchi"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Bolívar");
                comboBoxCiudad.Items.Add("Espejo");
                comboBoxCiudad.Items.Add("Mira");
                comboBoxCiudad.Items.Add("Montúfar");
                comboBoxCiudad.Items.Add("San Pedro De Huaca");
                comboBoxCiudad.Items.Add("Tulcán");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Chimborazo"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Alausí");
                comboBoxCiudad.Items.Add("Chambo");
                comboBoxCiudad.Items.Add("Chunchi");
                comboBoxCiudad.Items.Add("Colta");
                comboBoxCiudad.Items.Add("Cumanda");
                comboBoxCiudad.Items.Add("Guamote");
                comboBoxCiudad.Items.Add("Guano");
                comboBoxCiudad.Items.Add("Pallatanga");
                comboBoxCiudad.Items.Add("Penipe");
                comboBoxCiudad.Items.Add("Riobamba");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Cotopaxi"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("La Maná");
                comboBoxCiudad.Items.Add("Latacunga");
                comboBoxCiudad.Items.Add("Pangua");
                comboBoxCiudad.Items.Add("Pujilí");
                comboBoxCiudad.Items.Add("Salcedo");
                comboBoxCiudad.Items.Add("Saquisilí");
                comboBoxCiudad.Items.Add("Sigchos");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("El Oro"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Arenillas");
                comboBoxCiudad.Items.Add("Atahualpa");
                comboBoxCiudad.Items.Add("Balsas");
                comboBoxCiudad.Items.Add("Chilla");
                comboBoxCiudad.Items.Add("El Guabo");
                comboBoxCiudad.Items.Add("Huaquillas");
                comboBoxCiudad.Items.Add("Las Lajas");
                comboBoxCiudad.Items.Add("Machala");
                comboBoxCiudad.Items.Add("Marcabelí");
                comboBoxCiudad.Items.Add("Pasaje");
                comboBoxCiudad.Items.Add("Piñas");
                comboBoxCiudad.Items.Add("Portovelo");
                comboBoxCiudad.Items.Add("Santa Rosa");
                comboBoxCiudad.Items.Add("Zaruma");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Esmeraldas"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Atacames");
                comboBoxCiudad.Items.Add("Eloy Alfaro");
                comboBoxCiudad.Items.Add("Esmeraldas");
                comboBoxCiudad.Items.Add("Muisne");
                comboBoxCiudad.Items.Add("Quininde");
                comboBoxCiudad.Items.Add("Rio Verde");
                comboBoxCiudad.Items.Add("San Lorenzo");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Galápagos"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("");


                /*
Guayas
Imbabura
Loja
Los Rios
Manabí
Morona Santiago
Napo
Orellana
Pastaza
Pichincha
Santa Elena
Santo Domingo de los Tsáchilas
Sucumbíos
Tungurahua
Zamora Chinchipe*/


            }
            else if (comboBoxProvincia.SelectedItem.Equals(""))
            {

            }
            else if (comboBoxProvincia.SelectedItem.Equals(""))
            {

            }
            else if (comboBoxProvincia.SelectedItem.Equals(""))
            {

            }
        }
    }
}
