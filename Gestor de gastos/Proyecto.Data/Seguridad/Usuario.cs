using Proyecto.Models.Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Proyecto.Data.Seguridad
{
   public class DataUsuario
    {
        public Usuario getLogin(string Usuario, string password) 
        {

            string [] Arreglo = new string[0];

            Usuario user = new Usuario();
           //List<string> valores = new List<string>();
           
            List<Usuario> usuario = new List<Usuario>();
            Helpers helpers = new Helpers();
           var resultadoLectura = helpers.LecturaDatos(@"C:\Users\Rick\Documents\GitHub\Topicos-Avanzado-de-programacion-Proyecto\Gestor de gastos\Proyecto.Data\Datos\usuarios.csv"); 
            foreach (List<string> elemento in resultadoLectura)
            {
                if (elemento[0].ToString().ToUpper() == Usuario.ToString().ToUpper() && elemento[1] == password)
                {
                    user = new Usuario() { NombreUsuario = elemento[0], Password = elemento[1] };
                    break;
                }
            }

    
          
            return user;
        }
    }
}
