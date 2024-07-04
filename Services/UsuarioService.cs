using ContasAPagar.Dto;
using ContasAPagar.Repositories;

namespace ContasAPagar.Services
{
    public class UsuarioService: IUsuarioService
    {
        public IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void PostUsuario(UsuarioInputModel usuario)
        {
            // ver se as validações ficariam aqui ou colocaria em alguma outra classe
            if(usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            _usuarioRepository.PostUsuario(usuario);
        }
    }
}
