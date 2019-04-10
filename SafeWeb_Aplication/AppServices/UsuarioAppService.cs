using System;
using System.Linq;
using SafeWeb.CrossCutting.Security.Hash;
using SafeWeb_Aplication.Interfaces;
using SafeWeb_Domain.DataTransferObjects;
using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Aplication.AppServices {
    public class UsuarioAppService : AppService<Usuario>, IUsuarioAppService {

        private readonly IHash hash;
        private readonly IUsuarioService usuarioService;

        public UsuarioAppService (IUsuarioService usuarioService, IHash hash) : base (usuarioService) {
            this.usuarioService = usuarioService;
            this.hash = hash;
        }

        public Usuario Login (LoginDTO login) {

            var usuario = new Usuario (login);
            CriarHash (usuario);
            usuario = this.usuarioService.ValidarLogin (usuario);
            if (usuario == null) {
                throw new Exception ("Login ou Senha incorretos");
            }

            return usuario;
        }

        public void RegistrarUsuario (UsuarioDTO dto) {
            var usuario = new Usuario (dto);
            this.usuarioService.ValidarRegistroUsuario (usuario);
            this.usuarioService.Add (usuario);
        }

        #region Métodos Auxiliares

        public void CriarHash (Usuario usuario) {
            usuario.Senha = hash.Create (usuario.Senha);
        }

        #endregion     

    }
}