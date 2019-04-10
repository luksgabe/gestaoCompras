using System;

namespace SafeWeb_Domain.Entities {
    public class HistoricoProposta {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime data { get; set; }
        public int IdUsuario { get; set; }
        public virtual Usuario usuario { get; set; }
        public int IdProposta { get; set; }
        public virtual Proposta proposta { get; set; }
    }
}