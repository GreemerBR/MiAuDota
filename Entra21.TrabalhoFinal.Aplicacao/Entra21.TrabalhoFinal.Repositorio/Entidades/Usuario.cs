﻿using Entra21.TrabalhoFinal.Repositorio.Enum;

namespace Entra21.TrabalhoFinal.Repositorio.Entidades
{
    public class Usuario : BaseModel
    {
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string? Especialidade { get; set; }
        public bool EhVoluntario { get; set; }
        public bool EhUsuario { get; set; }
        public DateTime DataNascimento { get; set; }

        public StatusConta StatusConta { get; set; }
    }
}
