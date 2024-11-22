using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Personal
    {
        public static List<Personal_VO> GetPersonal(params object[] parametros)
        {
            return DAL_Personal.GetPersonal(parametros);
        }
        //crear 
        public static string InsertarPersonal(Personal_VO personal)
        {
            return DAL_Personal.InsertarPersonal(personal);
        }
        //actualizar
        public static string ActualizarPersonal(Personal_VO personal)
        {
            return DAL_Personal.ActualizarPersonal(personal);
        }
        //delete
        public static string EliminarPersonal(int id)
        {
            return DAL_Personal.EliminarPersonal(id);
        }
    }
}
