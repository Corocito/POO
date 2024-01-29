using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models
{
    //Si se definen metodos abstractos dentro de la clase, la clase es si debe de ser abstracta
    public abstract class Accion
    {

        //Dentro de una clase abstracta tambien se pueden crear propiedades y metodos abstractos y normales
        //Se define el meetodo abstracto sin ninguna funcion
        public abstract string Actuar();

        //Se define un metodo con polimorfismo al hacer uso de la palabra virtual
        public virtual string Actuar2(){
            return "El ave hace algo";
        }
    }
}