﻿using System;
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
    public partial class FrmUsuariosGestion : Form
    {
        //por orden es mejor crear objetos locales que permitan
        //la gestion del tema que estamos tratando.
        //usar objetos individuales en las funciones puede provocar
        //desorden y complicar más la lectura del código fuente. 

        //objeto local para usuario
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }


        //lista local de usuarios que se visualizan en el datagridview
        private DataTable ListaUsuarios { get; set; }


        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();
            ListaUsuarios = new DataTable();
        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
            //definimos el padre MDI
            MdiParent = Globales.MiFormPrincipal;


            CargarListaRoles();

            CargarListaDeUsuarios();



        }

        private void CargarListaDeUsuarios()
        {
            //resetear la lista de Usuarios haciendo re instancia del objeto  
            ListaUsuarios = new DataTable();

            if (CboxVerActivos.Checked)
            {
                ListaUsuarios = MiUsuarioLocal.ListarActivos();
            }
            else
            {
                ListaUsuarios = MiUsuarioLocal.ListarInactivos();
            }

            DgLista.DataSource = ListaUsuarios;

        }

        private void CargarListaRoles()
        {

            Logica.Models.Usuario_Rol MiRol = new Logica.Models.Usuario_Rol();

            DataTable dt = new DataTable();
            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRolesUsuario.ValueMember = "ID";
                CbRolesUsuario.DisplayMember = "Descrip";

                CbRolesUsuario.DataSource = dt;

                CbRolesUsuario.SelectedIndex = -1;
            }
        }

        private void DgLista_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgLista.ClearSelection();
        }

        private void DgLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando seleccionemos una fila del datagrid se debe cargar la info
            //de dicho usuario en el usuario local y luego dibujar esa info en los
            //controles graficos

            if (DgLista.SelectedRows.Count == 1)
            {
                //TODO: Limpiar el formulario

                //de la colección de filas seleccionadas (que en este caso es solo una)
                //seleccionamos la fila en el indice 0, o sea la primera
                DataGridViewRow MiFila = DgLista.SelectedRows[0];

                //lo que necesito es el valor del ID del usuario para realizar la consulta
                // y traer todos los datos para llenar el objeto de usuario local
                int IdUsuario = Convert.ToInt32(MiFila.Cells["CUsuarioID"].Value);

                //para no asumir riesgos se reinstancia el usuario local
                MiUsuarioLocal = new Logica.Models.Usuario();

                //ahora le agremos el valor obtenido por la fila al ID del usuario local
                MiUsuarioLocal.UsuarioID = IdUsuario;

                //una vez que tengo el objeto local con el valor del id, puedo ir a 
                //a consultar el usuario por ese id y llenar el resto de atributos
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorIDRetornaUsuario();

                //validamos que el usuario local tenga datos

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //si cargamos correctamente el usuario local llenamos los controles

                    TxtUsuarioID.Text = Convert.ToString(MiUsuarioLocal.UsuarioID);

                    TxtUsuarioNombre.Text = MiUsuarioLocal.UsuarioNombre;

                    TxtUsuarioCedula.Text = MiUsuarioLocal.UsuarioCedula;

                    TxtUsuarioTelefono.Text = MiUsuarioLocal.UsuarioTelefono;

                    TxtUsuarioCorreo.Text = MiUsuarioLocal.UsuarioCorreo;

                    TxtUsuarioDireccion.Text = MiUsuarioLocal.UsuarioDireccion;

                    //combobox
                    CbRolesUsuario.SelectedValue = MiUsuarioLocal.MiRolTipo.UsuarioRolID;

                    //TODO: desactivar botones que no son necesarios en este caso de Agregar
                }


            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            TxtUsuarioID.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioContrasennia.Clear();

            CbRolesUsuario.SelectedIndex = -1;

            TxtUsuarioDireccion.Clear();
        }


        private bool ValidarDatosDigitados()
        {
            //evalua que se hayan digitado los campos de texto en el formulario
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()) &&
                CbRolesUsuario.SelectedIndex > -1)
            {
                R = true;
            }
            else
            {
                //qué pasa cuando algo falta?

                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtUsuarioNombre.Focus();
                    return false;
                }

                //CEDULA
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar una cedula para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtUsuarioCedula.Focus();
                    return false;
                }

                //TELEFONO
                if (string.IsNullOrEmpty(TxtUsuarioTelefono.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un telefono para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtUsuarioTelefono.Focus();
                    return false;
                }


                //CORREO
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un correo para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtUsuarioCorreo.Focus();
                    return false;
                }


                //CONTRASENNIA
                if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar un nombre para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    TxtUsuarioContrasennia.Focus();
                    return false;
                }

                //ROL DE USUARIO
                if (CbRolesUsuario.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un rol para el usuario", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                    CbRolesUsuario.Focus();
                    return false;
                }


            }

            return R;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosDigitados())
            {
                
                //estas varaibles almacenan el resultado de las consultas por correo
                //y cedula

                bool CedulaOK;
                bool EmailOK;


                //pasos 1.1 y 1.2
                MiUsuarioLocal = new Logica.Models.Usuario();

                //TODO: validar los datos requeridos

                //llenar los valores de los atributos con los datos digitados en el form
                MiUsuarioLocal.UsuarioNombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.UsuarioCedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.UsuarioTelefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.UsuarioCorreo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.UsuarioContrasennia = TxtUsuarioContrasennia.Text.Trim();
                //composicion del rol
                MiUsuarioLocal.MiRolTipo.UsuarioRolID = Convert.ToInt32(CbRolesUsuario.SelectedValue);
                MiUsuarioLocal.UsuarioDireccion = TxtUsuarioDireccion.Text.Trim();

                //Realizar las consultas por email y por cedula
                //pasos 1.3 y 1.3.6
                CedulaOK = MiUsuarioLocal.ConsultarPorCedula();

                //pasos 1.4 y 1.4.6
                EmailOK = MiUsuarioLocal.ConsultarPorEmail();


                //paso 1.5
                if (CedulaOK == false && EmailOK == false)
                {
                    //se puede agregar ek usuario ya que no existe un usuario con la
                    //cedula y correo digitados


                    //se solicita al usuario cofirmacion de si quiere agregar o no al
                    //usuario

                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MiUsuarioLocal.UsuarioNombre);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MiUsuarioLocal.Agregar();
                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarFormulario();

                            CargarListaDeUsuarios();


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
                        MessageBox.Show("Ya existe un usuario con la cedula digitada", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitada", "ERROR DE VALIDACIÓN", MessageBoxButtons.OK);
                        return;
                    }
                }


            }
        }





    }


}
