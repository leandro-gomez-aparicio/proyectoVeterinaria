using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Mascota
    {
        public int CodMascota {get; set;}
        public string Nombre { get; set;}  
        public int Edad {get; set;}
        public int TipoMascota { get; set;}

        public List<Atencion> ListaAtencion { get; set;}
        public Mascota(int codMascota, string nombre, int edad, int tipoMascota) 
        {
            CodMascota = codMascota;
            Nombre = nombre;
            Edad = edad;
            TipoMascota = tipoMascota;
        }
        public Mascota() 
        {
            ListaAtencion = new List<Atencion>();
        }
        public void AgregarAtencion(Atencion atencion)
        {
            ListaAtencion.Add(atencion);
        }

        public void QuitarAtencion(int indice)
        {
            ListaAtencion.RemoveAt(indice);
        }
    }
}
