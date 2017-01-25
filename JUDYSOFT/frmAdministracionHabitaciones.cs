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

        public frmAdministracionHabitaciones()
        {
            InitializeComponent();
            btnbuscar.Focus();
            btnh15.Text = "Habitacion 15 Simple";
            btnh15.TextImageRelation = TextImageRelation.TextAboveImage;


        }

        private void groupBox1_MouseHover(object sender, System.EventArgs e)
        {
            // Update the mouse event label to indicate the MouseHover event occurred.
            lblfecha.Text = sender.GetType().ToString() + ": MouseHover";
        }

        private void frmAdministracionHabitaciones_Load(object sender, EventArgs e)
        {
            
            btnh15.Cursor = Cursors.Hand;
            lblh15.Text = "Disponible";
            lblh15.BackColor = Color.Silver;
            DateTime thisDay = DateTime.Today;
            
            try
            {
                btnh15.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
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


            clsHabitacion objHab1 = new clsHabitacion();
            objHab1.Estado = "disponible";

            if (MessageBox.Show("Do you want to exit?", "My Application",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
        private void button2_MouseHover(object sender, System.EventArgs e)
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

        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
