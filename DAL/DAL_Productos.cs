using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Productos
    {
        public static string InsertarProductos(Productos_VO productos)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Productos",
                    
                     "@Nombre", productos.Nombre,
                     "@Precio", productos.Precio,
                     "@Marca", productos.Marca,
                     "@Cantidad", productos.Cantidad,
                     "@Caducidad", productos.Caducidad,
                     "@Categoria_Id", productos.Categoria_Id
                );
                salida = (respuesta != 0) ? "Productos registrada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarProductos(Productos_VO productos)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Productos",
                    "@Nombre", productos.Nombre,
                     "@Precio", productos.Precio,
                     "@Marca", productos.Marca,
                     "@Cantidad", productos.Cantidad,
                     "@Caducidad", productos.Caducidad,
                     "@Categoria_Id", productos.Categoria_Id,
                     "@Id_producto", productos.Id_producto
                );
                salida = (respuesta != 0) ? "Productos actualizados" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Productos_VO> GetProductos(params object[] parametros)
        {
            List<Productos_VO> list = new List<Productos_VO>();
            try
            {
                DataSet ds_productos = metodos_datos.execute_DataSet("Sp_Listar_Productos", parametros);
                foreach (DataRow dr in ds_productos.Tables[0].Rows)
                {
                    list.Add(new Productos_VO(dr));
                }
                return list;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        //Actualizar

        //Delete
        public static string EliminarProductos(int Id_producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Productos", "@Id_producto", Id_producto);
                salida = (respuesta != 0) ? "Producto eliminado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
