using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Venta_Producto_VO
    {
        private int _ID_Venta_Producto;
        private int _Producto_Id;
        private int _Venta_Id;

        public int ID_Venta_Producto { get => _ID_Venta_Producto; set => _ID_Venta_Producto = value; }
        public int Producto_Id { get => _Producto_Id; set => _Producto_Id = value; }
        public int Venta_Id { get => _Venta_Id; set => _Venta_Id = value; }

        public Venta_Producto_VO()
        {
            _ID_Venta_Producto = 0;
            _Producto_Id = 0;
            _Venta_Id = 0;
        }
        public Venta_Producto_VO(DataRow dataRow)
        {
            _ID_Venta_Producto = int.Parse(dataRow["ID_Venta_Producto"].ToString());
            _Producto_Id = int.Parse(dataRow["Producto_Id"].ToString());
            _Venta_Id = int.Parse(dataRow["Venta_Id"].ToString());
        }
    }
}
