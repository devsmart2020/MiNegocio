using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {       
        // TRAEMOS EL OBJETO DE CONFIGURACIÓN (appsettings.json)
        // MEDIANTE INYECCIÓN DE DEPENDENCIAS.
        private readonly IConfiguration _configuration;
        private readonly IUsuarioService<Tbusuario> _service;

        public LoginController(IConfiguration configuration, IUsuarioService<Tbusuario> service)
        {
            _configuration = configuration;
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Tbusuario usuario)
        {
            var userInfo = await AutenticarUsuarioAsync(usuario);          
            if (userInfo != null)
            {
                if (userInfo.IdPerfil == 2)
                {
                    userInfo.Token = GenerarTokenJWT(userInfo);
                    return Ok(userInfo);
                }
                else
                {
                    return Ok(userInfo);
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        private async Task<Tbusuario> AutenticarUsuarioAsync(Tbusuario entity)
        {
            return await _service.Login(entity);            
        }

        private string GenerarTokenJWT(Tbusuario entity)
        {
            // CREAMOS EL HEADER //
            var _symmetricSecurityKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["JWT:ClaveSecreta"]));
            var _signingCredentials = new SigningCredentials(
                _symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
            var _Header = new JwtHeader(_signingCredentials);

            // CREAMOS LOS CLAIMS //
            var _Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.NameId, entity.DocId.ToString()),
                new Claim("Nombre", entity.Nombres),
                new Claim("Apellidos", entity.Apellidos),
                new Claim(JwtRegisteredClaimNames.Email, entity.User, entity.User),
                new Claim(ClaimTypes.Role,entity.IdPerfil.ToString())
            };

            // CREAMOS EL PAYLOAD //
            var _Payload = new JwtPayload
                (
                    issuer: _configuration["JWT:Issuer"],
                    audience:_configuration["JWT:Audience"],
                    claims:_Claims,
                    notBefore: DateTime.Now,
                    //Expira a las 24Hrs
                    expires:DateTime.Now.AddHours(1)
                );

            // GENERAMOS EL TOKEN //
            var _Token = new JwtSecurityToken(_Header, _Payload);
            return new JwtSecurityTokenHandler().WriteToken(_Token);
        }
    }
}
