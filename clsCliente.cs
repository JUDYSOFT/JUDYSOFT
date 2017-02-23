using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JUDYSOFT
{
    class clsCliente
    {
        private string nombre1,nombre2,apellido1,apellido2,documento,numDocumento
            ,estadoCivil,procedencia,nacionalidad,direccion,correo, sexo, telefono1, telefono2;
        private DateTime fechaNac;

        public string Nombre1 { get { return nombre1; } set { nombre1 = value; } }
        public string Nombre2 { get {return nombre2; } set {nombre2=value; } }
        public string Apellido1 { get {return apellido1; } set {apellido1=value; } }
        public string Apellido2 { get {return apellido2; } set {apellido2=value; } }
        public string Documento { get { return documento; } set { documento = value; } }
        public string NumDocumento { get { return numDocumento; } set { numDocumento = value; } }
        public string Telefono1 { get { return telefono1; } set { telefono1 = value; } }
        public string Telefono2 { get { return telefono2; } set { telefono2 = value; } }
        public string EstadoCivil { get { return estadoCivil; } set { estadoCivil = value; } }
        public string Procedencia { get { return procedencia; } set { procedencia = value; } }
        public string Nacionalidad { get { return nacionalidad; } set { nacionalidad = value; } }
        public DateTime ? FechaNac { get { return fechaNac; } set { fechaNac = (DateTime) value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Correo { get { return correo; } set {correo = value; } }
        public string Sexo { get { return sexo; } set { sexo = value; } }
    }
}
