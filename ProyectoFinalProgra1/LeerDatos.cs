using System;
using System.Collections.Generic;
using System.IO;


namespace ProyectoFinalProgra1
{
    
    public class LeerDatos
    {
        private string path; //Campo de la clase.
        private List<string> datos; //Declaración Lista datos

        /// <summary>
        /// Constructor de la clase asisgna valores a path.
        /// </summary>
        /// <param name="pathEmp"></param>
        /// <param name="pathPlan"></param>
        public LeerDatos(string pathEmp,string pathPlan)
        {
            path = pathEmp;
            path = pathPlan;

        }

        /// <summary>
        /// Metodo lee Archivos.txt y retorna lista, este codigo se reutiiza de acuerdo al parametro path enviado.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<string> LeerArchivo(string path)
        {

            using (StreamReader sr = new StreamReader(path))
            {
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


            public void CrearArchivoTodos(string path)
            {
               using (StreamWriter swf = File.CreateText(path))
               {
                     swf.WriteLine("hola");

                     swf.Close();

               }
            }


        public void BuscarSalarioID()
        {
            Console.WriteLine("Ingrese el número de cédula ");
          


            
        }



    }
}
