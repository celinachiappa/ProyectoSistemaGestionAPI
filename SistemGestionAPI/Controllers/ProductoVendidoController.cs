using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntidades;
using System.Data;
using System.Data.SqlClient;

namespace SistemGestionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoVentaController : ControllerBase
    {
        private readonly ILogger<ProductoVentaController> _logger;
        public ProductoVentaController(ILogger<ProductoVentaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObtenerProductoVendido")]
        public string Get(int IDProductoVendido)
        {
            return ProductoVendidoBussiness.GetProductoVendido(IDProductoVendido);
        }


        [HttpGet("ObtenerProductosVendidos")]
        public List<ProductoVendido> GetAllProductsVendidos()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos();

        }

        [HttpPut("ModificarProductoVendido")]
        public string ModifyProductVendido(int id, [FromBody] ProductoVendido modifiedProductVendido)
        {
            return ProductoVendidoBussiness.ModificarProductoVendido(id, modifiedProductVendido);
        }



        [HttpPost("CrearProductoVendido")]
        public string CreateProductVendido([FromBody] ProductoVendido newProductVendido)
        {
            return ProductoVendidoBussiness.CrearProducto(newProductVendido);
        }


        [HttpDelete("EliminarProductoVendido")]
        public string DeleteProductVendido(int id)
        {
            return ProductoVendidoBussiness.EliminarProductoVendido(id);
        }
    }

}
