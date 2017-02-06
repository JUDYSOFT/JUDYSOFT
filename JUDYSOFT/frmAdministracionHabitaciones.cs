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

    public partial class frmAdministracionHabitaciones : Form
    {
        public event FormClosingEventHandler FormAdministracionHabitaciones;

        public frmAdministracionHabitaciones()
        {

            DateTime thisDay = DateTime.Today;
            InitializeComponent();
            btnh15.Text = "Habitacion 15 Matrimonial";
            btnh15.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh16.Text = "Habitacion 16 Matrimonial";
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh17.Text = "Habitacion 17 Matrimonial";
            btnh17.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh18.Text = "Habitacion 18 Matrimonial";
            btnh18.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh19.Text = "Habitacion 19 Doble";
            btnh19.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh20.Text = "Habitacion 20 Triple";
            btnh20.TextImageRelation = TextImageRelation.TextAboveImage;

            //Segundo Piso

            btnh21.Text = "Habitacion 21 Matrimonial";
            btnh21.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh22.Text = "Habitacion 22 Matrimonial";
            btnh22.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh23.Text = "Habitacion 23 Matrimonial";
            btnh23.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh24.Text = "Habitacion 24 Matrimonial";
            btnh24.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh25.Text = "Habitacion 25 Matrimonial";
            btnh25.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh26.Text = "Habitacion 26 Doble";
            btnh26.TextImageRelation = TextImageRelation.TextAboveImage;

            btnh27.Text = "Habitacion 27 Triple";
            btnh27.TextImageRelation = TextImageRelation.TextAboveImage;

        }

        /*private void groupBox1_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = sender.GetType().ToString() + ": MouseHover";
        }*/

        private void frmAdministracionHabitaciones_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            lblfecha.Text = (thisDay.ToString("D"));
            clsHabitacion clshab = new clsHabitacion();
            clshab.Estado = null;


            btnh15.Cursor = Cursors.Hand;
            lblh15.Text = "Disponible";
            lblh15.BackColor = Color.Silver;

            btnh16.Cursor = Cursors.Hand;
            lblh16.Text = "Disponible";
            lblh16.BackColor = Color.Silver;


            btnh17.Cursor = Cursors.Hand;
            lblh17.Text = "Disponible";
            lblh17.BackColor = Color.Silver;

            btnh17.Cursor = Cursors.Hand;
            lblh17.Text = "Disponible";
            lblh17.BackColor = Color.Silver;

            btnh18.Cursor = Cursors.Hand;
            lblh18.Text = "Disponible";
            lblh18.BackColor = Color.Silver;

            btnh19.Cursor = Cursors.Hand;
            lblh19.Text = "Disponible";
            lblh19.BackColor = Color.Silver;

            btnh20.Cursor = Cursors.Hand;
            lblh20.Text = "Disponible";
            lblh20.BackColor = Color.Silver;

            btnh21.Cursor = Cursors.Hand;
            lblh21.Text = "Disponible";
            lblh21.BackColor = Color.Silver;

            btnh22.Cursor = Cursors.Hand;
            lblh22.Text = "Disponible";
            lblh22.BackColor = Color.Silver;

            btnh23.Cursor = Cursors.Hand;
            lblh23.Text = "Disponible";
            lblh23.BackColor = Color.Silver;

            btnh24.Cursor = Cursors.Hand;
            lblh24.Text = "Disponible";
            lblh24.BackColor = Color.Silver;

            btnh25.Cursor = Cursors.Hand;
            lblh25.Text = "Disponible";
            lblh25.BackColor = Color.Silver;

            btnh26.Cursor = Cursors.Hand;
            lblh26.Text = "Disponible";
            lblh26.BackColor = Color.Silver;

            btnh27.Cursor = Cursors.Hand;
            lblh27.Text = "Disponible";
            lblh27.BackColor = Color.Silver;

            try
            {
                btnh15.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh16.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh17.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh18.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh19.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh20.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh21.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh22.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh23.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh24.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh25.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh26.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btnh27.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnh17_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh18_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh26_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh25_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnh24_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh19_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh20_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh21_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh22_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh23_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void btnh27_Click(object sender, EventArgs e)
        {
            frmOpcionHab frmOpcion = new frmOpcionHab();
            frmOpcion.Show();
        }

        private void frmAdministracionHabitaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea salir", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("habitacionesToolStripMenuItem", "consultarToolStripMenuItem");
            }
        }
            
        }

        /*      private void btnh20_Click_1(object sender, EventArgs e)
              {

              }
              */


        /*private void button2_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = "BTN 2";
            btnh16.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            // The text is displayed vertically above the image of a control.
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;
  
        }

        private void button2_MouseLeave(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = "BTN 2";
            try
            {
                btnh16.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\o.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
           
            // The text is displayed vertically above the image of a control.
            btnh16.TextImageRelation = TextImageRelation.TextAboveImage;

        }*/
}

