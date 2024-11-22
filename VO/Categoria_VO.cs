using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Categoria_VO
    {
        private int _Id_Categoria;
        private string _Nombre;
        private string _Descripcion;

        public int Id_Categoria { get => _Id_Categoria; set => _Id_Categoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public Categoria_VO()
        {
            _Id_Categoria = 0;
            _Nombre = "";
            _Descripcion = "";
        }
        public Categoria_VO(DataRow dataRow)
        {
            _Id_Categoria = int.Parse(dataRow["Id_Categoria"].ToString());
            _Nombre = dataRow["Nombre"].ToString();
            _Descripcion = dataRow["Descripcion"].ToString();
        }
    }
}
