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





    }  

    
<<<<<<< HEAD
<<<<<<< HEAD
}
=======



    }
>>>>>>> 00218cf6d6739a2f5c3a06dea51287960c0e0831
=======
}
>>>>>>> ramaDaniel1


