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
    public partial class frmOpcionHab : Form
    {
        public frmOpcionHab()
        {
            InitializeComponent();
            btnocupado.TextImageRelation = TextImageRelation.TextAboveImage;
            btndisponible.TextImageRelation = TextImageRelation.TextAboveImage;
            button2.TextImageRelation = TextImageRelation.TextAboveImage;
            button3.TextImageRelation = TextImageRelation.TextAboveImage;
            button4.TextImageRelation = TextImageRelation.TextAboveImage;
            try
            {
                btnocupado.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\o.png");   
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                btndisponible.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\a.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            try
            {
                button3.Image = Image.FromFile("C:\\JUDYSOFT\\JUDYSOFT\\Images\\l.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Message: " + ex.Message, "JUDYSOFT Mensaje Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            clsHabitacion objHab = new clsHabitacion();
            objHab.Estado = "ocupado";

        }

        private void frmOpcionHab_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

