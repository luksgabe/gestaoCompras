using System;
using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class UsuarioService : Service<Usuario>, IUsuarioService {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioService (IUsuarioRepository usuarioRepository) : base (usuarioRepository) {
            this.usuarioRepository = usuarioRepository;
        }

        public Usuario ValidarLogin (Usuario usuario) {
            return this.usuarioRepository.BuscarUsuarioLogin (usuario);
        }

        public void ValidarRegistroUsuario (Usuario usuario) {
            if (GetById (usuario.Id) != null) {
                throw new Exception ("Id de Usuário já existente.");
            }
        }
    }
}