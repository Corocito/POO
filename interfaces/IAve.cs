using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.interfaces
{
    public interface IAve
    {
        int IdAve {get; set;}
        string Nombre{get;set;}
        string DescripcionAve{get; set;}

        void imprimirAve(){
            Console.WriteLine($"Identificación: {IdAve}, Nombre: {Nombre}, Descripcion: {DescripcionAve}");
        }
    }
}