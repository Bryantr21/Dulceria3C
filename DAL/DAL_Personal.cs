using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Personal
    {
        public static string InsertarPersonal(Personal_VO personal)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Personal",
                     "@Nombres", personal.Nombres,
                     "@Apellido_P", personal.Apellido_P,
                     "@Apellido_M", personal.Apellido_M,
                     "@Direccion", personal.Direccion,
                     "@Colonia", personal.Colonia,
                     "@Municipio_Delegacion", personal.Municipio_Delegacion,
                     "@Estado", personal.Estado,
                     "@CURP", personal.CURP,
                     "@Cel", personal.Cel,
                     "@Email", personal.Email,
                     "@Puesto", personal.Puesto
                );
                salida = (respuesta != 0) ? "Persona registrada" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarPersonal(Personal_VO personal)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Personal",
                    "@Nombres", personal.Nombres,
                     "@Apellido_P", personal.Apellido_P,
                     "@Apellido_M", personal.Apellido_M,
                     "@Direccion", personal.Direccion,
                     "@Colonia", personal.Colonia,
                     "@Municipio_Delegacion", personal.Municipio_Delegacion,
                     "@Estado", personal.Estado,
                     "@CURP", personal.CURP,
                     "@Cel", personal.Cel,
                     "@Email", personal.Email,
                     "@Puesto", personal.Puesto,
                     "@Id_Persona", personal.Id_Persona
                );
                salida = (respuesta != 0) ? "Personal actualizado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Personal_VO> GetPersonal(params object[] parametros)
        {
            List<Personal_VO> list = new List<Personal_VO>();
            try
            {
                DataSet ds_personal = metodos_datos.execute_DataSet("Sp_Listar_Personal", parametros);
                foreach (DataRow dr in ds_personal.Tables[0].Rows)
                {
                    list.Add(new Personal_VO(dr));
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
        public static string EliminarPersonal(int Id_Persona)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Personal ", "@Id_Persona", Id_Persona);
                salida = (respuesta != 0) ? "Personal eliminado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
