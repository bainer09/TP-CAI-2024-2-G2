using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class gestionPermisos
    {
        // Setea los permisos de cada perfil
        private static readonly Dictionary<PerfilUsuario, List<int>> permisosPerfiles = new Dictionary<PerfilUsuario, List<int>>
        {
            {PerfilUsuario.Administrador, new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,15,16,17}},
            {PerfilUsuario.Supervisor, new List<int> {10,11,12,14,15,16,17}},
            {PerfilUsuario.Vendedor, new List<int>{13,16}}
        };

        // Lista las descripciones de los permisos de un perfil
        public static List<string> ListarPermisos (PerfilUsuario perfil)
        {
            List<string> permisos = new List<string>();
            if(permisosPerfiles.TryGetValue(perfil, out List<int> IDs))
            {
                foreach (int id in IDs)
                {
                    if(Permisos.listaPermisos.TryGetValue(id, out string descripcion)) {permisos.Add(descripcion);}
                }
            }
            return permisos;
        }
    }
}
