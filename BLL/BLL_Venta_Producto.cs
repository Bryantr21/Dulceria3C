using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Venta_Producto
    {
        public static List<Venta_Producto_VO> GetVentaProducto(params object[] parametros)
        {
            return DAL_Venta_Producto.GetVentaProducto(parametros);
        }
        //crear 
        public static string InsertarVentaProducto(Venta_Producto_VO venta_producto)
        {
            return DAL_Venta_Producto.InsertarVentaProducto(venta_producto);
        }
        //actualizar
        public static string ActualizarVentaProducto(Venta_Producto_VO venta_producto)
        {
            return DAL_Venta_Producto.ActualizarVentaProducto(venta_producto);
        }
        //delete
        public static string EliminarVentaProducto(int id)
        {
            return DAL_Venta_Producto.EliminarVentaProducto(id);
        }
    }
}
