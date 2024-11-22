using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class Ventas_VO
    {
        private int _Id_venta;
        private int _Persona_Id;
        private int _Empresa_Id;
        private double _SubTotal;
        private double _Descuento;
        private double _Total;

        public int Id_venta { get => _Id_venta; set => _Id_venta = value; }
        public int Persona_Id { get => _Persona_Id; set => _Persona_Id = value; }
        public int Empresa_Id { get => _Empresa_Id; set => _Empresa_Id = value; }
        public double SubTotal { get => _SubTotal; set => _SubTotal = value; }
        public double Descuento { get => _Descuento; set => _Descuento = value; }
        public double Total { get => _Total; set => _Total = value; }

        public Ventas_VO()
        {
            _Id_venta = 0;
            _Persona_Id = 0;
            _Empresa_Id = 0;
            _SubTotal = 0;
            _Descuento = 0;
            _Total = 0;
        }
        public Ventas_VO(DataRow dataRow)
        {
            _Id_venta = int.Parse(dataRow["Id_venta"].ToString());
            _Persona_Id = int.Parse(dataRow["Persona_Id"].ToString());
            _Empresa_Id = int.Parse(dataRow["Empresa_Id"].ToString());
            _SubTotal = double.Parse(dataRow["SubTotal"].ToString());
            _Descuento = double.Parse(dataRow["Descuento"].ToString()); ;
            _Total = double.Parse(dataRow["Total"].ToString()); ;
        }
    }
}
