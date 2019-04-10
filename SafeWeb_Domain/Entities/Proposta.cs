using System;

namespace SafeWeb_Domain.Entities {
    public class Proposta {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int IdFornecedor { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string CaminhoArquivo { get; set; }
        public bool AprovadaAnalistaCompras { get; set; }
        public bool AprovadaAnalistaFinanceiro { get; set; }
        public bool AprovadaDiretorFinanceiro { get; set; }

    }
}