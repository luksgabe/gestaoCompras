using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class CategoriaService : Service<Categoria>, ICategoriaService {
        private readonly ICategoriaRepository categoriaRepository;

        public CategoriaService (ICategoriaRepository categoriaRepository) : base (categoriaRepository) {
            this.categoriaRepository = categoriaRepository;
        }
    }
}