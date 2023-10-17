using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using SistemaGestionEntidades;
using SistemaGestionBussiness;
using SistemaGestionData;

namespace SistemGestionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObtenerProducto")]
        public static string Get(int IDProducto)
        {
             return ProductoBussines.GetProducto(IDProducto);
        }

        [HttpGet("ListarProductos")]
        public static List<ProductoModel> GetAllProducts()
        {
            return ProductoBussines.ListarProductos();
        }

        [HttpPut("ModificarProducto")]
        public string UpdateProduct(int IDProducto, [FromBody] ProductoModel updatedProduct)
        {
            return ProductoBussines.ModificarProducto(IDProducto, updatedProduct);

        }


        [HttpPost("CrearProducto")]
        public string CreateProduct([FromBody] ProductoModel newProduct)
        {
            return ProductoBussines.CrearProducto(newProduct);
        }


        [HttpDelete("EliminarProducto")]
        public string DeleteProduct(int IDProducto)
        {
            
            return ProductoBussines.EliminarProducto(IDProducto);
            
        }


    }


}