using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.interfaces;

namespace POO.Models
{
    
    //Creacion de la clase principal Ave
    class Ave:Accion,IAve{

        
        //Cuando se trabaja con interfaces, se debe de usar el get y set si o si en cada uno de los componentes o aplicar encapsulamiento
        public int IdAve {get; set;}
        //Con el encapsulamiento se está definiendo una clase privada que se define como la informacion que se muestra al usuario
        private string _Nombre;
        //Al definir la clase privada, se debe de definir una clase publica que servira como el editor para la clase protegida
        public string Nombre{
            get{
                return _Nombre;
            }
            set{
                _Nombre= value.Trim(); //El Trim(); sirve para eliminar los espacios en blanco de los strings
            }
        }
        public string DescripcionAve {get;set;}
        public bool PuedeVolar;
        //Se enlaza la clase de los habitats como una lista para la clase Ave
        public List<Habitat> Habitats;

        //Esta es una variable de solo lectura, ya que solamente posee el get y no el set, por lo que no es modificable
        public string HabitatYDescripcion{
            get{
                return $"{Nombre} y {DescripcionAve}";
            }
        }

        //CONSTRUCTOR
        public Ave(){
            //Todas las propiedades dentro del constructor son valores por defecto que se inician al momento de crear el objeto
            IdAve = 1;
            //Se define la lista dentro del constructor ya que la lista puede no tener valores o no inicializarse
            Habitats = new List<Habitat>();
            PuedeVolar=false;
        }

        //Metodo para la clase Ave
        public string MostrarInformacion(){
            string Mensaje = "";

            if(PuedeVolar == false){
                Mensaje="El ave no es capaz de volar";
            }
            else
            Mensaje="El ave es capaz de volar";

            //StringBuilder es una clase que se usa para concatenar strings y mostrarlos en pantalla
            StringBuilder sb = new StringBuilder();
            //Metodo para recorre toda la lista de habitas
            foreach(var item in Habitats){
                sb.AppendLine($"{Nombre} es {DescripcionAve}. {Mensaje} y habita en {item.Continente}");
            }
            return sb.ToString();
        }

        //Definicion del metodo abstracto
        public override string Actuar()
        {
            return "El Ave ha Volado";
        }

        //Se hace implementacion del polimorfismo, ya que elegir si cambiar, o no, el metodo heredado de la clase padre
        public override string Actuar2(){
            return base.Actuar2();
        }

        //Prueba para la muestra de informacion de interfaz
        
    }
}
