using SafeWeb_Domain.Entities;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class HistoricoPropostaService : Service<HistoricoProposta>, IHistoricoPropostaService {
        private readonly IHistoricoPropostaRepository historicoPropostaRepository;

        public HistoricoPropostaService (IHistoricoPropostaRepository historicoPropostaRepository) : base (historicoPropostaRepository) {
            this.historicoPropostaRepository = historicoPropostaRepository;
        }
    }
}