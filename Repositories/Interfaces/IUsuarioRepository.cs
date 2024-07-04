using ContasAPagar.Dto;

namespace ContasAPagar.Repositories
{
    public interface IUsuarioRepository
    {
        public void PostUsuario(UsuarioInputModel usuario);
    }
}
