﻿using DLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClsServicioCliente
    {
        public ClsServicioCliente()
        {

        }
        public static string RegistroCliente(string tipoDocumento, string numeroDocumento, string nombre, string apellido, string nombreUsuario, string contraseña)
        {
            Cliente cliente = new ClsCliente(tipoDocumento, numeroDocumento, nombre, apellido, nombreUsuario, contraseña);

        }
        public static DataTable RegistroCliente(Cliente cliente)
        {
            DataTable datosClientes = new DataTable();

        }



    
    }
}
