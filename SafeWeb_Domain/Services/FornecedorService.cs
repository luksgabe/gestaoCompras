using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class FornecedorService : Service<Fornecedor>, IFornecedorService {
        private readonly IFornecedorRepository fornecedorRepository;

        public FornecedorService (IFornecedorRepository fornecedorRepository) : base (fornecedorRepository) {
            this.fornecedorRepository = fornecedorRepository;
        }
    }
}