using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Atencion
    {
        public int CodAtencion { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Importe { get; set; }

        public Atencion(int codigo, DateTime fecha,string descripcion, double importe) 
        {
            CodAtencion = codigo;
            Fecha = fecha;
            Descripcion = descripcion;
            Importe = importe;
        }
        public override string ToString() 
        {
            return Descripcion;
        }
    }
}
