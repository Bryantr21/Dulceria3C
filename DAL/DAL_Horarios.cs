using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAL
{
    public class DAL_Horarios
    {
        public static string InsertarHorarios(Horarios_VO horarios)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Insert_Horarios",
                     "@Empresa_Id", horarios.Empresa_Id,
                     "@Descripcion", horarios.Descripcion,
                     "@Horario_Inicio", horarios.Horario_Inicio,
                     "@Horario_fin", horarios.Horario_fin
                );
                salida = (respuesta != 0) ? "Horario registrado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static string ActualizarHorarios(Horarios_VO horarios)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Update_Horarios",
                    "@Empresa_Id", horarios.Empresa_Id,
                     "@Descripcion", horarios.Descripcion,
                     "@Horario_Inicio", horarios.Horario_Inicio,
                     "@Horario_fin", horarios.Horario_fin,
                     "@Id_Horario", horarios.Id_Horario
                );
                salida = (respuesta != 0) ? "Horario actualizado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
        public static List<Horarios_VO> GetHorarios(params object[] parametros)
        {
            List<Horarios_VO> list = new List<Horarios_VO>();
            try
            {
                DataSet ds_horarios = metodos_datos.execute_DataSet("Sp_Listar_Horarios", parametros);
                foreach (DataRow dr in ds_horarios.Tables[0].Rows)
                {
                    list.Add(new Horarios_VO(dr));
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
        public static string EliminarHorario(int Id_Horario)
        {
            string salida = "";
            int respuesta = 0;
            try
            {
                respuesta = metodos_datos.execute_nonQuery("Sp_Delete_Horarios", "@Id_Horario", Id_Horario);
                salida = (respuesta != 0) ? "Horario eliminado" : "ha ocurrido un error";

            }
            catch (Exception e)
            {
                salida = $"Error: {e.Message}";
            }
            return salida;
        }
    }
}
