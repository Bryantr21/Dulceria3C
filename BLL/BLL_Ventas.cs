using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Ventas
    {
        public static List<Ventas_VO> GetVentas(params object[] parametros)
        {
            return DAL_Ventas.GetVentas(parametros);
        }
        //crear 
        public static string InsertarVentas(Ventas_VO ventas)
        {
            return DAL_Ventas.InsertarVentas(ventas);
        }
        //actualizar
        public static string ActualizarVentas(Ventas_VO ventas)
        {
            return DAL_Ventas.ActualizarVentas(ventas);
        }
        //delete
        public static string EliminarVentas(int id)
        {
            return DAL_Ventas.EliminarVentas(id);
        }
    }
}
