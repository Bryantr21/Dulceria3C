using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Empresa
    {
        public static List<Empresa_VO> GetEmpresa(params object[] parametros)
        {
            return DAL_Empresa.GetEmpresa(parametros);
        }
        //crear 
        public static string InsertarEmpresa(Empresa_VO empresa)
        {
            return DAL_Empresa.InsertarEmpresa(empresa);
        }
        //actualizar
        public static string ActualizarEmpresa(Empresa_VO empresa)
        {
            return DAL_Empresa.ActualizarEmpresa(empresa);
        }
        //delete
        public static string EliminarEmpresa(int id)
        {
            return DAL_Empresa.EliminarEmpresa(id);
        }
    }
}
