using System;
using System.Collections.Generic;
using System.IO;


namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
        private string _pathEmp; //Campo de la clase 
        private string _pathPlan;
        string cedula;
        
        private List<string> datosEmp = new List<string> (); //Instancia Lista Todos
        private List<string> datosPlan = new List<string>();

        /// <summary>
        /// Constructor de la clase recibe como parametro la ruta del archivo Empleados.txt y Planilla.txt
        /// </summary>
        /// <param name="pathEmp"></param>
        /// <param name="pathPlan"></param>
        public LeerDatos(string pathEmp, string pathPlan) 
        {
            _pathEmp = pathEmp;
            _pathPlan = pathPlan;
            
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerEmpleados()
        {
            
            using (StreamReader sr = new StreamReader(_pathEmp))
            {
                if (File.Exists(_pathEmp))
                {
                    sr.ReadLine();
                    while (sr.EndOfStream != true)
                    {
                        datosEmp.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                else
                    Console.WriteLine("Error No se encuentra el archivo Empleados.txt en la ruta establecida");
                return datosEmp;
            }

        }
        /// <summary>
        /// Metodo de lectura de Planilla.txt que retorna una lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerPlanilla()
        {

            using (StreamReader sr = new StreamReader(_pathPlan))
            {
                if (File.Exists(_pathPlan))
                {
                    sr.ReadLine();
                    while (sr.EndOfStream != true)
                    {
                        datosPlan.Add(sr.ReadLine());
                    }
                    sr.Close();
                }
                else
                    Console.WriteLine("Error No se encuentra el archivo Planilla.txt en la ruta establecida");
                return datosPlan;
            }

        }


        public void BuscarSalarioID()
        {
            Console.WriteLine("Ingrese el número de cédula ");
            cedula = Console.ReadLine();


            
        }



    }
}
