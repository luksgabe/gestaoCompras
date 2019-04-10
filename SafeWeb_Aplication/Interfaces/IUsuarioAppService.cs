using SafeWeb_Domain.DataTransferObjects;
using SafeWeb_Domain.Entities;

namespace SafeWeb_Aplication.Interfaces {
    public interface IUsuarioAppService : IAppService<Usuario> {
        Usuario Login (LoginDTO login);

        void RegistrarUsuario (UsuarioDTO usuario);
    }
}