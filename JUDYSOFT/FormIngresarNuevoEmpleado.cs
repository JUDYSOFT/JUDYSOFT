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
using Libreria;
using System.Data.SqlClient;

namespace JUDYSOFT
{
    public partial class FormIngresarNuevoEmpleado : Form
    {
        Validaciones validar = new Validaciones();
        bool existe;
        string iden;
        public FormIngresarNuevoEmpleado()
        {
            InitializeComponent();


        }
        String conexion = "Data Source=" + Environment.MachineName + ";Initial Catalog=JUDYSOFT;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            try
            {
                if (textBoxNombres.Text != String.Empty && textBoxApellidos.Text != String.Empty && textBoxTelefonoConvencional.Text != String.Empty && textBoxCelular.Text != String.Empty && textBoxDireccion.Text != String.Empty && comboBoxTipoDeIdentificacion.SelectedItem.ToString() != String.Empty && textBoxIdentificacion.Text.ToString() != String.Empty && comboBoxProvincia.SelectedItem.ToString() != String.Empty && comboBoxCantones.SelectedItem.ToString() != String.Empty && textBoxCorreoElectronico.Text.ToString() != String.Empty && !dateTimePickerFechaDeNacimiento.Text.ToString().Equals("01-01-2000") && textBoxSalario.Text.ToString() != String.Empty && comboBoxCargo.SelectedItem.ToString() != String.Empty && textBoxNombres.Text.ToString() != String.Empty)
                {

                    if (radioButtonMasculino.Checked)
                    {
                        if (comboBoxCargo.SelectedItem.Equals("Administrador"))
                        {
                            try
                            {
                                con.Open();
                                //MessageBox.Show("\n" + textBoxNombres.Text + "\n" + textBoxApellidos.Text + "\n"
                                //+ textBoxTelefonoConvencional.Text + "\n" + textBoxCelular.Text + "\n" + textBoxDireccion.Text + "\n"
                                //+ textBoxDireccion.Text + "\n" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "\n"
                                //+ textBoxIdentificacion.Text + "\n" + radioButtonMasculino.Text.ToString() + "\n" + comboBoxProvincia.SelectedItem.ToString() + ""
                                //+ comboBoxCantones.SelectedItem.ToString() + "\n" + textBoxCorreoElectronico.Text + "\n" + dateTimePickerFechaDeNacimiento.Value.Date
                                //+ "\n" + dateTimePickerFechaDeEntrada.Value.Month + "\n" + textBoxSalario.Text.ToString() + "\n" +
                                //comboBoxCargo.SelectedItem.ToString() + "\n" + textBoxNombres.Text.ToString());

                                String fechaNacimiento = "" + dateTimePickerFechaDeNacimiento.Value.Day + "" + dateTimePickerFechaDeNacimiento.Value.Month + "" + dateTimePickerFechaDeNacimiento.Value.Year;
                                String fechaRegistro = "" + dateTimePickerFechaDeEntrada.Value.Day + "" + dateTimePickerFechaDeEntrada.Value.Month + "" + dateTimePickerFechaDeEntrada.Value.Year;
                                // cmd = new SqlCommand("insert into EMPLEADO (NOMBRE1EMPLEADO,APELLIDO1EMPLEADO,TELEFONO1EMPLEADO,TELEFONO2EMPLEADO,DIRECCIONEMPLEADO,DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD)values ('" + textBoxNombres.Text + ",'" + textBoxApellidos.Text + "','" + textBoxTelefonoConvencional.Text + "','" + textBoxCelular.Text + "','" + textBoxDireccion.Text + "','" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Text.ToString() + "', '" + dateTimePickerFechaDeEntrada.Text.ToString() + "', " + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "','12345678')", con);
                                // cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO, APELLIDO1EMPLEADO, TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD) values('Jose', 'Gonzalez', '0987142902', '0998833646', 'CALDERON', 'CEDULA','1724101538', 'Masculino', 'PICHINCHA', 'RUMIÑAHUI', 'jose2110@gmail,com', '21-10-1995', '22-02-2015', 301.02, 'Administrador', 3, 'sa', 'cont'");
                                cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO,NOMBRE2EMPLEADO, APELLIDO1EMPLEADO, APELLIDO2EMPLEADO,TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONDOMICILIOEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOIDENTIFICACIONEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHANACIMIENTOEMPLEADO, FECHAINGRESOEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, NOMBREUSUARIOEMPLEADO, CONTRASENIAEMPLEADO) values('" + textBoxNombres.Text + "', 'A','" + textBoxApellidos.Text + "', 'A','" + textBoxTelefonoConvencional.Text + "', '" + textBoxCelular.Text + "', '" + textBoxDireccion.Text + "', '" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Value + "', '" + dateTimePickerFechaDeEntrada.Value + "'," + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "', '12345678')", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Datos ingresados correctamente ");
                                con.Close();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("" + exc);
                            }

                        }
                        else if (comboBoxCargo.SelectedItem.Equals("Recepcionista"))
                        {
                            try
                            {
                                con.Open();
                                //MessageBox.Show("\n" + textBoxNombres.Text + "\n" + textBoxApellidos.Text + "\n"
                                //+ textBoxTelefonoConvencional.Text + "\n" + textBoxCelular.Text + "\n" + textBoxDireccion.Text + "\n"
                                //+ textBoxDireccion.Text + "\n" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "\n"
                                //+ textBoxIdentificacion.Text + "\n" + radioButtonMasculino.Text.ToString() + "\n" + comboBoxProvincia.SelectedItem.ToString() + ""
                                //+ comboBoxCantones.SelectedItem.ToString() + "\n" + textBoxCorreoElectronico.Text + "\n" + dateTimePickerFechaDeNacimiento.Value.Date
                                //+ "\n" + dateTimePickerFechaDeEntrada.Value.Month + "\n" + textBoxSalario.Text.ToString() + "\n" +
                                //comboBoxCargo.SelectedItem.ToString() + "\n" + textBoxNombres.Text.ToString());

                                String fechaNacimiento = "" + dateTimePickerFechaDeNacimiento.Value.Day + "" + dateTimePickerFechaDeNacimiento.Value.Month + "" + dateTimePickerFechaDeNacimiento.Value.Year;
                                String fechaRegistro = "" + dateTimePickerFechaDeEntrada.Value.Day + "" + dateTimePickerFechaDeEntrada.Value.Month + "" + dateTimePickerFechaDeEntrada.Value.Year;
                                // cmd = new SqlCommand("insert into EMPLEADO (NOMBRE1EMPLEADO,APELLIDO1EMPLEADO,TELEFONO1EMPLEADO,TELEFONO2EMPLEADO,DIRECCIONEMPLEADO,DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD)values ('" + textBoxNombres.Text + ",'" + textBoxApellidos.Text + "','" + textBoxTelefonoConvencional.Text + "','" + textBoxCelular.Text + "','" + textBoxDireccion.Text + "','" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Text.ToString() + "', '" + dateTimePickerFechaDeEntrada.Text.ToString() + "', " + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "','12345678')", con);
                                // cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO, APELLIDO1EMPLEADO, TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD) values('Jose', 'Gonzalez', '0987142902', '0998833646', 'CALDERON', 'CEDULA','1724101538', 'Masculino', 'PICHINCHA', 'RUMIÑAHUI', 'jose2110@gmail,com', '21-10-1995', '22-02-2015', 301.02, 'Administrador', 3, 'sa', 'cont'");
                                cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO,NOMBRE2EMPLEADO ,APELLIDO1EMPLEADO, APELLIDO2EMPLEADO,TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONDOMICILIOEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOIDENTIFICACIONEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHANACIMIENTOEMPLEADO, FECHAINGRESOEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, NOMBREUSUARIOEMPLEADO, CONTRASENIAEMPLEADO) values('" + textBoxNombres.Text + "', 'A','" + textBoxApellidos.Text + "','A' ,'" + textBoxTelefonoConvencional.Text + "', '" + textBoxCelular.Text + "', '" + textBoxDireccion.Text + "', '" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Value + "', '" + dateTimePickerFechaDeEntrada.Value + "'," + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 1, '" + textBoxNombres.Text.ToString() + "', '12345678')", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Datos ingresados correctamente ");
                                con.Close();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("" + exc);
                            }
                        }

                        }
                    
                    else if (radioButtonFemenino.Checked)
                    {
                        if (comboBoxCargo.SelectedItem.Equals("Administrador"))
                        {
                            try
                            {
                                con.Open();
                                //MessageBox.Show("\n" + textBoxNombres.Text + "\n" + textBoxApellidos.Text + "\n"
                                //+ textBoxTelefonoConvencional.Text + "\n" + textBoxCelular.Text + "\n" + textBoxDireccion.Text + "\n"
                                //+ textBoxDireccion.Text + "\n" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "\n"
                                //+ textBoxIdentificacion.Text + "\n" + radioButtonMasculino.Text.ToString() + "\n" + comboBoxProvincia.SelectedItem.ToString() + ""
                                //+ comboBoxCantones.SelectedItem.ToString() + "\n" + textBoxCorreoElectronico.Text + "\n" + dateTimePickerFechaDeNacimiento.Value.Date
                                //+ "\n" + dateTimePickerFechaDeEntrada.Value.Month + "\n" + textBoxSalario.Text.ToString() + "\n" +
                                //comboBoxCargo.SelectedItem.ToString() + "\n" + textBoxNombres.Text.ToString());

                                String fechaNacimiento = "" + dateTimePickerFechaDeNacimiento.Value.Day + "" + dateTimePickerFechaDeNacimiento.Value.Month + "" + dateTimePickerFechaDeNacimiento.Value.Year;
                                String fechaRegistro = "" + dateTimePickerFechaDeEntrada.Value.Day + "" + dateTimePickerFechaDeEntrada.Value.Month + "" + dateTimePickerFechaDeEntrada.Value.Year;
                                // cmd = new SqlCommand("insert into EMPLEADO (NOMBRE1EMPLEADO,APELLIDO1EMPLEADO,TELEFONO1EMPLEADO,TELEFONO2EMPLEADO,DIRECCIONEMPLEADO,DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD)values ('" + textBoxNombres.Text + ",'" + textBoxApellidos.Text + "','" + textBoxTelefonoConvencional.Text + "','" + textBoxCelular.Text + "','" + textBoxDireccion.Text + "','" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Text.ToString() + "', '" + dateTimePickerFechaDeEntrada.Text.ToString() + "', " + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "','12345678')", con);
                                // cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO, APELLIDO1EMPLEADO, TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD) values('Jose', 'Gonzalez', '0987142902', '0998833646', 'CALDERON', 'CEDULA','1724101538', 'Masculino', 'PICHINCHA', 'RUMIÑAHUI', 'jose2110@gmail,com', '21-10-1995', '22-02-2015', 301.02, 'Administrador', 3, 'sa', 'cont'");
                                cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO, NOMBRE2EMPLEADO, APELLIDO1EMPLEADO, APELLIDO2EMPLEADO,TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONDOMICILIOEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOIDENTIFICACIONEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHANACIMIENTOEMPLEADO, FECHAINGRESOEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, NOMBREUSUARIOEMPLEADO, CONTRASENIAEMPLEADO) values('" + textBoxNombres.Text + "', 'A','" + textBoxApellidos.Text + "', 'A','" + textBoxTelefonoConvencional.Text + "', '" + textBoxCelular.Text + "', '" + textBoxDireccion.Text + "', '" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonFemenino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Value + "', '" + dateTimePickerFechaDeEntrada.Value + "'," + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "', '12345678')", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Datos ingresados correctamente ");
                                con.Close();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("" + exc);
                            }
                        }
                        else if (comboBoxCargo.SelectedItem.Equals("Recepcionista"))
                        {
                            try
                            {
                                con.Open();
                                //MessageBox.Show("\n" + textBoxNombres.Text + "\n" + textBoxApellidos.Text + "\n"
                                //+ textBoxTelefonoConvencional.Text + "\n" + textBoxCelular.Text + "\n" + textBoxDireccion.Text + "\n"
                                //+ textBoxDireccion.Text + "\n" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "\n"
                                //+ textBoxIdentificacion.Text + "\n" + radioButtonMasculino.Text.ToString() + "\n" + comboBoxProvincia.SelectedItem.ToString() + ""
                                //+ comboBoxCantones.SelectedItem.ToString() + "\n" + textBoxCorreoElectronico.Text + "\n" + dateTimePickerFechaDeNacimiento.Value.Date
                                //+ "\n" + dateTimePickerFechaDeEntrada.Value.Month + "\n" + textBoxSalario.Text.ToString() + "\n" +
                                //comboBoxCargo.SelectedItem.ToString() + "\n" + textBoxNombres.Text.ToString());

                                String fechaNacimiento = "" + dateTimePickerFechaDeNacimiento.Value.Day + "" + dateTimePickerFechaDeNacimiento.Value.Month + "" + dateTimePickerFechaDeNacimiento.Value.Year;
                                String fechaRegistro = "" + dateTimePickerFechaDeEntrada.Value.Day + "" + dateTimePickerFechaDeEntrada.Value.Month + "" + dateTimePickerFechaDeEntrada.Value.Year;
                                // cmd = new SqlCommand("insert into EMPLEADO (NOMBRE1EMPLEADO,APELLIDO1EMPLEADO,TELEFONO1EMPLEADO,TELEFONO2EMPLEADO,DIRECCIONEMPLEADO,DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD)values ('" + textBoxNombres.Text + ",'" + textBoxApellidos.Text + "','" + textBoxTelefonoConvencional.Text + "','" + textBoxCelular.Text + "','" + textBoxDireccion.Text + "','" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonMasculino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Text.ToString() + "', '" + dateTimePickerFechaDeEntrada.Text.ToString() + "', " + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 2, '" + textBoxNombres.Text.ToString() + "','12345678')", con);
                                // cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO, APELLIDO1EMPLEADO, TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, USUARIO, EMPLEADO.PASSWORD) values('Jose', 'Gonzalez', '0987142902', '0998833646', 'CALDERON', 'CEDULA','1724101538', 'Masculino', 'PICHINCHA', 'RUMIÑAHUI', 'jose2110@gmail,com', '21-10-1995', '22-02-2015', 301.02, 'Administrador', 3, 'sa', 'cont'");
                                cmd = new SqlCommand("insert into EMPLEADO(NOMBRE1EMPLEADO,NOMBRE2EMPLEADO ,APELLIDO1EMPLEADO, APELLIDO2EMPLEADO,TELEFONO1EMPLEADO, TELEFONO2EMPLEADO, DIRECCIONDOMICILIOEMPLEADO, DOCUMENTOIDENTIFICACIONEMPLEADO,NUMERODOCUMENTOIDENTIFICACIONEMPLEADO, SEXOEMPLEADO, PROVINCIAORIGENEMPLEADO, CIUDADORIGENEMPLEADO, CORREOELECTRONICOEMPLEADO, FECHAINGRESOEMPLEADO, FECHASALIDAEMPLEADO, SALARIOEMPLEADO, CARGOEMPLEADO, NIVELACCESOEMPLEADO, NOMBREUSUARIOEMPLEADO, CONTRASENIAEMPLEADO) values('" + textBoxNombres.Text + "', 'A','" + textBoxApellidos.Text + "','A' ,'" + textBoxTelefonoConvencional.Text + "', '" + textBoxCelular.Text + "', '" + textBoxDireccion.Text + "', '" + comboBoxTipoDeIdentificacion.SelectedItem.ToString() + "','" + textBoxIdentificacion.Text + "', '" + radioButtonFemenino.Text.ToString() + "', '" + comboBoxProvincia.SelectedItem.ToString() + "', '" + comboBoxCantones.SelectedItem.ToString() + "', '" + textBoxCorreoElectronico.Text + "', '" + dateTimePickerFechaDeNacimiento.Value + "', '" + dateTimePickerFechaDeEntrada.Value + "'," + textBoxSalario.Text.ToString() + ", '" + comboBoxCargo.SelectedItem.ToString() + "', 1, '" + textBoxNombres.Text.ToString() + "', '12345678')", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Datos ingresados correctamente ");
                                con.Close();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show("" + exc);
                            }
                        }
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Campos vacios");
                    if (textBoxNombres.Text == String.Empty)
                    {
                        textBoxNombres.BackColor = Color.LightCoral;
                        MessageBox.Show("Campos vacios");
                    }
                }


            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede autocompletar el textBox");
            }
            con.Close();

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

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIdentificacion_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e, textBoxIdentificacion);



        }

