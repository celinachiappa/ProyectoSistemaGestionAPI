using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntidades;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {

        public static string GetVenta(int ventaID)
        {
            return VentaData.Get(ventaID);
        }

        public static List<Venta> ListarVentas()
        {
            return VentaData.GetAll();
        }

        public static string ModificarVenta(int id, Venta ventaModify)
        {
            return VentaData.ModifyVenta(id, ventaModify);
        }

        public static string CrearVenta(Venta newVenta)
        {
            return VentaData.CrearVenta(newVenta);
        }

        public static string EliminarVenta(int ventaID)
        {
            return VentaData.DeleteSale(ventaID);
        }
    }
}
