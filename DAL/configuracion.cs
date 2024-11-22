using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class configuracion
    {
        static string _cadenaConexion = @"Data Source =DESKTOP-NT2PUE0\SQLEXPRESS; Initial Catalog =Dulceriadb; Integrated Security = true;";
        public static string Cadenaconexion
        {
            get
            {
                return _cadenaConexion;
            }
        }

    }
}
