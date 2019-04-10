using SafeWeb.Data.Data;
using SafeWeb.Data.Repositories;
using SafeWeb_Domain.Interfaces.Repository;

namespace SafeWeb.Data.UnityOfWork {
    public class UnityOfWork : IUnityOfWork {

        readonly SafeWebContext context;
        IUsuarioRepository usuarios;

        public UnityOfWork (SafeWebContext context) {
            this.context = context;
        }

        public IUsuarioRepository Usuario {
            get {
                if (this.usuarios == null)
                    this.usuarios = new UsuarioRepository (this.context);

                return this.usuarios;
            }
        }

        public int SaveChanges () {
            return this.context.SaveChanges ();
        }
    }
}