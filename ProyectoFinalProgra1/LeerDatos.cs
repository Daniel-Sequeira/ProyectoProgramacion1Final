using System;
using System.Collections.Generic;
using System.IO;


namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
        private string _pathEmp; //Campo de la clase 
        
        private List<string> muestraTodos = new List<string> ();

        public LeerDatos(string pathEmp) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
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
        }



    }
}
