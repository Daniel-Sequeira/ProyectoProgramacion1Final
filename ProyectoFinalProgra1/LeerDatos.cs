using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class LeerDatos
    {
        private string empleados_txt; //Campo de la clase 

        public LeerDatos(string empleadostxt) //Constructor de la clase que recibe como parametro la variable que contiene la ruta de Empleados.txt
        {
            empleados_txt = empleadostxt;
        }

        public void LeerEmpleados()
        {
            using (StreamReader sr = new StreamReader(empleados_txt))
            {
                while (sr.EndOfStream != true)
                {
                    
                }
                sr.Close();
            }
        }






        
    }
}
