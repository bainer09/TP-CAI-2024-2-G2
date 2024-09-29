using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class Permisos
    {
        public static readonly Dictionary<int, string> listaPermisos = new Dictionary<int, string>
        {
            {1, "Alta de usuarios Supervisores" },
            {2, "Modificación de usuarios Supervisores" },
            {3, "Baja de usuarios Supervisores" },
            {4, "Alta de usuarios Vendedores" },
            {5, "Modificación de usuarios Vendedores" },
            {6, "Baja de usuarios Vendedores" },
            {7, "Alta de Proveedores" },
            {8, "Modificación de Proveedores" },
            {9, "Baja de Proveedores" },
            {10, "Alta de Productos" },
            {11, "Modificación de Productos" },
            {12, "Baja de Productos" },
            {13, "Venta" },
            {14, "Devolucióm" },
            {15, "Reporte de stock crítico" },
            {16, "Reporte de ventas por vendedor" },
            {17, "Reporte de producto más vendido por categoría" }
        };
    }
}
