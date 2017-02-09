﻿using System;
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
    public partial class FormReservas : Form
    {
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
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormReservas_Load(object sender, EventArgs e)
        {

        }
            
        private void FormReservas_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Esta seguro que desea salir", "JUDYSOFT", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (confirmacion == System.Windows.Forms.DialogResult.OK)
            {
                this.Dispose();
                MenuSettings.EnableMenuItem("habitacionesToolStripMenuItem", "reservacionesToolStripMenuItem");
            }
        }

    }
}
