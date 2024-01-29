//Los constructores se utilizan para manejar la asignacion de variables a las clases de una forma mas efectiva
//Creación de los HABITATS
using POO;
using POO.Models;

//Se instancia una variable que almacena la clase ImprimirInfo
var imprimir = new ImprimirInfo();


Habitat habitat1 = new Habitat();
habitat1.IdHabitat=1;
habitat1.Continente="Norte America";
habitat1.DescripcionHabitat="Tierra con ambientes frios y distintas estaciones a lo largo del año";

Habitat habitat2 = new Habitat();
habitat2.IdHabitat=2;
habitat2.Continente="Sur America";
habitat2.DescripcionHabitat="Tierra templada generalmente calurosa";

Habitat habitat3 = new Habitat();
habitat3.IdHabitat=3;
habitat3.Continente="Europa";
habitat3.DescripcionHabitat="Tierra con un clima variado";

Habitat habitat4= new Habitat();
habitat4.IdHabitat=4;
habitat4.Continente="Asia";
habitat4.DescripcionHabitat="Tierra con un clima variado. Bastante caluroso en algunas zonas y bastante frio en otra";

Habitat habitat5 = new Habitat();
habitat5.IdHabitat=5;
habitat5.Continente="Oceania";
habitat5.DescripcionHabitat="Tierra con un clima generalmente caluroso y bastante hostil debido a la cantidad de animales salvajes presentes";

Habitat habitat6 = new Habitat();
habitat6.IdHabitat=6;
habitat6.Continente="Africa";
habitat6.DescripcionHabitat="Tierra bastante calurosa y peligrosa";

Habitat habitat7 = new Habitat();
habitat7.IdHabitat= 7;
habitat7.Continente="Antartida";
habitat7.DescripcionHabitat="Tierra gelida. Pocos animales estan adaptados para vivir ahí";
Habitat habitat8 = new Habitat();
habitat8.IdHabitat = 8;
habitat8.Continente = "Centro America";
habitat8.DescripcionHabitat="Tierra templada";

Ave ave1 = new Ave();
ave1.Nombre="Gallina";
ave1.DescripcionAve="un ave domestica incapaz de volar que se usa principalmente para la producción de huevos para el consumo humano y por su carne";
List<Habitat> habitatsAve1 = new List<Habitat>();
habitatsAve1.Add(habitat1);
habitatsAve1.Add(habitat2);
habitatsAve1.Add(habitat3);
habitatsAve1.Add(habitat4);
habitatsAve1.Add(habitat5);
habitatsAve1.Add(habitat6);
habitatsAve1.Add(habitat7);
habitatsAve1.Add(habitat8);
//Despues de agregar toda la informacion a la lista, se debe de definir como valor o si no será contado como nulo
ave1.Habitats= habitatsAve1;
string mensajeInformacionAve = ave1.MostrarInformacion();
Console.WriteLine(mensajeInformacionAve);
string accion = ave1.Actuar();
Console.WriteLine(accion);
string accion2 = ave1.Actuar2();
Console.WriteLine(accion2);

imprimir.ImprimirInformacion(ave1);