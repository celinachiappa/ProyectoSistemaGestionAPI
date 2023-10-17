using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntidades;
using System.Data;
using System.Data.SqlClient;

namespace SistemGestionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VentaController : ControllerBase
    {
        private readonly ILogger<VentaController> _logger;
        public VentaController(ILogger<VentaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObtenerVenta")]
        public string Get(int IDVenta)
        {
          return VentaBussiness.GetVenta(IDVenta);
        }

        [HttpGet("ObtenerVentasTodas")]
        public List<Venta>GetAll()
        {
            return VentaBussiness.ListarVentas();  
        }

        [HttpPut("ModificarVenta")]
        public string ModifyVenta(int id, Venta modifiedSale)
        {
            return VentaBussiness.ModificarVenta(id, modifiedSale);
        }


        [HttpPost("CrearVenta")]
        public string CrearVenta(Venta newSale)
        {
            return VentaBussiness.CrearVenta(newSale);
        }

        [HttpDelete("EliminarVenta")]
        public string DeleteSale(int id)
        {
            return VentaBussiness.EliminarVenta(id);

        }

    }


}