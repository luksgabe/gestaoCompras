using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using SafeWeb_Aplication.Interfaces;
using SafeWeb_Domain.DataTransferObjects;
using SafeWeb_Domain.Entities;

namespace SafeWeb_Web.Controllers {

    [ApiController]
    [Route ("api/[controller]")]
    public class HomeController : ControllerBase {

        private readonly IUsuarioAppService usuarioApp;
        public HomeController (IUsuarioAppService usuarioApp) {
            this.usuarioApp = usuarioApp;
        }

        [HttpGet ("usuario/lista")]
        public async Task<IActionResult> ListarUsuarios () {
            var listagem = await usuarioApp.GetAllAsync ();
            return Ok (listagem);
        }

        [HttpPost ("[action]")]
        public IActionResult Usuario (UsuarioDTO usuario) {
            try {
                usuarioApp.RegistrarUsuario (usuario);
                return Ok ();
            } catch (Exception ex) {
                return BadRequest (ex.Message);
            }
        }

        [HttpPost ("[action]")]
        public IActionResult Login (LoginDTO model) {
            var usuario = new Usuario ();
            try {
                usuario = usuarioApp.Login (model);
            } catch (Exception ex) {
                return BadRequest (ex.Message);
            }
            return Ok (usuario);
        }

    }
}