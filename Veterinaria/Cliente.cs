﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public bool Sexo { get; set; }  
        public int Codigo { get; set; }
        public List<Mascota> ListMascotas { get; set; }
        public Cliente() 
        {
            ListMascotas = new List<Mascota>();
        }
        public void AgregarMascota(Mascota mascota)
        {
            ListMascotas.Add(mascota);
        }
        public void QuitarMascota(int indice)
        {
            ListMascotas.RemoveAt(indice);
        }
    }
}
