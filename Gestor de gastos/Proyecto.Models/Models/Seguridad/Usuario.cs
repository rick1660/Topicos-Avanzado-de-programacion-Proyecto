﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Models.Models.Seguridad
{
   public class Usuario
    {
       public string NombreUsuario { get; set; }
       public string Password { get; set; }
    }   

    public class ListaUsuario 
    {
        List<Usuario> Usuarios;
    }
}
