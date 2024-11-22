using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Ventas
    {
        public static string InsertarVentas(Ventas_VO ventas)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Ventas",
                     "@Persona_Id", ventas.Persona_Id,
                     "@Empresa_Id", ventas.Empresa_Id,
                     "@SubTotal", ventas.SubTotal,
                     "@Descuento", ventas.Descuento,
                     "@Total", ventas.Total
                );
                salida = (respuesta != 0) ? "Venta registrada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarVentas(Ventas_VO ventas)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Ventas",
                     "@Persona_Id", ventas.Persona_Id,
                     "@Empresa_Id", ventas.Empresa_Id,
                     "@SubTotal", ventas.SubTotal,
                     "@Descuento", ventas.Descuento,
                     "@Total", ventas.Total,
                     "@Id_venta", ventas.Id_venta
                );
                salida = (respuesta != 0) ? "Ventas actualizada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Ventas_VO> GetVentas(params object[] parametros)
        {
            List<Ventas_VO> list = new List<Ventas_VO>();
            try
            {
                DataSet ds_ventas = metodos_datos.execute_DataSet("Sp_Listar_Ventas", parametros);
                foreach (DataRow dr in ds_ventas.Tables[0].Rows)
                {
                    list.Add(new Ventas_VO(dr));
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
        public static string EliminarVentas(int Id_Venta)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Ventas", "@Id_Venta", Id_Venta);
                salida = (respuesta != 0) ? "Venta eliminada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
