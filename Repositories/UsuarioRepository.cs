using ContasAPagar.Db;
using ContasAPagar.Dto;
using ContasAPagar.Models;

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
                Senha = usuario.Senha
            };
            _context.Usuarios.Add(_usuario);
            _context.SaveChanges();
        }
    }
}
