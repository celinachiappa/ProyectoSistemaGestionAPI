using SistemaGestionEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;


namespace SistemaGestionBussiness
{
    public static class ProductoBussines
    {
        public static string GetProducto(int productoID)
        {
            return ProductData.Get(productoID);
        }

        public static List<ProductoModel> ListarProductos()
        {
            return ProductData.GetAllProducts();
        }

        public static string CrearProducto(ProductoModel newProducto)
        {
            return ProductData.CreateProduct(newProducto);
        }

        public static string ModificarProducto(int idProducto, ProductoModel modifiedProduct)
        {
            return ProductData.UpdateProduct(idProducto, modifiedProduct);
        }

        public static string EliminarProducto(int productoID)
        {
            return ProductData.DeleteProduct(productoID);
        }


    }
}
