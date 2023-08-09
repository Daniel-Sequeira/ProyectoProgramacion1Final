using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
        private string _path; //Campo de la clase 
        private List<string> listaempleados = new List<string>();

        public LeerDatos(string path) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
        {
            _path = path;
        }

        /// <summary>
        /// Metodo lee Empleados.txt y retorna lista
        /// </summary>
        /// <returns></returns>
        public List<string> LeerEmpleados()
        {
            using (StreamReader sr = new StreamReader(_path))
            {
                while (sr.EndOfStream != true)
                {
                    listaempleados.Add(sr.ReadLine());  
                }
                sr.Close();
            }
            return listaempleados;
        }






        
    }
}
