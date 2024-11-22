using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Personal_VO
    {
        private int _Id_Persona;
        private string _Nombres;
        private string _Apellido_P;
        private string _Apellido_M;
        private string _Direccion;
        private string _Colonia;
        private string _Municipio_Delegacion;
        private string _Estado;
        private string _CURP;
        private string _Cel;
        private string _Email;
        private string _Puesto;

        public int Id_Persona { get => _Id_Persona; set => _Id_Persona = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellido_P { get => _Apellido_P; set => _Apellido_P = value; }
        public string Apellido_M { get => _Apellido_M; set => _Apellido_M = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Municipio_Delegacion { get => _Municipio_Delegacion; set => _Municipio_Delegacion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string CURP { get => _CURP; set => _CURP = value; }
        public string Cel { get => _Cel; set => _Cel = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Puesto { get => _Puesto; set => _Puesto = value; }

        public Personal_VO()
        {
            _Id_Persona = 0;
            _Nombres = "";
            _Apellido_P = "";
            _Apellido_M = "";
            _Direccion = "";
            _Colonia = "";
            _Municipio_Delegacion = "";
            _Estado = "";
            _CURP = "";
            _Cel = "";
            _Email = "";
            _Puesto = "";
        }
        public Personal_VO(DataRow dataRow)
        {
            _Id_Persona = int.Parse(dataRow["Id_Persona"].ToString());
            _Nombres = dataRow["Nombres"].ToString();
            _Apellido_P = dataRow["Apellido_P"].ToString();
            _Apellido_M = dataRow["Apellido_M"].ToString();
            _Direccion = dataRow["Direccion"].ToString();
            _Colonia = dataRow["Colonia"].ToString();
            _Municipio_Delegacion = dataRow["Municipio_Delegacion"].ToString();
            _Estado = dataRow["Estado"].ToString();
            _CURP = dataRow["CURP"].ToString();
            _Cel = dataRow["Cel"].ToString();
            _Email = dataRow["Email"].ToString();
            _Puesto = dataRow["Puesto"].ToString();
        }
    }
}
