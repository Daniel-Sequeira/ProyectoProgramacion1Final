using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; //Libreria que nos permite mediante expresiones regulares validar ciertos datos ingresados por el usuario

namespace ProyectoFinalProgra1
{
   public class Validaciones
    {
        public static bool ValidarCedula(string cedula) //Metodo para verificar el formato correcto de la cedula y el ID
        {
            string patron = @"^\d{9}$";
            return Regex.IsMatch(cedula, patron);
        }

        public static bool ValidarCorreo(string correo) //Metodo para verificar el formato correcto del correo
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(correo, patron);
        }

        public static bool CamposVacios(string input) //Este metodo utiliza la funcion IsNullOrWhite para verificar que los espacios no se encuentren vacios
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        public static bool CedulaIdIguales(string cedula, string id) //Este metodo es el responsable de verificar que el ID y la cedula coincidan
        {
            return cedula == id;
        }





    }  

    
}



    



