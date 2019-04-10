using System;

namespace SafeWeb_Domain.DataTransferObjects {
    public class UsuarioDTO {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Perfil { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}