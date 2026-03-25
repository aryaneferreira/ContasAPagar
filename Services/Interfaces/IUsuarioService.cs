using ContasAPagar.Dto;
using ContasAPagar.Models;

namespace ContasAPagar.Services
{
    public interface IUsuarioService
    {
        public void PostUsuario(UsuarioInputModel usuario);

        public Usuario GetUsuario(string email);
    }
}
