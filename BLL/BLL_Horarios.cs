using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Horarios
    {
        public static List<Horarios_VO> GetHorarios(params object[] parametros)
        {
            return DAL_Horarios.GetHorarios(parametros);
        }
        //crear 
        public static string InsertarHorarios(Horarios_VO camion)
        {
            return DAL_Horarios.InsertarHorarios(camion);
        }
        //actualizar
        public static string ActualizarHorarios(Horarios_VO camion)
        {
            return DAL_Horarios.ActualizarHorarios(camion);
        }
        //delete
        public static string EliminarHorario(int id)
        {
            return DAL_Horarios.EliminarHorario(id);
        }
    }
}
