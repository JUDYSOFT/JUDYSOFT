using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNuevoEmpleado.Visible = true;
            panelEliminarEmpleado.Visible = false;

        }
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNuevoEmpleado.Visible = true;
            panelEliminarEmpleado.Visible = false;
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNuevoEmpleado.Visible = false;
            panelEliminarEmpleado.Visible = true;
        }

        private void panelNuevoEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox3.SelectedItem.Equals("Cédula"))
            {
                panelCedula.Visible = true;
                panelApellidosNombres.Visible = false;
                panelCargo.Visible = false;
                panelMultiple.Visible = true;
                panelTablaCargo.Visible = false;
                panelSeleccion.Visible = false;
            }
            else if(comboBox3.SelectedItem.Equals("Apellidos y Nombres"))
            {
                panelCedula.Visible = false;
                panelApellidosNombres.Visible = true;
                panelCargo.Visible = false;
                panelMultiple.Visible = true;
                panelTablaCargo.Visible = false;
                panelSeleccion.Visible = false;
            }
            else
            {
                panelApellidosNombres.Visible = false;
                panelCedula.Visible = false;
                panelCargo.Visible = true;
                panelTablaCargo.Visible = true;
                panelMultiple.Visible = false;
                panelSeleccion.Visible = true;
            }
        }
    }
}
