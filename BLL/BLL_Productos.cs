using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Productos
    {
        public static List<Productos_VO> GetProductos(params object[] parametros)
        {
            return DAL_Productos.GetProductos(parametros);
        }
        //crear 
        public static string InsertarProductos(Productos_VO productos)
        {
            return DAL_Productos.InsertarProductos(productos);
        }
        //actualizar
        public static string ActualizarProductos(Productos_VO productos)
        {
            return DAL_Productos.ActualizarProductos(productos);
        }
        //delete
        public static string EliminarProductos(int id)
        {
            return DAL_Productos.EliminarProductos(id);
        }
    }
}
