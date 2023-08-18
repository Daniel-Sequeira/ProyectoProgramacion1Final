using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    
    public class EscribirDatos
    {
        private string pathEmp; //Campos de la clase
        private string pathPlan;


        /// <summary>
        /// Constructor de la clase que asigna los valores de path
        /// </summary>
        /// <param name="pathEmp"></param>
        /// <param name="pathPlan"></param>
        public EscribirDatos(string pathEmp, string pathPlan)
        {
            this.pathEmp = pathEmp;
            this.pathPlan = pathPlan;
        }
       
        /// <summary>
        /// Metodo que escribe nuevos datos a un archivo, en este caso algunos datos son enviados a el archivo empleados y otros a planilla dependiendo de su parametro
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="id"></param>
        /// <param name="profesion"></param>
        /// <param name="salarioHora"></param>
        /// <param name="horasTrabajadas"></param>
        /// <param name="rebajos"></param>
        public void AgregarEmpleado(string cedula, string nombre, string email, string id, string profesion, double salarioHora, double horasTrabajadas, double rebajos)
        {
            string empleadoInfo = $"\n{cedula} {nombre} {email}";
            string planillaInfo = $"\n{id} {profesion} {salarioHora} {horasTrabajadas} {rebajos}%";
            using (StreamWriter swEmp = new StreamWriter(pathEmp, true))
            {
                swEmp.WriteLine(empleadoInfo);
            }
            using (StreamWriter swPlan = new StreamWriter(pathPlan, true))
            {
                swPlan.WriteLine(planillaInfo);
            }

        }
    }
}
