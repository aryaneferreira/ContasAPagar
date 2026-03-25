using ContasAPagar.Dto;
using ContasAPagar.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("criar")]
        public void PostUsuario(UsuarioInputModel usuario)
        {
            _usuarioService.PostUsuario(usuario);
        }
    }
}
