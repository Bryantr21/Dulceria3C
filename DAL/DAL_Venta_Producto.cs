using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Venta_Producto
    {
        public static string InsertarVentaProducto(Venta_Producto_VO venta_producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_VentaProducto",

                     "@Producto_Id", venta_producto.Producto_Id,
                     "@Venta_Id", venta_producto.Venta_Id
                );
                salida = (respuesta != 0) ? "Venta_Producto registrado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarVentaProducto(Venta_Producto_VO venta_producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_VentaProducto",
                    "@Producto_Id", venta_producto.Producto_Id,
                     "@Venta_Id", venta_producto.Venta_Id,
                     "@ID_Venta_Producto", venta_producto.ID_Venta_Producto
                );
                salida = (respuesta != 0) ? "Venta_Producto actualizados" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Venta_Producto_VO> GetVentaProducto(params object[] parametros)
        {
            List<Venta_Producto_VO> list = new List<Venta_Producto_VO>();
            try
            {
                DataSet ds_venta_producto = metodos_datos.execute_DataSet("Sp_Listar_VentaProducto", parametros);
                foreach (DataRow dr in ds_venta_producto.Tables[0].Rows)
                {
                    list.Add(new Venta_Producto_VO(dr));
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
        public static string EliminarVentaProducto(int ID_Venta_Producto)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_VentaProducto", "@ID_Venta_Producto", ID_Venta_Producto);
                salida = (respuesta != 0) ? "Venta_Producto eliminado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
