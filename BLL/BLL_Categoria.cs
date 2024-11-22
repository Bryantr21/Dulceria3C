using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using VO;

namespace BLL
{
    public class BLL_Categoria
    {
        public static List<Categoria_VO> GetCategorias(params object[] parametros)
        {
            return DAL_Categoria.GetCategorias(parametros);
        }
        //crear 
        public static string InsertarCategoria(Categoria_VO categoria)
        {
            return DAL_Categoria.InsertarCategoria(categoria);
        }
        //actualizar
        public static string ActualizarCategoria(Categoria_VO categoria)
        {
            return DAL_Categoria.ActualizarCategoria(categoria);
        }
        //delete
        public static string Eliminarcategoria(int id)
        {
            return DAL_Categoria.Eliminarcategoria(id);
        }
    }
}
