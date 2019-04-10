using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class PropostaService : Service<Proposta>, IPropostaService {
        private readonly IPropostaRepository propostaRepository;

        public PropostaService (IPropostaRepository propostaRepository) : base (propostaRepository) {
            this.propostaRepository = propostaRepository;
        }
    }
}