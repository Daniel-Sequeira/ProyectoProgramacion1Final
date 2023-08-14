using System;
using System.Collections.Generic;
using System.IO;


namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
        private string _pathEmp; //Campo de la clase 
        string cedula;
        
        private List<string> muestraTodos = new List<string> (); //Instancia Lista Todos

        /// <summary>
        /// Constructor de la clase recibe como parametro la ruta del archivo Empleados.txt
        /// </summary>
        /// <param name="pathEmp"></param>
        public LeerDatos(string pathEmp) 
        {
            _pathEmp = pathEmp;
            
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerTodos()
        {
            
            using (StreamReader sr = new StreamReader(_pathEmp))
            {
                if (File.Exists(_pathEmp))
                {
                    sr.ReadLine();
                    while (sr.EndOfStream != true)
                    {
                        muestraTodos.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                else
                    Console.WriteLine("Error No se encuentra el archivo Empleados.txt en la ruta establecida");
                return muestraTodos;
            }

        }

        public void BuscarSalarioID()
        {
            Console.WriteLine("Ingrese el número de cédula ");
            cedula = Console.ReadLine();
            
        }



    }
}
