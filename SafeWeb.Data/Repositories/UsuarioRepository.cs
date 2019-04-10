using System;
using System.Linq;
using SafeWeb.Data.Data;
using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;

namespace SafeWeb.Data.Repositories {
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository {
        public UsuarioRepository (SafeWebContext context) : base (context) { }

        public Usuario BuscarUsuarioLogin (Usuario usuario) {
            return GetAll ().Where (p => p.Login.Equals (usuario.Login) && p.Senha.Equals (usuario.Senha))
                .FirstOrDefault ();
        }
    }
}