        private void textBoxNombres_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            validar.validarCadenasDeTexto(e, textBoxNombres);


        }

        private void textBoxApellidos_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            validar.validarCadenasDeTexto(e, textBoxApellidos);

        }

        private void textBoxDireccion_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                textBoxDireccion.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxDireccion.BackColor = Color.LightCoral;
                e.Handled = true;
            }

        }

        private void textBoxCorreoElectronico_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (validar.emailBienEscrito(textBoxCorreoElectronico.Text))
            {
                textBoxCorreoElectronico.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxCorreoElectronico.BackColor = Color.LightCoral;
            }

        }

        private void textBoxTelefonoConvencional_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (validar.validartelefono(textBoxTelefonoConvencional.Text) && textBoxTelefonoConvencional.Text.Length == 10 && validar.validarCamposNumericos(e, textBoxTelefonoConvencional))
            {
                textBoxTelefonoConvencional.BackColor = Color.LightGreen;
            }
            else if (textBoxTelefonoConvencional.Text.Length > 10)
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.Show("SOLO SE PUEDEN INGRESAR 10 DIGITOS", textBoxTelefonoConvencional, 1000);
                textBoxTelefonoConvencional.BackColor = Color.LightCoral;
                e.Handled = true;
            }

        }
        private void textBoxCelular_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            validar.validarCamposNumericos(e, textBoxCelular);
            if (validar.validartelefono(textBoxCelular.Text) && textBoxCelular.Text.Length == 10)
            {
                textBoxCelular.BackColor = Color.LightGreen;
            }
            else if (textBoxCelular.Text.Length > 10)
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.Show("NSOLO SE PUEDEN INGRESAR 10 DIGITOS", textBoxCelular, 1000);
                textBoxCelular.BackColor = Color.LightCoral;
                e.Handled = true;
            }

        }

        private void textBoxSalario_TextChanged(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (textBoxSalario.Focused)
            {
                //MessageBox.Show("Para el numero " + textBoxSalario.Text + " se valida que " + validar.decimales(textBoxSalario.Text));
                if (!validar.decimales(textBoxSalario.Text))
                {
                    ToolTip toolTip1 = new ToolTip();
                    toolTip1.Show("DIGITO NO VALIDO", textBoxCelular, 1000);
                    textBoxSalario.BackColor = Color.LightCoral;


                }
                else
                {
                    textBoxSalario.BackColor = Color.LightGreen;

                }
            }

        }

        private void rellenar(String id, String nombreBase, TextBox campo)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            if (id.Length >= 10)
            {
                try
                {

                    con.Open();

                    cmd = new SqlCommand("select " + nombreBase + " from EMPLEADO where NUMERODOCUMENTOEMPLEADO like '%" + id + "%' AND len(NUMERODOCUMENTOEMPLEADO) = 10", con);
                    // cmd = new SqlCommand("select " + nombreBase + " from EMPLEADO where NUMERODOCUMENTOEMPLEADO =" + id + "%' AND len(NUMERODOCUMENTOEMPLEADO) = 10", con);
                    iden = id;
                    dr = cmd.ExecuteReader();


                    //mensajeAdvertencia.Text = "Coincidencia encontrada: " + dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                    while (dr.Read())
                    {

                        String busqueda = dr["" + nombreBase].ToString();
                        campo.Text = busqueda;

                    }
                }
                catch (Exception ex)
                {
                    // MessageBox.Show("No se puede autocompletar el textBox");
                }
                con.Close();
            }

        }

        private bool existeCedula(String id)
        {
            bool bandera = false;
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            try
            {
                con.Open();
                cmd = new SqlCommand("select NUMERODOCUMENTOEMPLEADO from EMPLEADO where NUMERODOCUMENTOEMPLEADO =" + id, con);
                dr = cmd.ExecuteReader();
                //mensajeAdvertencia.Text = "Coincidencia encontrada: " + dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                while (dr.Read())
                {

                    String busqueda = dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                    if (!busqueda.Equals(""))
                    {
                        bandera = true;
                    }
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede autocompletar el textBox");
            }
            con.Close();
            return bandera;
        }
        private void rellenar(String id, String nombreBase, ComboBox campo)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            try
            {

                con.Open();

                cmd = new SqlCommand("select " + nombreBase + " from EMPLEADO where NUMERODOCUMENTOEMPLEADO like '%" + id + "%'", con);

                dr = cmd.ExecuteReader();

                //mensajeAdvertencia.Text = "Coincidencia encontrada: " + dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                while (dr.Read())
                {

                    String busqueda = dr["" + nombreBase].ToString();
                    campo.Text = busqueda;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede autocompletar el textBox");
            }
            con.Close();
        }

        private void rellenar(String id, String nombreBase, DateTimePicker campo)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            try
            {

                con.Open();

                cmd = new SqlCommand("select " + nombreBase + " from EMPLEADO where NUMERODOCUMENTOEMPLEADO like '%" + id + "%'", con);

                dr = cmd.ExecuteReader();
                //mensajeAdvertencia.Text = "Coincidencia encontrada: " + dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                while (dr.Read())
                {
                    String busqueda = dr["" + nombreBase].ToString();
                    campo.Text = busqueda;

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede autocompletar el textBox");
            }
            con.Close();
        }

        private void rellenar(String id, String nombreBase)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            con = new SqlConnection(conexion);
            try
            {

                con.Open();

                cmd = new SqlCommand("select " + nombreBase + " from EMPLEADO where NUMERODOCUMENTOEMPLEADO like '%" + id + "%'", con);

                dr = cmd.ExecuteReader();
                //mensajeAdvertencia.Text = "Coincidencia encontrada: " + dr["NUMERODOCUMENTOEMPLEADO"].ToString();
                while (dr.Read())
                {
                    String busqueda = dr["" + nombreBase].ToString();
                    if (busqueda.Equals("M"))
                    {
                        radioButtonMasculino.Checked = true;
                    }
                    else if (busqueda.Equals("F"))
                    {
                        radioButtonFemenino.Checked = true;
                    }

                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("No se puede autocompletar el textBox");
            }
            con.Close();
        }



        private void comboBoxProvincia_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBoxProvincia.SelectedItem.Equals("Azuay"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("Caluma");
                col.Add("Camilo Ponce");
                col.Add("Chordeleg");
                col.Add("Cuenca");
                col.Add("Girón");
                col.Add("Guachapala");
                col.Add("Gualaceo");
                col.Add("Nabón");
                col.Add("Oña");
                col.Add("Paute");
                col.Add("Pucará");
                col.Add("San Fernando");
                col.Add("Santa Isabel");
                col.Add("Sevilla De Oro");
                col.Add("Sigsig");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }


            }
            else if (comboBoxProvincia.SelectedItem.Equals("Bolivar"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("Caluma");
                col.Add("Chillanes");
                col.Add("Chimbo");
                col.Add("Echeandía");
                col.Add("Guaranda");
                col.Add("Las Naves");
                col.Add("San Miguel");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Cañar"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("Azogues");
                col.Add("Biblián");
                col.Add("Cañar");
                col.Add("Deleg");
                col.Add("La Troncal");
                col.Add("Suscal");
                col.Add("Tambo");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Carchi"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Bolívar");
                col.Add("Espejo");
                col.Add("Mira");
                col.Add("Montúfar");
                col.Add("San Pedro De Huaca");
                col.Add("Tulcán");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Chimborazo"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("Alausí");
                col.Add("Chambo");
                col.Add("Chunchi");
                col.Add("Colta");
                col.Add("Cumanda");
                col.Add("Guamote");
                col.Add("Guano");
                col.Add("Pallatanga");
                col.Add("Penipe");
                col.Add("Riobamba");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Cotopaxi"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("La Maná");
                col.Add("Latacunga");
                col.Add("Pangua");
                col.Add("Pujilí");
                col.Add("Salcedo");
                col.Add("Saquisilí");
                col.Add("Sigchos");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("El Oro"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Arenillas");
                col.Add("Atahualpa");
                col.Add("Balsas");
                col.Add("Chilla");
                col.Add("El Guabo");
                col.Add("Huaquillas");
                col.Add("Las Lajas");
                col.Add("Machala");
                col.Add("Marcabelí");
                col.Add("Pasaje");
                col.Add("Piñas");
                col.Add("Portovelo");
                col.Add("Santa Rosa");
                col.Add("Zaruma");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Esmeraldas"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Atacames");
                col.Add("Eloy Alfaro");
                col.Add("Esmeraldas");
                col.Add("Muisne");
                col.Add("Quininde");
                col.Add("Rio Verde");
                col.Add("San Lorenzo");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Galápagos"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Isabela");
                col.Add("San Cristóbal");
                col.Add("Santa Cruz");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Guayas"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Alfredo Baquerizo Moreno(Jujan)");
                col.Add("Balao");
                col.Add("Balzar");
                col.Add("Colimes");
                col.Add("Daule");
                col.Add("Duran");
                col.Add("El Triunfo");
                col.Add("Empalme");
                col.Add("General Antonio Elizalde (Bucay)");
                col.Add("General Villamil(Playas)");
                col.Add("Guayaquil");
                col.Add("Isidro Ayora");
                col.Add("Lomas De Sargentillo");
                col.Add("Marcelino Mariduena");
                col.Add("Milagro");
                col.Add("Naranjal");
                col.Add("Naranjito");
                col.Add("Nobol(Narcisa De Jesus)");
                col.Add("Palestina");
                col.Add("Pedro Carbo");
                col.Add("Samborondon");
                col.Add("Santa Lucia");
                col.Add("Simon Bolivar");
                col.Add("Urbina Jado(Salitre)");
                col.Add("Yaguachi");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Imbabura"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Antonio Ante");
                col.Add("Cotacachi");
                col.Add("Ibarra");
                col.Add("Otavalo");
                col.Add("Pimampiro");
                col.Add("San Miguel De Urcuquí");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }

            }
            else if (comboBoxProvincia.SelectedItem.Equals("Loja"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Calvas");
                col.Add("Catamayo");
                col.Add("Celica");
                col.Add("Chaguarpamba");
                col.Add("Espíndola");
                col.Add("Gonzanamá");
                col.Add("Loja");
                col.Add("Macará");
                col.Add("Olmedo");
                col.Add("Paltas");
                col.Add("Pindal");
                col.Add("Puyango");
                col.Add("Quilanga");
                col.Add("Saraguro");
                col.Add("Sozoranga");
                col.Add("Zapotillo");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Los Rios"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Baba");
                col.Add("Babahoyo");
                col.Add("Buena Fe");
                col.Add("Mocache");
                col.Add("Montalvo");
                col.Add("Palenque");
                col.Add("Pueblo Viejo");
                col.Add("Quevedo");
                col.Add("Urdaneta");
                col.Add("Valencia");
                col.Add("Ventanas");
                col.Add("Vinces");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }

            }
            else if (comboBoxProvincia.SelectedItem.Equals("Manabí"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Add("24 De Mayo");
                col.Add("Bolivar");
                col.Add("Chone");
                col.Add("El Carmen");
                col.Add("Flavio Alfaro");
                col.Add("Jama");
                col.Add("Jaramijo");
                col.Add("Jipijapa");
                col.Add("Junin");
                col.Add("Manta");
                col.Add("Montecristi");
                col.Add("Olmedo");
                col.Add("Pajan");
                col.Add("Pedernales");
                col.Add("Pichincha");
                col.Add("Portoviejo");
                col.Add("Puerto Lopez");
                col.Add("Rocafuerte");
                col.Add("San Vicente");
                col.Add("Santa Ana");
                col.Add("Sucre");
                col.Add("Tosagua");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Morona Santiago"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Gualaquiza");
                col.Add("Huamboya");
                col.Add("Limon - indanza");
                col.Add("Logroño");
                col.Add("Morona");
                col.Add("Pablo VI");
                col.Add("Palora");
                col.Add("San Juan Bosco");
                col.Add("Santiago");
                col.Add("Sucua");
                col.Add("Taisha");
                col.Add("Twintza");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Napo"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Aguarico");
                col.Add("Archidona");
                col.Add("Carlos J.Arosemena");
                col.Add("El Chaco");
                col.Add("Quijos");
                col.Add("Tena");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Orellana"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Aguarico");
                col.Add("La Joya De Los Sachas");
                col.Add("Loreto");
                col.Add("Orellana");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Pastaza"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Arajuno");
                col.Add("Mera");
                col.Add("Pastaza");
                col.Add("Santa Clara");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Pichincha"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Cayambe");
                col.Add("Mejia");
                col.Add("Pedro Moncayo");
                col.Add("Pedro Vicente Maldonado");
                col.Add("Puerto Quito");
                col.Add("Quito");
                col.Add("Rumiñahui");
                col.Add("San Miguel De Los Bancos");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Santa Elena"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("La Libertad");
                col.Add("Salinas");
                col.Add("Santa Elena");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Santo Domingo de los Tsáchilas"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Santo Domingo De Los Tsáchilas");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }

            }
            else if (comboBoxProvincia.SelectedItem.Equals("Sucumbíos"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Cascales");
                col.Add("Cuyabeno");
                col.Add("Gonzalo Pizarro");
                col.Add("Lago Agrio");
                col.Add("Putumayo");
                col.Add("Shushufindi");
                col.Add("Sucumbios");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Tungurahua"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Ambato");
                col.Add("Baños De Agua Santa");
                col.Add("Cevallos");
                col.Add("Mocha");
                col.Add("Patate");
                col.Add("Quero");
                col.Add("San Pedro De Pelileo");
                col.Add("Santiago De Pillaro");
                col.Add("Tisaleo");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }
            else if (comboBoxProvincia.SelectedItem.Equals("Zamora Chinchipe"))
            {
                comboBoxCantones.Items.Clear();
                comboBoxCantones.AutoCompleteMode = AutoCompleteMode.Append;
                comboBoxCantones.AutoCompleteSource = AutoCompleteSource.ListItems;
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                col.Clear();
                col.Add("Centinela Del Condor");
                col.Add("Chinchipe");
                col.Add("El Pangui");
                col.Add("Nangaritza");
                col.Add("Palanda");
                col.Add("Yacuambi");
                col.Add("Yantzaza");
                col.Add("Zamora");
                for (int i = 0; i < col.Count; i++)
                {
                    comboBoxCantones.Items.Insert(i, col[i]);
                }
            }

        }


        private void comboBoxCantones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoDeIdentificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoDeIdentificacion.SelectedItem.Equals("CEDULA") || comboBoxTipoDeIdentificacion.SelectedItem.Equals("PASAPORTE"))
            {
                textBoxIdentificacion.Enabled = true;
                buttonValidar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun tipo de documento");
            }


        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (validar.verificarCedula(textBoxIdentificacion.Text))
            {
                if (existeCedula(textBoxIdentificacion.Text))
                {
                    deshabilitarCampos();
                    rellenarCampos();
                }

                else
                {
                    if (textBoxIdentificacion.Text.Length == 10)
                    {
                        comboBoxTipoDeIdentificacion.SelectedItem = "CEDULA";
                        vaciarCampos();
                        habilitarCampos();
                    }
                    else
                    {
                        ToolTip toolTip1 = new ToolTip();
                        toolTip1.Show("LOGITUD DE LA CEDULA: 10 DIGITOS", textBoxIdentificacion, 1000);
                        textBoxIdentificacion.BackColor = Color.LightCoral;
                        vaciarCampos();
                    }
                    //else if (textBoxIdentificacion.Text.Length < 10)
                    //{
                    //    comboBoxTipoDeIdentificacion.SelectedItem = "PASAPORTE";
                    //    habilitarCampos();
                    //}
                }
            }
            else
            {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.Show("NUMERO DE CEDULA NO VALIDO", textBoxIdentificacion, 1000);
                textBoxIdentificacion.BackColor = Color.LightCoral;
                vaciarCampos();
                deshabilitarCampos();
            }

        }
        public void rellenarCampos()
        {
            rellenar(textBoxIdentificacion.Text, "NOMBRE1EMPLEADO", textBoxNombres);
            rellenar(textBoxIdentificacion.Text, "APELLIDO1EMPLEADO", textBoxApellidos);
            rellenar(textBoxIdentificacion.Text, "DIRECCIONEMPLEADO", textBoxDireccion);
            rellenar(textBoxIdentificacion.Text, "CORREOELECTRONICOEMPLEADO", textBoxCorreoElectronico);
            rellenar(textBoxIdentificacion.Text, "TELEFONO1EMPLEADO", textBoxCelular);
            rellenar(textBoxIdentificacion.Text, "TELEFONO2EMPLEADO", textBoxTelefonoConvencional);
            rellenar(textBoxIdentificacion.Text, "SALARIOEMPLEADO", textBoxSalario);
            rellenar(textBoxIdentificacion.Text, "CARGOEMPLEADO", comboBoxCargo);
            rellenar(textBoxIdentificacion.Text, "PROVINCIAORIGENEMPLEADO", comboBoxProvincia);
            rellenar(textBoxIdentificacion.Text, "CIUDADORIGENEMPLEADO", comboBoxCantones);
            rellenar(textBoxIdentificacion.Text, "DOCUMENTOIDENTIFICACIONEMPLEADO", comboBoxTipoDeIdentificacion);
            rellenar(textBoxIdentificacion.Text, "FECHAINGRESOEMPLEADO", dateTimePickerFechaDeNacimiento);
            rellenar(textBoxIdentificacion.Text, "FECHASALIDAEMPLEADO", dateTimePickerFechaDeEntrada);
            rellenar(textBoxIdentificacion.Text, "SEXOEMPLEADO");
        }
        public void habilitarCampos()
        {
            textBoxNombres.Enabled = true;
            textBoxApellidos.Enabled = true;
            textBoxDireccion.Enabled = true;
            textBoxCorreoElectronico.Enabled = true;
            textBoxTelefonoConvencional.Enabled = true;
            textBoxCelular.Enabled = true;
            textBoxSalario.Enabled = true;
            comboBoxCargo.Enabled = true;
            comboBoxProvincia.Enabled = true;
            comboBoxCantones.Enabled = true;
            comboBoxTipoDeIdentificacion.Enabled = true;
            dateTimePickerFechaDeNacimiento.Enabled = true;
            buttonValidar.Enabled = true;
            textBoxIdentificacion.Enabled = true;
            radioButtonMasculino.Enabled = true;
            radioButtonFemenino.Enabled = true;
            buttonGuardar.Enabled = true;

        }
        public void vaciarCampos()
        {
            textBoxNombres.Text = "";
            textBoxApellidos.Text = "";
            textBoxDireccion.Text = "";
            textBoxCorreoElectronico.Text = "";
            textBoxTelefonoConvencional.Text = "";
            textBoxCelular.Text = "";
            textBoxSalario.Text = "";
            comboBoxCargo.SelectedIndex = 0;
            comboBoxProvincia.SelectedIndex = 0;
            comboBoxCantones.SelectedIndex = 0;
            dateTimePickerFechaDeEntrada.Value = DateTime.Today;
            dateTimePickerFechaDeNacimiento.Text = "01-01-2000";
        }
        public void deshabilitarCampos()
        {
            textBoxNombres.Enabled = false;
            textBoxApellidos.Enabled = false;
            textBoxDireccion.Enabled = false;
            textBoxCorreoElectronico.Enabled = false;
            textBoxTelefonoConvencional.Enabled = false;
            textBoxCelular.Enabled = false;
            textBoxSalario.Enabled = false;
            comboBoxCargo.Enabled = false;
            comboBoxProvincia.Enabled = false;
            comboBoxCantones.Enabled = false;
            comboBoxTipoDeIdentificacion.Enabled = false;
            dateTimePickerFechaDeNacimiento.Enabled = false;
            radioButtonFemenino.Enabled = false;
            radioButtonMasculino.Enabled = false;
            buttonValidar.Enabled = true;
            textBoxIdentificacion.Enabled = true;
            buttonGuardar.Enabled = false;
        }

    }
}
