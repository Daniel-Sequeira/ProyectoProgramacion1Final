using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
<<<<<<< HEAD

        private string _empleados; //Campo de la clase 
        List<string> listaEmpleados = new List<string>();

        public LeerDatos(string empleados) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
        {
            _empleados = empleados;
=======
        private string _pathEmp; //Campo de la clase 
        
        private List<string> muestraTodos = new List<string>();

        public LeerDatos(string pathEmp) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
        {
            _pathEmp = pathEmp;
            
>>>>>>> ramaDaniel1
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerTodos()
        {
<<<<<<< HEAD
            using (StreamReader sr = new StreamReader(_empleados))
            {
                while (sr.EndOfStream != true)
                {
                    listaEmpleados.Add(sr.ReadLine());  
=======
            using (StreamReader sr = new StreamReader(_pathEmp))
            {
                while (sr.EndOfStream != true)
                {
                    muestraTodos.Add(sr.ReadLine());  
>>>>>>> ramaDaniel1
                }

                sr.Close();
            }
<<<<<<< HEAD
            return listaEmpleados;
=======

            return muestraTodos;

          
            
      
>>>>>>> ramaDaniel1
        }






        
    }
}
