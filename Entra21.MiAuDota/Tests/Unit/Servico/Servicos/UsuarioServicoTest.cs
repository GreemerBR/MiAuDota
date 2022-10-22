using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Tests.Unit.Servico.Servicos
{
    public class UsuarioServicoTest
    {
        private readonly IUsuarioServico _usuarioServico;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IUsuarioMapeamentoEntidade _mapeamentoEntidade;
        private readonly IUsuarioMapeamentoViewModel _mapeamentoViewModel;
        private readonly ISessionManager _sessionManager;
        public UsuarioServicoTest()
        {
            
            _usuarioRepositorio = Substitute.For<IUsuarioRepositorio>();
            _mapeamentoEntidade = Substitute.For<IUsuarioMapeamentoEntidade>();
            _mapeamentoViewModel = Substitute.For<IUsuarioMapeamentoViewModel>();
            _sessionManager = Substitute.For<ISessionManager>();
            _usuarioServico = new UsuarioServico(_usuarioRepositorio, _mapeamentoEntidade, _mapeamentoViewModel, _sessionManager);
        }

        [Fact]
        public void Test_Apagar()
        {
            // Arrange
            var id = 10;

            // Act
            _usuarioServico.Apagar(id);

            // Assert
            _usuarioRepositorio
                .Received()
                .Apagar(Arg.Is(10));
        }

        [Fact]
        public void Test_Cadastrar()
        {
            // Arrange
            var viewModelEsperado = new UsuarioCadastrarViewModel
            {
                Nome = "Chico Lucas",
                Endereco = "Rua Amazonas",
                Celular = "4799999999",
                Email = "chico@gmail.com",
                Senha = "12345678",
                ConfirmarSenha = "12345678",
                Cpf = "12312312300",
                Especialidade = "aaa",
                EhVoluntario = true,
                DataNascimento = new DateTime(2000, 1, 6),
            };

            var usuarioEsperado = new Usuario()
            {
                Nome = viewModelEsperado.Nome,
                Endereco = viewModelEsperado.Endereco,
                Celular = viewModelEsperado.Celular,
                Email = viewModelEsperado.Email,
                Senha = viewModelEsperado.Senha,
                ConfirmarSenha = viewModelEsperado.ConfirmarSenha,
                Cpf = viewModelEsperado.Cpf,
                Especialidade = viewModelEsperado.Especialidade,
                EhVoluntario = viewModelEsperado.EhVoluntario,
                DataNascimento= viewModelEsperado.DataNascimento
            };

            _mapeamentoEntidade.ConstruirCom(
                Arg.Is<UsuarioCadastrarViewModel>(viewModel =>
                    viewModel.Nome == viewModelEsperado.Nome), string.Empty)
                .Returns(usuarioEsperado);

            // Act
            _usuarioServico.Cadastrar(viewModelEsperado);

            // Assert
            _usuarioRepositorio.Received(1).Cadastrar(Arg.Is<Usuario>(
                usuario => ValidarUser(usuario, usuarioEsperado)));
        }
        private bool ValidarUser(Usuario usuario, Usuario usuarioEsperado)
        {
           
            usuario.Nome.Should().Be(usuarioEsperado.Nome);
            usuario.Endereco.Should().Be(usuarioEsperado.Endereco);
            usuario.Celular.Should().Be(usuarioEsperado.Celular);
            usuario.Email.Should().Be(usuarioEsperado.Email);
            usuario.Senha.Should().Be(usuarioEsperado.Senha);
            usuario.ConfirmarSenha.Should().Be(usuarioEsperado.ConfirmarSenha);
            usuario.Cpf.Should().Be(usuarioEsperado.Cpf);
            usuario.EhVoluntario.Should().Be(usuarioEsperado.EhVoluntario);
            usuario.DataNascimento.Should().Be(usuarioEsperado.DataNascimento);
            return true;
        }
    }
}
