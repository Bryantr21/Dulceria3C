using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Productos_VO
    {
        private int _Id_producto;
        private int _Categoria_Id;
        private string _Nombre;
        private int _Precio;
        private string _Marca;
        private int _Cantidad;
        private string _Caducidad;

        public int Id_producto { get => _Id_producto; set => _Id_producto = value; }
        public int Categoria_Id { get => _Categoria_Id; set => _Categoria_Id = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Precio { get => _Precio; set => _Precio = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string Caducidad { get => _Caducidad; set => _Caducidad = value; }
        public Productos_VO()
        {
            _Id_producto = 0;
            _Categoria_Id = 0;
            _Nombre = "";
            _Precio = 0;
            _Marca = "";
            _Cantidad = 0;
            _Caducidad = "";

        }
        public Productos_VO(DataRow dataRow)
        {
            _Id_producto = int.Parse(dataRow["Id_producto"].ToString());
            _Categoria_Id = int.Parse(dataRow["Categoria_Id"].ToString());
            _Nombre = dataRow["Nombre"].ToString();
            _Precio = int.Parse(dataRow["Precio"].ToString());
            _Marca = dataRow["Marca"].ToString();
            _Cantidad = int.Parse(dataRow["Cantidad"].ToString());
            _Caducidad = dataRow["Caducidad"].ToString();
        }
    }
}
