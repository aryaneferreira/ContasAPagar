using ContasAPagar.Models;
using System.Web;
using System.Web.Helpers;

namespace ContasAPagar.Utils.Helpers
{
    public class Criptografia
    {
        public static string GerarHash(string valor)
        {
            return Crypto.HashPassword(valor);
        }

        public static bool VerificarSenha(string senhaUsuario, string senhaUsuarioBanco)
        {
            return Crypto.VerifyHashedPassword(senhaUsuarioBanco, senhaUsuario);
        }
    }
}
