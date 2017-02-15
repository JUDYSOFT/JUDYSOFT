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
    public partial class FormEliminarEmpleado : Form
    {
        public FormEliminarEmpleado()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBox3.SelectedItem.Equals("Cédula"))
            {
                panelInsertarId.Visible = true;
                panelCedula.Visible = true;
                panelApellidosNombres.Visible = false;
                panelCargo.Visible = false;
                panelMultiple.Visible = true;
                panelTablaCargo.Visible = false;
                groupBoxSeleccion.Visible = false;
                panelMarcoTabla.Visible = true;
               
          
            }
            else if (comboBox3.SelectedItem.Equals("Apellidos y Nombres"))
            {
                panelInsertarId.Visible = true;
                panelCedula.Visible = false;
                panelApellidosNombres.Visible = true;
                panelCargo.Visible = false;
                panelMultiple.Visible = true;
                panelTablaCargo.Visible = false;
                groupBoxSeleccion.Visible = false;
                panelMarcoTabla.Visible = true;
               
            }
            else
            {
                panelInsertarId.Visible = true;
                panelApellidosNombres.Visible = false;
                panelCedula.Visible = false;
                panelCargo.Visible = true;
                panelTablaCargo.Visible = true;
                panelMultiple.Visible = false;
                groupBoxSeleccion.Visible = true;
                panelMarcoDatosSeleccionados.Visible = true;
                panelMarcoTabla.Visible = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Eliminados Correctamente", "JUDYSOFT");
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

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Eliminados Correctamente", "JUDYSOFT");
            this.Close();
        }

        private void FormEliminarEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSettings.EnableMenuItem("toolStripMenuItem1", "eliminarToolStripMenuItem");
        }

        private void panelEliminarEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBox1.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
        }

        private void textBox7_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                textBox7.BackColor = Color.LightCoral;
                e.Handled = true;
                return;
            }
            else
            {
                textBox7.BackColor = Color.White;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}