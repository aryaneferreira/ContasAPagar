using ContasAPagar.Db;
using ContasAPagar.Dto;
using ContasAPagar.Models;
using ContasAPagar.Utils.Helpers;

namespace ContasAPagar.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        public readonly ContasAPagarContext _context; 
        public UsuarioRepository(ContasAPagarContext context) 
        {
            _context = context;
        }

        public void PostUsuario(UsuarioInputModel usuario)
        {
            Usuario _usuario = new Usuario()
            {
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Email = usuario.Email,
                Senha = Criptografia.GerarHash(usuario.Senha) 
            };
            _context.Usuarios.Add(_usuario);
            _context.SaveChanges();
        }

        public Usuario GetUsuario(string email)
        {
            // melhorar esse retorno
            return _context.Usuarios.Select(x => x).Where(x => x.Email.Equals(email)).FirstOrDefault() ?? new Usuario();
        }
    }
}
