using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
