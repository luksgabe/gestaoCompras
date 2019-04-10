using System;
using SafeWeb_Domain.DataTransferObjects;

namespace SafeWeb_Domain.Entities {
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Perfil { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario () { }

        public Usuario (LoginDTO dto) {
            this.Login = dto.Login;
            this.Senha = dto.Senha;
        }

        public Usuario (UsuarioDTO dto) {
            this.Id = dto.Id;
            this.Nome = dto.Nome;
            this.Cpf = dto.Cpf;
            this.DataNascimento = dto.DataNascimento;
            this.Perfil = dto.Perfil;
            this.Login = dto.Login;
            this.Senha = dto.Senha;
        }
    }
}