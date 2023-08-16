using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class EscribirDatos
    {
        private string pathEmp;
        private string pathPlan;
        public EscribirDatos(string pathEmp, string pathPlan)
        {
            this.pathEmp = pathEmp;
            this.pathPlan = pathPlan;
        }
       
        public void AgregarEmpleado(string cedula, string nombre, string email, string id, string profesion, double salarioHora, double horasTrabajadas, double rebajos)
        {
            string empleadoInfo = $"{cedula} || {nombre} || {email}";
            string planillaInfo = $"{id} || {profesion} || {salarioHora} || {horasTrabajadas} || {rebajos}";
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
