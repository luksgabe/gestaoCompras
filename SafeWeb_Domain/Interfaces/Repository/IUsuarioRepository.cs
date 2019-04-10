using SafeWeb_Domain.Entities;

namespace SafeWeb_Domain.Interfaces.Repository {
    public interface IUsuarioRepository : IRepository<Usuario> {
        Usuario BuscarUsuarioLogin (Usuario usuario);
    }
}