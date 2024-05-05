﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   public class Cliente : Usuario
    {
        public Cliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña, string telefono) : base(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña)
        {

            this.Telefono = telefono;
        }

        public string Telefono { get; set; }    
    }
}
