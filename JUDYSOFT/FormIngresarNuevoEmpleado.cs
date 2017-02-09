using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JUDYSOFT
{
    public partial class FormIngresarNuevoEmpleado : Form
    {
        Validaciones validar = new Validaciones();
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
                comboBoxCiudad.Items.Add("Isabela");
                comboBoxCiudad.Items.Add("San Cristóbal");
                comboBoxCiudad.Items.Add("Santa Cruz");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Guayas"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Alfredo Baquerizo Moreno(Jujan)");
                comboBoxCiudad.Items.Add("Balao");
                comboBoxCiudad.Items.Add("Balzar");
                comboBoxCiudad.Items.Add("Colimes");
                comboBoxCiudad.Items.Add("Daule");
                comboBoxCiudad.Items.Add("Duran");
                comboBoxCiudad.Items.Add("El Triunfo");
                comboBoxCiudad.Items.Add("Empalme");
                comboBoxCiudad.Items.Add("General Antonio Elizalde (Bucay)");
                comboBoxCiudad.Items.Add("General Villamil(Playas)");
                comboBoxCiudad.Items.Add("Guayaquil");
                comboBoxCiudad.Items.Add("Isidro Ayora");
                comboBoxCiudad.Items.Add("Lomas De Sargentillo");
                comboBoxCiudad.Items.Add("Marcelino Mariduena");
                comboBoxCiudad.Items.Add("Milagro");
                comboBoxCiudad.Items.Add("Naranjal");
                comboBoxCiudad.Items.Add("Naranjito");
                comboBoxCiudad.Items.Add("Nobol(Narcisa De Jesus)");
                comboBoxCiudad.Items.Add("Palestina");
                comboBoxCiudad.Items.Add("Pedro Carbo");
                comboBoxCiudad.Items.Add("Samborondon");
                comboBoxCiudad.Items.Add("Santa Lucia");
                comboBoxCiudad.Items.Add("Simon Bolivar");
                comboBoxCiudad.Items.Add("Urbina Jado(Salitre)");
                comboBoxCiudad.Items.Add("Yaguachi");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Imbabura"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Antonio Ante");
                comboBoxCiudad.Items.Add("Cotacachi");
                comboBoxCiudad.Items.Add("Ibarra");
                comboBoxCiudad.Items.Add("Otavalo");
                comboBoxCiudad.Items.Add("Pimampiro");
                comboBoxCiudad.Items.Add("San Miguel De Urcuquí");

            }
            else if (comboBoxProvincia.SelectedItem.Equals("Loja"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Calvas");
                comboBoxCiudad.Items.Add("Catamayo");
                comboBoxCiudad.Items.Add("Celica");
                comboBoxCiudad.Items.Add("Chaguarpamba");
                comboBoxCiudad.Items.Add("Espíndola");
                comboBoxCiudad.Items.Add("Gonzanamá");
                comboBoxCiudad.Items.Add("Loja");
                comboBoxCiudad.Items.Add("Macará");
                comboBoxCiudad.Items.Add("Olmedo");
                comboBoxCiudad.Items.Add("Paltas");
                comboBoxCiudad.Items.Add("Pindal");
                comboBoxCiudad.Items.Add("Puyango");
                comboBoxCiudad.Items.Add("Quilanga");
                comboBoxCiudad.Items.Add("Saraguro");
                comboBoxCiudad.Items.Add("Sozoranga");
                comboBoxCiudad.Items.Add("Zapotillo");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Los Rios"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Baba");
                comboBoxCiudad.Items.Add("Babahoyo");
                comboBoxCiudad.Items.Add("Buena Fe");
                comboBoxCiudad.Items.Add("Mocache");
                comboBoxCiudad.Items.Add("Montalvo");
                comboBoxCiudad.Items.Add("Palenque");
                comboBoxCiudad.Items.Add("Pueblo Viejo");
                comboBoxCiudad.Items.Add("Quevedo");
                comboBoxCiudad.Items.Add("Urdaneta");
                comboBoxCiudad.Items.Add("Valencia");
                comboBoxCiudad.Items.Add("Ventanas");
                comboBoxCiudad.Items.Add("Vinces");
           

            }
            else if (comboBoxProvincia.SelectedItem.Equals("Manabí"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("24 De Mayo");
                comboBoxCiudad.Items.Add("Bolivar");
                comboBoxCiudad.Items.Add("Chone");
                comboBoxCiudad.Items.Add("El Carmen");
                comboBoxCiudad.Items.Add("Flavio Alfaro");
                comboBoxCiudad.Items.Add("Jama");
                comboBoxCiudad.Items.Add("Jaramijo");
                comboBoxCiudad.Items.Add("Jipijapa");
                comboBoxCiudad.Items.Add("Junin");
                comboBoxCiudad.Items.Add("Manta");
                comboBoxCiudad.Items.Add("Montecristi");
                comboBoxCiudad.Items.Add("Olmedo");
                comboBoxCiudad.Items.Add("Pajan");
                comboBoxCiudad.Items.Add("Pedernales");
                comboBoxCiudad.Items.Add("Pichincha");
                comboBoxCiudad.Items.Add("Portoviejo");
                comboBoxCiudad.Items.Add("Puerto Lopez");
                comboBoxCiudad.Items.Add("Rocafuerte");
                comboBoxCiudad.Items.Add("San Vicente");
                comboBoxCiudad.Items.Add("Santa Ana");
                comboBoxCiudad.Items.Add("Sucre");
                comboBoxCiudad.Items.Add("Tosagua");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Morona Santiago"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Gualaquiza");
                comboBoxCiudad.Items.Add("Huamboya");
                comboBoxCiudad.Items.Add("Limon - indanza");
                comboBoxCiudad.Items.Add("Logroño");
                comboBoxCiudad.Items.Add("Morona");
                comboBoxCiudad.Items.Add("Pablo VI");
                comboBoxCiudad.Items.Add("Palora");
                comboBoxCiudad.Items.Add("San Juan Bosco");
                comboBoxCiudad.Items.Add("Santiago");
                comboBoxCiudad.Items.Add("Sucua");
                comboBoxCiudad.Items.Add("Taisha");
                comboBoxCiudad.Items.Add("Twintza");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Napo"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Aguarico");
                comboBoxCiudad.Items.Add("Archidona");
                comboBoxCiudad.Items.Add("Carlos J.Arosemena");
                comboBoxCiudad.Items.Add("El Chaco");
                comboBoxCiudad.Items.Add("Quijos");
                comboBoxCiudad.Items.Add("Tena");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Orellana"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Aguarico");
                comboBoxCiudad.Items.Add("La Joya De Los Sachas");
                comboBoxCiudad.Items.Add("Loreto");
                comboBoxCiudad.Items.Add("Orellana");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Pastaza"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Arajuno");
                comboBoxCiudad.Items.Add("Mera");
                comboBoxCiudad.Items.Add("Pastaza");
                comboBoxCiudad.Items.Add("Santa Clara");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Pichincha"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Cayambe");
                comboBoxCiudad.Items.Add("Mejia");
                comboBoxCiudad.Items.Add("Pedro Moncayo");
                comboBoxCiudad.Items.Add("Pedro Vicente Maldonado");
                comboBoxCiudad.Items.Add("Puerto Quito");
                comboBoxCiudad.Items.Add("Quito");
                comboBoxCiudad.Items.Add("Rumiñahui");
                comboBoxCiudad.Items.Add("San Miguel De Los Bancos");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Santa Elena"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("La Libertad");
                comboBoxCiudad.Items.Add("Salinas");
                comboBoxCiudad.Items.Add("Santa Elena");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Santo Domingo de los Tsáchilas"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Santo Domingo De Los Tsáchilas");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Sucumbíos"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Cascales");
                comboBoxCiudad.Items.Add("Cuyabeno");
                comboBoxCiudad.Items.Add("Gonzalo Pizarro");
                comboBoxCiudad.Items.Add("Lago Agrio");
                comboBoxCiudad.Items.Add("Putumayo");
                comboBoxCiudad.Items.Add("Shushufindi");
                comboBoxCiudad.Items.Add("Sucumbios");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Tungurahua"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Ambato");
                comboBoxCiudad.Items.Add("Baños De Agua Santa");
                comboBoxCiudad.Items.Add("Cevallos");
                comboBoxCiudad.Items.Add("Mocha");
                comboBoxCiudad.Items.Add("Patate");
                comboBoxCiudad.Items.Add("Quero");
                comboBoxCiudad.Items.Add("San Pedro De Pelileo");
                comboBoxCiudad.Items.Add("Santiago De Pillaro");
                comboBoxCiudad.Items.Add("Tisaleo");
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Zamora Chinchipe"))
            {
                comboBoxCiudad.Items.Clear();
                comboBoxCiudad.Items.Add("Centinela Del Condor");
                comboBoxCiudad.Items.Add("Chinchipe");
                comboBoxCiudad.Items.Add("El Pangui");
                comboBoxCiudad.Items.Add("Nangaritza");
                comboBoxCiudad.Items.Add("Palanda");
                comboBoxCiudad.Items.Add("Yacuambi");
                comboBoxCiudad.Items.Add("Yantzaza");
                comboBoxCiudad.Items.Add("Zamora");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdentificacion_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxIdentificacion.Focused)
                if(validar.validarCamposNumericos(e,textBoxIdentificacion))
                    Console.Write("validar ident");
                     //validar 10 digitos        
        }

        private void textBoxNombres_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxNombres.Focused)
                if(validar.validarCadenasDeTexto(e, textBoxNombres))
                    Console.Write("validar nombres");
                    //validar nombres.
        }

        private void textBoxApellidos_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxApellidos.Focused)
                if (validar.validarCadenasDeTexto(e, textBoxApellidos))
                    Console.Write("validar apellidos");
                    //validar apellidos
            
        }

        private void textBoxDireccion_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxDireccion.Focused)
                validar.validarCadenasDeTexto(e, textBoxDireccion);
                // Validar que se puedan ingresar numeros
        }

        private void textBoxCorreoElectronico_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxCorreoElectronico.Focused)
                validar.emailBienEscrito(textBoxCorreoElectronico.Text);
        }
        
        private void textBoxTelefonoConvencional_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxTelefonoConvencional.Focused)
                validar.validarCamposNumericos(e, textBoxTelefonoConvencional);
        }

        private void textBoxCelular_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxCelular.Focused)
                validar.validarCamposNumericos(e, textBoxCelular);
        }

        private void textBoxSalario_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
           
        }


    }
}
