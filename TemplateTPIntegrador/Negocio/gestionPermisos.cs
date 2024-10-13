using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class PermisosPerfiles
    {
        private static readonly Dictionary<Perfiles, List<int>> permisosPerfiles = new Dictionary<Perfiles, List<int>>
        {
            {Perfiles.Administrador, new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,15,16,17}},
            {Perfiles.Supervisor, new List<int> {10,11,12,14,15,16,17}},
            {Perfiles.Vendedor, new List<int>{13,16}}
        };
        public static List<string> ListarPermisos (Perfiles perfil)
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
