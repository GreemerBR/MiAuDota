﻿using Entra21.MiAuDota.Repositorio.Enum;

namespace Entra21.MiAuDota.Repositorio.Entidades
{
    public class Usuario : BaseEntity
    {
        public string? Cpf { get; set; }
        public string? Endereco { get; set; }
        public string? Celular { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
        public string? Especialidade { get; set; }
        public bool? EhVoluntario { get; set; }
        public bool EhUsuario { get; set; }
        public DateTime? DataNascimento { get; set; }

        public StatusConta? StatusConta { get; set; }

        public IList<Animal> Animais { get; set; }
    }
}
