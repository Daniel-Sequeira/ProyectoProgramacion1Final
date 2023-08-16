using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    
    public class EscribirDatos
    {
       
        public void AgregarEmpleado(string nombre, double salario)
        {
            using (StreamWriter sw = new StreamWriter(nombre ))
            {
                sw.WriteLine("Nombre: +" + nombre + " - Salario: " + salario);
                sw.Close();
            } 

        }

   



    }
}
