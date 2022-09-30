using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Unit.Servico.MapeamentoEntidades
{
    public class UsuarioMapeamentoEntidadeTest
    {
        private readonly IUsuarioMapeamentoEntidade _usuarioMapeamentoEntidade;

        public UsuarioMapeamentoEntidadeTest()
        {
            _usuarioMapeamentoEntidade = new UsuarioMapeamentoEntidade();
        }

        [Fact]
        public void Test_ConstruirCom()
        {
            //Arrange 
            var viewModel = new UsuarioCadastrarViewModel
            {
                Nome = "Douglas",
                Endereco = "Rua Dinamarca",
                Celular = "47999999999",
                Email = "Douglas@douglas.com",
                Senha = "12345678",
                ConfirmarSenha = "12345678",
                Cpf = "123456789",
                Especialidade = "Salto em altura",
                EhVoluntario = true,
                DataNascimento = new DateTime (2000,1,6)
            };

            //act
            var usuario = _usuarioMapeamentoEntidade.ConstruirCom(viewModel);

            //Assert
            usuario.Nome.Should().Be(viewModel.Nome);
            usuario.Endereco.Should().Be(viewModel.Endereco);
            usuario.Celular.Should().Be(viewModel.Celular);
            usuario.Senha.Should().Be(viewModel.Senha);
            usuario.ConfirmarSenha.Should().Be(viewModel.ConfirmarSenha);
            usuario.Especialidade.Should().Be(viewModel.Especialidade);
            usuario.EhVoluntario.Should().Be(viewModel.EhVoluntario);
            usuario.Email.Should().Be(viewModel.Email);
            usuario.DataNascimento.Should().Be(viewModel.DataNascimento);
        }
    }
}
