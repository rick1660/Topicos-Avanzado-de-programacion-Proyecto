using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto.Data
{
    class Helpers
    {
        public List<List<string>> LecturaDatos(string ruta) 
        {
            List<List<string>> resultado = new List<List<string>>();
      
            using (var reader = new StreamReader(@ruta ))
            {
                while (!reader.EndOfStream)
                {
                    List<string> Datos = new List<string>();
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    Datos.AddRange(values.ToList());
                    resultado.Add(Datos);

                }
            }
            return resultado;
        }

        //T representa cualquier objeto..
       // public static T GetItem


        
    }
}
