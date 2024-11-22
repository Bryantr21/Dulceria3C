using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Horarios_VO
    {
        private int _Id_Horario;
        private int _Empresa_Id;
        private string _Descripcion;
        private string _Horario_Inicio;
        private string _Horario_fin;

        public int Id_Horario { get => _Id_Horario; set => _Id_Horario = value; }
        public int Empresa_Id { get => _Empresa_Id; set => _Empresa_Id = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Horario_Inicio { get => _Horario_Inicio; set => _Horario_Inicio = value; }
        public string Horario_fin { get => _Horario_fin; set => _Horario_fin = value; }

        public Horarios_VO()
        {
            _Id_Horario = 0;
            _Empresa_Id = 0;
            _Descripcion = "";
            _Horario_Inicio = "";
            _Horario_fin = "";

        }
        public Horarios_VO(DataRow dataRow)
        {
            _Id_Horario = int.Parse(dataRow["Id_Horario"].ToString());
            _Empresa_Id = int.Parse(dataRow["Empresa_Id"].ToString());
            _Descripcion = dataRow["Descripcion"].ToString();
            _Horario_Inicio = dataRow["Horario_Inicio"].ToString();
            _Horario_fin = dataRow["Horario_fin"].ToString();
        }
    }
}
