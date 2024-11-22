using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Categoria
    {
        public static string InsertarCategoria(Categoria_VO categoria)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Categorias",
                    "@Nombre", categoria.Nombre,
                    "@Descripcion", categoria.Descripcion
                );
                salida = (respuesta != 0) ? "categoria registrada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarCategoria(Categoria_VO categoria)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Categorias",
                    "@Nombre", categoria.Nombre,
                     "@Descripcion", categoria.Descripcion,
                     "@Id_Categoria", categoria.Id_Categoria
                );
                salida = (respuesta != 0) ? "categoria actualizada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Categoria_VO> GetCategorias(params object[] parametros)
        {
            List<Categoria_VO> list = new List<Categoria_VO>();
            try
            {
                DataSet ds_datos = metodos_datos.execute_DataSet("Sp_Listar_Categorias", parametros);
                foreach (DataRow dr in ds_datos.Tables[0].Rows)
                {
                    list.Add(new Categoria_VO(dr));
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
        public static string Eliminarcategoria(int Id_Categoria)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Categorias", "@Id_Categoria", Id_Categoria);
                salida = (respuesta != 0) ? "categoria eliminada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
