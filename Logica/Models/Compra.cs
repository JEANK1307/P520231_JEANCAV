using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Compra
    {
        //Propiedades
        public int CompraID { get; set; }
        public DateTime CompraFecha { get; set; }
        public int CompraNumero { get; set; }
        public string CompraNotas { get;}
        public bool Activo { get; set; }


        //Composiciones simples

        public Usuario MiUsuario { get; set; }
        public Proveedor MiProveedor { get; set; }
        public TipoCompra MiTipoCompra { get; set; }  
        
        //Composiciones en lista o complejas

        public List<CompraDetalle> ListaDetalles { get; set; }

        //Constructor
        public Compra() 
        {
            MiUsuario = new Usuario();
            MiProveedor = new Proveedor();
            MiTipoCompra = new TipoCompra();
            ListaDetalles = new List<CompraDetalle>();
        }
    }
}
