using System;
using System.Collections.Generic;
using System.IO;


namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
<<<<<<< HEAD

        private string empleados_txt; //Campo de la clase 
        private string _path; //Campo de la clase 
        private List<string> listaempleados = new List<string>();

        public LeerDatos(string path) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
=======
        private string _pathEmp; //Campo de la clase 
        string cedula;
        
        private List<string> muestraTodos = new List<string> ();

        public LeerDatos(string pathEmp) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
>>>>>>> dcbc288030e19ad7588c224bfdd1ae77b1fbe530
        {
            _pathEmp = pathEmp;
            
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public void LeerTodos()
        {
            using (StreamReader sr = new StreamReader(_pathEmp))
            {
                while (sr.EndOfStream != true)
                {
                    muestraTodos.Add(sr.ReadLine());
                }
                  
                foreach (var todos in muestraTodos)
                {
                  Console.WriteLine(todos);     
                }
              
                 sr.Close();
            }

        }

        public void BuscarSalarioID()
        {
            Console.WriteLine("Ingrese el número de cédula ");
            cedula = Console.ReadLine();
            
        }



    }
}
