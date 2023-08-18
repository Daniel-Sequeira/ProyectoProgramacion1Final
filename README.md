# ProyectoProgramacion1Final
## Descripción General_______________________________________________________________
Proyecto desarrollado en un entorno estudiantil universitario en el que se realiza creación lectura y escritura de archivos, mediante el uso de metodos especificos e implementacion de listas, tomando en cuenta validaciones en formato de entrada de datos 
por registrar, implementacion de estructuras condicionales, propiedades de listas, arreglos y variables.
## Requerimientos_____________________________________________________________
Proyecto desarrollado mediante aplicación en consola en lenguaje C#, con Visual Studio Community 2019, NetCore3.1
Aplicación en consola la cual puede ser ejecutada en visual studio, Net Core 3.1, no requiere instalación adicional al ser una aplicación en consola mas allá de los medios mencionados donde debe ejecutarse.
## Arquitectura del proyecto.

## Menu Principal
Mediante estructura condicional switch.
 
switch(opt)
{
                     
          case 1: 
                Código a ejecutar.
           break;
           
           case 2: 
               Código a ejecutar.
           break;
           default:
              Mensaje a mostrar si selecciona opciones fuera de las disponibles
            break;

  ## Uso de Listas  
  Importante el name space correcto para poder utilizar listas
  
    using System.Collections.Generic;
Declarar Lista

    List<int> miLista = new List<int>();
Agregar elementos a una lista.
    
    miLista.Add(10);
    miLista.Add(20);
    miLista.Add(30);
 Acceder a elemntos de la Lista

    int primerElemento = miLista[0]; // Devolverá 10
    int segundoElemento = miLista[1]; // Devolverá 20
  Obtener cantida de elemtos de una Lista
  
    int cantidadElementos = miLista.Count; // Devolverá 3
   Eliminar elementos
   
     miLista.Remove(20); // Eliminará el valor 20 de la lista
     miLista.RemoveAt(0); // Eliminará el primer elemento (10)




  
