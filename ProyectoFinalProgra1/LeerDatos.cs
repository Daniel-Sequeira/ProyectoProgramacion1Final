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
        public LeerDatos(string pathEmp,string pathPlan, string pathTodos)
        {
            path = pathEmp;
            path = pathPlan;
            path = pathTodos;
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



        /// <summary>
        /// Metodo para generar un archivo segun path enviado por parámetro
        /// </summary>
        /// <param name="path"></param>
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
