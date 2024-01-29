using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO.interfaces;

namespace POO
{
    public class ImprimirInfo
    {
        //IAve i = new ImprimirInfo();
        public void ImprimirInformacion(IAve ave){
            Console.WriteLine($"ID:{ave.IdAve}");
            Console.WriteLine($"Nombre:{ave.Nombre}");
            Console.WriteLine($"Descripción: {ave.DescripcionAve}");
        }
    }
}