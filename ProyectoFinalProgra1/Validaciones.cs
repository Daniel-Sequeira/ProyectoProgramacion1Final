using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProyectoFinalProgra1
{
   public class Validaciones
    {
        public static bool ValidarCedula(string cedula)
        {
            string patron = @"^\d{9}$";
            return Regex.IsMatch(cedula, patron);
        }

        public static bool ValidarCorreo(string correo)
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool CamposVacios(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static bool CedulaIdIguales(string cedula, string id)
        {
            return cedula == id;
        }





    }  

    
}



    



