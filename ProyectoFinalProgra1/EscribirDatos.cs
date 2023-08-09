using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class EscribirDatos
    {
        private string __path;
        public EscribirDatos(string path)
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
