using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {

        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorEmail { get; set; }
        public string ProveedorDireccion { get; set; }
        public string ProveedorNotas { get; set; }
        public bool Activo { get; set; }

        public int ProveedorTipoID { get; set; }

        public Proveedor()
        {
        }

        public bool Agregar() 
        {
            bool R = false;
            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@Correo", this.ProveedorEmail));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Nombre", this.ProveedorNombre));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Notas", this.ProveedorNotas));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Direccion", this.ProveedorDireccion));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@IdTipo", this.ProveedorTipoID));
            int resultado = MiCnn.EjecutarInsertUpdateDelete("SPProveedorAgregar");
            if (resultado > 0)
            {
                R = true;
            }

            return R;
        }

        public bool Editar()
        {
            bool R = false;

            return R;
        }

        public bool Eliminar() 
        {
            bool R = false;

            return R;

        }

        public bool ConsultarPorCedula()
        {
            bool R = false;

            //paso 1.3.1 y 1.3.2
            Conexion MiCnn = new Conexion();

            //agregamos el parametro de cedula
            MiCnn.ListaDeParametros.Add(new SqlParameter("@Cedula", this.ProveedorCedula));

            DataTable consulta = new DataTable();
            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPConsultarProveedorPorCedula");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultarPorEmail()
        {
            bool R = false;

            return R;
        }

        public bool ConsultarPorID()
        {
            bool R = false;

            return R;
        }

        public DataTable Listar(bool verActivos = true, string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }

        public DataTable ObtenerProveedores()
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            R = MiCnn.EjecutarSELECT("SPGetProveedors");

            return R;
        }
    }
}
