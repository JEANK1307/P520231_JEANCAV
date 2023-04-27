using Logica.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520231_JEANCAV.Formularios
{
    public partial class FrmProveedoresGestion : Form
    {
        DataTable DtLista { get; set; }

        //Proveedor1 MiProveedorLocal { get; set; }
        Proveedor MiProveedorLocal { get; set; }
        public FrmProveedoresGestion()
        {
            InitializeComponent();
            DtLista = new DataTable();
           MiProveedorLocal =  new Logica.Models.Proveedor();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposProveedor())
            {

                bool CedulaOK;
                bool EmailOK;


                //pasos 1.1 y 1.2
                MiProveedorLocal = new Logica.Models.Proveedor();

                //TODO: validar los datos requeridos

                //llenar los valores de los atributos con los datos digitados en el form
                MiProveedorLocal.ProveedorNombre = TxtProveedorNombre.Text.Trim();
                MiProveedorLocal.ProveedorCedula = TxtProveedorCedula.Text.Trim();
                MiProveedorLocal.ProveedorEmail = TxtProveedorEmail.Text.Trim();
                MiProveedorLocal.ProveedorDireccion = TxtProveedorDireccion.Text.Trim();
                MiProveedorLocal.ProveedorNotas = TxtProveedorNota.Text.Trim();

                //composicion del rol
                MiProveedorLocal.ProveedorTipoID = Convert.ToInt32(CbProveedorTipo.SelectedValue);

                //Realizar las consultas por email y por cedula
                //pasos 1.3 y 1.3.6
                CedulaOK = MiProveedorLocal.ConsultarPorCedula();

                if (CedulaOK == false)
                {

                    string msg = string.Format("¿Está seguro que desea agregar al proveedor {0}?", MiProveedorLocal.ProveedorNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiProveedorLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("Proveedor guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaProveedores();
                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo guardar!", ":/", MessageBoxButtons.OK);

                        }
                    }
                }
                else
                {
                    //indicar al usuario si falla alguna consulta

                    if (CedulaOK)
                    {
                        MessageBox.Show("Ya existe un proveedor con la cedula digitada", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                        return;
                    }
                }

            }
            
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProveedoresGestion_Load(object sender, EventArgs e)
        {
            CargarListaProveedores();
            CargarListaTipoProveedor();
        }


        private void CargarListaProveedores()
        {
            DtLista = new DataTable();
            DtLista = MiProveedorLocal.ObtenerProveedores();
            DgListaProveedores.DataSource = DtLista;
        }
        private void DgListaProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgListaProveedores.SelectedRows.Count == 1)
            {
                LimpiarFormulario();
                DataGridViewRow MiFila = DgListaProveedores.SelectedRows[0];
                int IdProveedor = Convert.ToInt32(MiFila.Cells["ProveedorID"].Value);
                string ProveedorNombre = MiFila.Cells["ProveedorNombre"].Value.ToString();
                string ProveedorCedula = MiFila.Cells["ProveedorCedula"].Value.ToString();
                string ProveedorEmail = MiFila.Cells["ProveedorEmail"].Value.ToString();
                string ProveedorDireccion = MiFila.Cells["ProveedorDireccion"].Value.ToString();
                string ProveedorNotas = MiFila.Cells["ProveedorNotas"].Value.ToString();
                int ProveedorTipoId = Convert.ToInt32(MiFila.Cells["ProveedorTipoID"].Value);

                TxtProveedorNombre.Text = ProveedorNombre.ToString();
                TxtProveedorCedula.Text = ProveedorCedula.ToString();
                TxtProveedorEmail.Text= ProveedorEmail.ToString();  
                TxtProveedorDireccion.Text = ProveedorDireccion.ToString();
                TxtProveedorNota.Text = ProveedorNotas.ToString();  
                CbProveedorTipo.SelectedValue= ProveedorTipoId;
                BtnAgregar.Enabled=false;
            }
        }

        private void CargarListaTipoProveedor()
        {
            Logica.Models.TipoProveedor MiTipoProveedor = new Logica.Models.TipoProveedor();
            DataTable dt = new DataTable();
            dt = MiTipoProveedor.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbProveedorTipo.ValueMember = "ID";
                CbProveedorTipo.DisplayMember = "Descrip";

                CbProveedorTipo.DataSource = dt;

                CbProveedorTipo.SelectedIndex = -1;
            }
        }

        private bool ValidarCamposProveedor()
        {
            bool resultadoValidacion = true;
            if (!string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()) &&
                CbProveedorTipo.SelectedIndex > -1)
            {
                
            }
            else
            {
                if (string.IsNullOrEmpty(TxtProveedorNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el proveedor", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtProveedorNombre.Focus();
                    return false;
                }

                //CEDULA
                if (string.IsNullOrEmpty(TxtProveedorCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el proveedor", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtProveedorCedula.Focus();
                    return false;
                }

                //EMAIL
                if (string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo electronico", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtProveedorEmail.Focus();
                    return false;
                }
            }

                return resultadoValidacion;
        }

        private void TxtProveedorEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProveedorEmail.Text.Trim()))
            {
                if (!Validaciones.ValidarEmail(TxtProveedorEmail.Text.Trim()))
                {
                    MessageBox.Show("El formato del correo electrónico es incorrecto", "Error de validación", MessageBoxButtons.OK);

                    TxtProveedorEmail.Focus();
                }
            }
        }

        private void TxtProveedorCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e, true);
        }

        private void LimpiarFormulario()
        {
            TxtProveedorNombre.Clear();
            TxtProveedorCedula.Clear();
            TxtProveedorEmail.Clear();
            TxtProveedorDireccion.Clear();
            TxtProveedorNota.Clear();
            CbProveedorTipo.SelectedIndex = -1;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            BtnAgregar.Enabled = true;
            LimpiarFormulario();
        }
    }
}
