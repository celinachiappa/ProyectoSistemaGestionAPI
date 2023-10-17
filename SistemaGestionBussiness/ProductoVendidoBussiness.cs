using SistemaGestionData;
using SistemaGestionEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public static class ProductoVendidoBussiness
    {

        public static string GetProductoVendido(int productoVendidoID)
        {
            return ProductoVendidoData.Get(productoVendidoID);
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.GetAllProductsVendidos();
        }

        public static string ModificarProductoVendido(int id, ProductoVendido modifyProduct)
        {
            return ProductoVendidoData.ModifyProductVendido(modifyProduct);
        }

        public static string CrearProducto(ProductoVendido crearProductoVendido)
        {
            return ProductoVendidoData.CreateProductVendido(crearProductoVendido);  
        }

        public static string EliminarProductoVendido(int productoVendidoID)
        {
            return ProductoVendidoData.DeleteProductVendido(productoVendidoID);
        }

    }
}
