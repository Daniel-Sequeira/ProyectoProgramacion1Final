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

   #  Metodo de Lectura de Archivos

    public List<string> LeerArchivo(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
                datos = new List<string>();
                if (File.Exists(path))
                {
                    sr.ReadLine();
                    while (sr.EndOfStream != true)
                    {
                        datos.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                else
                    Console.WriteLine("Error No se encuentra el archivo txt en la ruta establecida");
                return datos;
            }

        }
# Explicacion:
## public List<string> LeerArchivo(string path)
   - Este es el encabezado del método. Indica que el método es público (puede ser accedido desde fuera de la clase), devuelve una lista de cadenas (`List<string>`), y toma un parámetro llamado `path` de tipo cadena (string), que representa la ruta del archivo que se debe leer.
## using (StreamReader sr = new StreamReader(path))
  - Utiliza un bloque `using` para garantizar que el recurso `StreamReader` se maneje adecuadamente y se libere después de su uso. `StreamReader` se utiliza para leer el contenido del archivo. Se crea una nueva instancia de `StreamReader` llamada `sr`, que se inicializa con el archivo cuya ruta es proporcionada como argumento pathEmp o pathPlan o segun corresponda.
## datos = new List<string>();
  -Instancia de una lista de cadenas llamada `datos`. Esta lista se utilizará para almacenar las líneas del archivo.
## if (File.Exists(path))
  - Se verifica si el archivo especificado en la ruta existe en el sistema de archivos.
## sr.ReadLine();
Se lee y se descarta la primera línea del archivo. (El encabezado).
## while (sr.EndOfStream != true)
 -Bucle `while` que se ejecutará mientras no se haya llegado al final del archivo
## datos.Add(sr.ReadLine());
- Dentro del bucle, se lee una línea del archivo usando `sr.ReadLine()` y se agrega a la lista `datos`.
## sr.Close();
  Se ha llegado al final del archivo, se cierra el `StreamReader` para liberar los recursos.
## else Console.WriteLine("Error No se encuentra el archivo txt en la ruta establecida");
   - Si el archivo no existe en la ruta proporcionada, se imprime un mensaje de error en la consola.
##  return datos;
  - Finalmente, se devuelve la lista `datos` que contiene todas las líneas del archivo.

# Metodo Crear Archivo 

    public void CrearArchivo(string path,List<string>datosP)
              {
                 using (StreamWriter swf = File.CreateText(path))
                 {
                   foreach (var dato in datosP)
                   {
                      swf.WriteLine(dato);
                   }
                      swf.Close();
                 }
              }
  
      }
  }

  # Explicacion
  ## public void CrearArchivo(string path, List<string> datosP)
  El método toma dos argumentos: path, que es la ruta donde se creará el archivo, y datosP, que es una lista de cadenas que contiene los datos que se escribirán en el archivo.
  ## using (StreamWriter swf = File.CreateText(path))
  Bloque using para asegurarse de que el recurso StreamWriter se maneje adecuadamente y se libere después de su uso. StreamWriter se usa para escribir en el archivo. Se crea una nueva instancia de StreamWriter llamada swf, y se crea un nuevo archivo de      texto en la ruta especificada (path).
  ## foreach (var dato in datosP)
  Bucle foreach que recorre cada elemento de la lista datosP. En cada iteración, la variable dato toma el valor de uno de los elementos de la lista.
  ## swf.WriteLine(dato);
  Dentro del bucle, se escribe la cadena actual (dato) en una nueva línea del archivo utilizando el método WriteLine del StreamWriter.
  ## swf.Close();
  cierra para liberar recurso.

  # Validaciónes mediante expresiones regulares (ej. validar una cédula)

    public static bool ValidarCedula(string cedula) //Metodo para verificar el formato correcto de la cedula y el ID
         {
             string patron = @"^\d{9}$";
             return Regex.IsMatch(cedula, patron);
         }

Toma la cadena cedula como entrada y devuelve un valor booleano (true o false) que indica si la cadena cumple con el formato esperado.
Utiliza una expresión regular (@"^\d{9}$") para verificar que la cédula contiene exactamente en nueve dígitos (\d representa un dígito y {9} indica que debe haber nueve de ellos).
La función Regex.IsMatch verifica si la cadena cedula coincide con este patrón.

    public static bool ValidarCorreo(string correo) //Metodo para verificar el formato correcto del correo
            {
                string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
                return Regex.IsMatch(correo, patron);
            }
Como en el caso anterior recibe la variable string por parámetro y ejecuta la evaluacion de la misma con
la expresión regular (@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") que  verifica que el correo electrónico tenga un formato típico
(usuario, una arroba, un dominio y un sufijo). 
La función Regex.IsMatch verifica si la cadena correo coincide con este patrón.


















  
