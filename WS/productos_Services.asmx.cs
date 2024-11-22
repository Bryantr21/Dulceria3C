using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BLL;
using VO;

namespace Dulceria3C.WS
{
    /// <summary>
    /// Descripción breve de productos_Services
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class productos_Services : System.Web.Services.WebService
    {

        [WebMethod]
        public List<Productos_VO> GetProductos(params object[] parametros)
        {
            return BLL_Productos.GetProductos(parametros);
        }
    }
}
