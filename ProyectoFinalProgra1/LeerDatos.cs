using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {

        private string _empleados; //Campo de la clase 
        List<string> listaEmpleados = new List<string>();

        public LeerDatos(string empleados) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
        {
            _empleados = empleados;
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerEmpleados()
        {
            using (StreamReader sr = new StreamReader(_empleados))
            {
                while (sr.EndOfStream != true)
                {
                    listaEmpleados.Add(sr.ReadLine());  
                }
                sr.Close();
            }
            return listaEmpleados;
        }






        
    }
}
