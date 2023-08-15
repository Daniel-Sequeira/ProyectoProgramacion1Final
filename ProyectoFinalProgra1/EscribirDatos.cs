using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class EscribirDatos
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private string __path;
        public EscribirDatos(string path)
=======
        private string _pathEmp; //Campo de la clase 
        private string _pathPlan;


        private List<string> info;//Lista que contiene datos mixtos de ambos txt

=======
>>>>>>> ramaDaniel1
            public static void AgregarEmpleado()
>>>>>>> ramaDaniel1
        {
            __path = path;
        }

        public void AgregarEmpleado(string nombre, double salario)
        {
            using (StreamWriter sw = new StreamWriter(__path, true))
            {
                sw.WriteLine("Nombre: +" + nombre + " - Salario: " + salario);
                sw.Close();
            }

        }



    }
}
