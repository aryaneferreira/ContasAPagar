using ContasAPagar.Dto;
using ContasAPagar.Services;
using ContasAPagar.Utils.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ContasAPagar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        IConfiguration configuration;

        private IUsuarioService usuarioService;

        public AuthController(IConfiguration configuration, IUsuarioService usuarioService)
        {
            this.configuration = configuration;
            this.usuarioService = usuarioService;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Auth([FromBody] AuthenticationUserModel usuario)
        {
            try
            {
                IActionResult response = Unauthorized();

                if (usuario != null)
                {
                    var usuarioBanco = usuarioService.GetUsuario(usuario.Email);
                    // colocar essa parte de baixo em uma outra classe
                    // colocar em um validador e comparar com as informações salvas no banco de dados
                    if (usuarioBanco != null && Criptografia.VerificarSenha(usuario.Senha, usuarioBanco.Senha))
                    {
                        var issuer = configuration["Jwt:Issuer"];
                        var audience = configuration["Jwt:Audience"];
                        var key = Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!);
                        var signingCredentials = new SigningCredentials(
                            new SymmetricSecurityKey(key),
                            SecurityAlgorithms.HmacSha512Signature
                        );

                        var subject = new ClaimsIdentity(new[]
                        {
                        new Claim(JwtRegisteredClaimNames.Sub, usuario.Email),
                        new Claim(JwtRegisteredClaimNames.Email, usuario.Email)
                    });

                        var expires = DateTime.UtcNow.AddHours(1);

                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = subject,
                            Expires = expires,
                            Issuer = issuer,
                            Audience = audience,
                            SigningCredentials = signingCredentials
                        };

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var token = tokenHandler.CreateToken(tokenDescriptor);
                        var jwtToken = tokenHandler.WriteToken(token);

                        return Ok(jwtToken);
                    }
                }

                return response;
            }
            catch (Exception ex) {
                throw;
            }
        }
    }
}
