using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class FrmBajaModUsuario : Form
    {
        private UsuarioNegocio usuarionegocio = new UsuarioNegocio();
        private int perfildeusuario;
        private Guid guidUsuario;
        Usuario usuarioSeleccionado;

        public FrmBajaModUsuario(int perfildeusuario)
        {
            InitializeComponent();
            this.FormClosing += Modulobajausuario_cerrar;
            this.perfildeusuario = perfildeusuario;
        }
        //Boton Cruz de Ciere del Formulario
        private void Modulobajausuario_cerrar(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        //Carga del Form
        private void Modulobajausuario_Load(object sender, EventArgs e)
        {
            Alertabotones.Visible = false;
            cargarUsuarios();
        }

        //Baja de usuario
        private void Botondardebaja_Click(object sender, EventArgs e)
        {
            try
            {
                usuarionegocio.bajaUser(usuarioSeleccionado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error dando de baja el Usuario", ex);
            }
        }
        //Buscador de Usuarios
        private void Buscarusuarioboton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Iddeusuariotexto.Text) && string.IsNullOrWhiteSpace(Iddenombretexto.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un número o nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            };
            List<Usuario> usuarios = new List<Usuario>();
            List<Usuario> allUsers = usuarionegocio.listarUsuarios();
            foreach (Usuario user in allUsers)
            {
                   if(user._id == Iddeusuariotexto.Text || user._Nombre == Iddenombretexto.Text)
                {
                    usuarios.Add(user);
                }
            }

        }
        //Reactivar User
        private void Botonreactivarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                usuarionegocio.reactivarUser(usuarioSeleccionado);
            } catch (Exception ex) {
                throw new Exception("Error Reactivando el Usuario", ex);
            }
        }

        private void listausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            usuarioSeleccionado = (Usuario)listausuarios.Rows[listausuarios.CurrentCell.RowIndex].DataBoundItem;

        }

        private void cargarUsuarios()
        {
            List<Usuario> usuario = usuarionegocio.listarUsuarios();

            usuario = usuario.OrderBy(u => u._Apellido).ToList();

            var bindingList = new BindingList<Usuario>(usuario);
            var source = new BindingSource(bindingList, null);
            listausuarios.DataSource = source;
            listausuarios.Columns["Id"].Visible = false;
            listausuarios.Columns["Host"].Visible = false;
            listausuarios.Columns["Direccion"].Visible = false;
            listausuarios.Columns["Telefono"].Visible = false;
            listausuarios.Columns["Email"].Visible = false;
            listausuarios.Columns["FechaNacimiento"].Visible = false;
            listausuarios.Columns["FechaBaja"].Visible = false;

        }


    }
}

