using ContasAPagar.Dto;
using ContasAPagar.Models;

namespace ContasAPagar.Repositories
{
    public interface IUsuarioRepository
    {
        public void PostUsuario(UsuarioInputModel usuario);

        public Usuario GetUsuario(string email);
    }
}
