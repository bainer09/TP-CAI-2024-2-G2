using Datos;
using Negocio;
using Presentacion;
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
        private Usuario usuarioSeleccionado;
        private int perfilUsuario;
        private ProductoNegocio productoNegocio = new ProductoNegocio();

        public FrmBajaModUsuario(int perfilUsuario)
        {
            InitializeComponent();
            this.FormClosing += Modulobajausuario_cerrar;
            this.perfilUsuario = perfilUsuario;
        }

        // Botón Cruz de Cierre del Formulario
        private void Modulobajausuario_cerrar(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        // Carga del Form
        private void Modulobajausuario_Load(object sender, EventArgs e)
        {
            Alertabotones.Visible = false;
            cargarUsuarios();
        }

        // Agregar columna de checkbox y cargar lista de usuarios en el DataGridView
        private void cargarUsuarios()
        {
            // Obtener la lista de usuarios y ordenarla alfabéticamente por apellido
            List<Usuario> usuarios = usuarionegocio.listarUsuarios();
            usuarios = usuarios.OrderBy(u => u.apellido).ToList(); // Orden alfabético por apellido

            // Configurar el DataGridView con la lista ordenada
            var bindingList = new BindingList<Usuario>(usuarios);
            var source = new BindingSource(bindingList, null);
            listausuarios.DataSource = source;

            // Ocultar columnas no necesarias
            //listausuarios.Columns["Id"].Visible = false;
            listausuarios.Columns["Host"].Visible = false;
            listausuarios.Columns["Direccion"].Visible = false;
            listausuarios.Columns["Telefono"].Visible = false;
            listausuarios.Columns["Email"].Visible = false;
            listausuarios.Columns["FechaNacimiento"].Visible = false;
            listausuarios.Columns["FechaBaja"].Visible = false;


            // Agregar columna de checkbox para selección si no existe
            if (!listausuarios.Columns.Contains("Seleccionar"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Seleccionar",
                    HeaderText = "Seleccionar"
                };
                listausuarios.Columns.Insert(0, checkBoxColumn);
            }
        }


        // Obtener el usuario seleccionado basado en el checkbox marcado
        private Usuario ObtenerUsuarioSeleccionado()
        {
            foreach (DataGridViewRow row in listausuarios.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Seleccionar"].Value);
                if (isChecked)
                {
                    return (Usuario)row.DataBoundItem;
                }
            }
            return null;
        }

        // Baja de usuario
        private void Botondardebaja_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioSeleccionado = ObtenerUsuarioSeleccionado();
                if (usuarioSeleccionado == null)
                {
                    Alertabotones.Visible = true;
                    Alertabotones.ForeColor = Color.Red;
                    Alertabotones.Text = "Seleccione un usuario para eliminar.";
                    return;
                }

                Guid usuarioLogueado = Guid.Parse("9ea1c0da-e541-4846-a9de-8478664a87bb");
                usuarionegocio.bajaUser(usuarioSeleccionado, usuarioLogueado);

                Alertabotones.Visible = true;
                Alertabotones.ForeColor = Color.Green;
                Alertabotones.Text = $"{usuarioSeleccionado.nombreUsuario} dado de baja correctamente.";
                cargarUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error dando de baja el Usuario", ex);
            }
        }

        private void Buscarusuarioboton_Click(object sender, EventArgs e)
        {
            // Verifica si el campo de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(Iddeusuariotexto.Text))
            {
                MessageBox.Show("Por favor, ingrese al menos un número o nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Usuario> usuarios = new List<Usuario>();
            List<Usuario> allUsers = usuarionegocio.listarUsuarios();

            // Filtrar por nombre de usuario (insensible a mayúsculas/minúsculas y sin espacios al inicio/final)
            foreach (Usuario user in allUsers)
            {
                bool matchesUsuario = false;

                // Filtrar por ID de usuario si está ingresado
                if (!string.IsNullOrWhiteSpace(Iddeusuariotexto.Text))
                {
                    string userguid = user.id.ToString();
                    Console.WriteLine($"Buscando por ID: {Iddeusuariotexto.Text.Trim()}, Usuario ID: {userguid}");
                    matchesUsuario = userguid.Equals(Iddeusuariotexto.Text.Trim(), StringComparison.OrdinalIgnoreCase);
                }

                // Filtrar por nombre de usuario si está ingresado
                /*if (!string.IsNullOrWhiteSpace(Iddenombretexto.Text))
                {
                    string nombreUsuario = user.nombre.Trim(); // Eliminar espacios adicionales
                    Console.WriteLine($"Buscando por Nombre: {Iddenombretexto.Text.Trim()}, Nombre Usuario: {nombreUsuario}");
                    matchesUsuario |= nombreUsuario.IndexOf(Iddenombretexto.Text.Trim(), StringComparison.OrdinalIgnoreCase) >= 0;
                }*/

                if (matchesUsuario)
                {
                    usuarios.Add(user);
                }
            }

            // Actualizar el DataGridView con los resultados de búsqueda
            if (usuarios.Count > 0)
            {
                var bindingList = new BindingList<Usuario>(usuarios);
                var source = new BindingSource(bindingList, null);
                listausuarios.DataSource = source;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados para la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Reactivar usuario
        /*private void Botonreactivarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioSeleccionado = ObtenerUsuarioSeleccionado();
                if (usuarioSeleccionado == null)
                {
                    Alertabotones.Visible = true;
                    Alertabotones.ForeColor = Color.Red;
                    Alertabotones.Text = "Seleccione un usuario para reactivar.";
                    return;
                }

                Guid usuarioLogueado = Guid.Parse("9ea1c0da-e541-4846-a9de-8478664a87bb");
                usuarionegocio.reactivarUser(usuarioSeleccionado, usuarioLogueado);

                Alertabotones.Visible = true;
                Alertabotones.ForeColor = Color.Green;
                Alertabotones.Text = "Usuario reactivado correctamente.";
                cargarUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Reactivando el Usuario", ex);
            }
        }*/

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain(perfilUsuario, usuarionegocio, productoNegocio);
            frmMain.Show();
            this.Hide();
        }

        private void listausuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
