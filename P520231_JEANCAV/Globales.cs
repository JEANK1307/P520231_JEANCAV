﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JEANCAV
{
    public static class Globales
    {
        //Estas propiedades al pertenecer a una clase static auto instancian
        //y se puede obtener acceso a ellas en la globalidad de la aplicación

        public static Form MiFormPrincipal = new Formularios.FrmMDI();

        public static Formularios.FrmUsuariosGestion MiFormGestionUsuarios = new Formularios.FrmUsuariosGestion();

        //Debemos tener un obj de tipo usuario que permita almacenar los datos del usuario
        //que se haya logueado correctamente
        public static Logica.Models.Usuario MiUsuarioGlobal = new Logica.Models.Usuario();

        public static Formularios.FrmRegistroCompra MiFormRegistroCompra = new Formularios.FrmRegistroCompra();

        public static Formularios.FrmProveedoresGestion MiFormProveedorGestion = new Formularios.FrmProveedoresGestion();


    }
}
