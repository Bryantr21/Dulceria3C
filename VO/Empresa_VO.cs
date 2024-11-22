using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Empresa_VO
    {
        private int _Id_Empresa;
        private string _Nombre;
        private string _Direccion;
        private string _Colonia;
        private string _Municipio_Delegacion;
        private string _Estado;
        private string _Email;
        private string _Cel;
        private string _Descripcion;

        public int Id_Empresa { get => _Id_Empresa; set => _Id_Empresa = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Colonia { get => _Colonia; set => _Colonia = value; }
        public string Municipio_Delegacion { get => _Municipio_Delegacion; set => _Municipio_Delegacion = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Cel { get => _Cel; set => _Cel = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public Empresa_VO()
        {
            _Id_Empresa = 0;
            _Nombre = "";
            _Direccion = "";
            _Colonia = "";
            _Municipio_Delegacion = "";
            _Estado = "";
            _Email = "";
            _Cel = "";
            _Descripcion = "";
        }

        public Empresa_VO(DataRow dataRow)
        {
            _Id_Empresa = int.Parse(dataRow["Id_Empresa"].ToString());
            _Nombre = dataRow["Nombre"].ToString();
            _Direccion = dataRow["Direccion"].ToString();
            _Colonia = dataRow["Colonia"].ToString();
            _Municipio_Delegacion = dataRow["Municipio_Delegacion"].ToString();
            _Estado = dataRow["Estado"].ToString();
            _Email = dataRow["Email"].ToString();
            _Cel = dataRow["Cel"].ToString();
            _Descripcion = dataRow["Descripcion"].ToString();
        }
    }
}
