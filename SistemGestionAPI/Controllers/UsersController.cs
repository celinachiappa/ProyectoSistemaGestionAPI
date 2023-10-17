using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntidades;
using System.Data;
using System.Data.SqlClient;

namespace SistemGestionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet("ObtenerUsuario")]
        public Usuario Get(int IDUsuario)
        {
            return UsuarioBussiness.GetUsuario(IDUsuario);
        }

        [HttpGet("ListarUsuarios")]
        public Usuario[] GetAll()
        {
            return UsuarioBussiness.ListarUsuarios();
        }

        [HttpPut("ModificarUsuario")]
        public string ModifyUser(Usuario modifiedUser)
        {
            return UsuarioBussiness.ModificarUsuario(modifiedUser);
        }


        [HttpPost("CrearUsuario")]
        public string CreateUser(Usuario newUser)
        {
            return UsuarioBussiness.CrearUsuario(newUser);

        }

        [HttpDelete("EliminarUsuario")]
        public string DeleteUser(int userID)
        {
            return UsuarioBussiness.EliminarUsuario(userID);
        }

    }


}