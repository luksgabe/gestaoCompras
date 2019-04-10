using SafeWeb_Domain.Entities;

namespace SafeWeb_Domain.Interfaces.Services {
    public interface IUsuarioService : IService<Usuario> {

        Usuario ValidarLogin (Usuario usuario);
        void ValidarRegistroUsuario (Usuario usuario);
    }
}