using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Empresa
    {
        public static string InsertarEmpresa(Empresa_VO empresa)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Empresas",
                     "@Nombre", empresa.Nombre,
                     "@Direccion", empresa.Direccion,
                     "@Colonia", empresa.Colonia,
                     "@Municipio_Delegacion", empresa.Municipio_Delegacion,
                     "@Estado", empresa.Estado,
                     "@Email", empresa.Email,
                     "@Cel", empresa.Cel,
                     "@Descripcion", empresa.Descripcion
                );
                salida = (respuesta != 0) ? "Empresa registrada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarEmpresa(Empresa_VO empresa)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Empresas",
                    "@Nombre", empresa.Nombre,
                     "@Direccion", empresa.Direccion,
                     "@Colonia", empresa.Colonia,
                     "@Municipio_Delegacion", empresa.Municipio_Delegacion,
                     "@Estado", empresa.Estado,
                     "@Email", empresa.Email,
                     "@Cel", empresa.Cel,
                     "@Descripcion", empresa.Descripcion,
                     "@Id_Empresa", empresa.Id_Empresa
                );
                salida = (respuesta != 0) ? "Empresa actualizada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Empresa_VO> GetEmpresa(params object[] parametros)
        {
            List<Empresa_VO> list = new List<Empresa_VO>();
            try
            {
                DataSet ds_empresas = metodos_datos.execute_DataSet("Sp_Listar_Empresas", parametros);
                foreach (DataRow dr in ds_empresas.Tables[0].Rows)
                {
                    list.Add(new Empresa_VO(dr));
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
        public static string EliminarEmpresa(int Id_Empresa)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Empresas", "@Id_Empresa", Id_Empresa);
                salida = (respuesta != 0) ? "Empresa eliminada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
