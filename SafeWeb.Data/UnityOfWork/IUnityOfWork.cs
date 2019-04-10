using SafeWeb_Domain.Interfaces.Repository;

namespace SafeWeb.Data.UnityOfWork {
    public interface IUnityOfWork {
        IUsuarioRepository Usuario { get; }

        int SaveChanges ();
    }
}