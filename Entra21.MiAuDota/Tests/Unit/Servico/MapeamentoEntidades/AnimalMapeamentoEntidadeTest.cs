using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace Tests.Unit.Servico.MapeamentoEntidades
{
	public class AnimalMapeamentoEntidadeTest
    {
        private readonly IAnimalMapeamentoEntidade _animalMapeamentoEntidade;
        private readonly ISessionManager _sessionManager;

        public AnimalMapeamentoEntidadeTest()
        {
             _sessionManager = Substitute.For<ISessionManager>();
            _animalMapeamentoEntidade = new AnimalMapeamentoEntidade(_sessionManager);
        }

        [Fact]
        public void Test_ConstruirCom()
        {
            // Arrange
            var viewModel = new AnimalCadastrarViewModel
            {
                Nome = "Tobias",
                Raca = "Dog",
                Especie = "Cachorro",
                Sobre = "Animal muito legal",                
                Foto = "275E5840-F48D-4E7B-9156-D038C9AB89B4.jpg",
                Idade = 2,
                Peso = 2.2,
                Altura = 0.5,
                Castrado = false,
                Genero = 1,
                Status = 0,
                UsuarioId = null,
                ProtetorId = 1,

                 DataAdocao = null
                //DataAdocao = new DateTime(2020, 5, 11)

            };

            var protetor = new Protetor
            {
                Id = 30
            };

            _sessionManager.GetUser<Protetor>().Returns(protetor);

            // Act
            var animal = _animalMapeamentoEntidade.ConstruirCom(viewModel);

            // Assert
            animal.Nome.Should().Be(viewModel.Nome);
            animal.Raca.Should().Be(viewModel.Raca);
            animal.Especie.Should().Be((EspecieAnimal)viewModel.Especie);
            animal.Sobre.Should().Be(viewModel.Sobre);            
            animal.Foto.Should().Be(viewModel.Foto);
            animal.Idade.Should().Be(viewModel.Idade);
            animal.Peso.Should().Be(viewModel.Peso);
            animal.Altura.Should().Be(viewModel.Altura);
            animal.Castrado.Should().Be(viewModel.Castrado);
            animal.Genero.Should().Be((GeneroAnimal)viewModel.Genero);
            animal.Status.Should().Be((StatusInstituicao)viewModel.Status);
            animal.UsuarioId.Should().BeNull();
            animal.ProtetorId.Should().Be(protetor.Id);
            animal.DataAdocao.Should().BeNull();
        }
        [Fact]
        public void Test_AtualizarCampos()
        {
            // Arrange
            var animal = new Animal
            {
                Sobre = "pequeno e loiro",                
                Idade = 8,
                Peso = 18.5,
                Altura = 0.3,
                Castrado = false,
                DataAdocao = new DateTime (2020,05,06),
                Status = StatusInstituicao.EmTratamento,
                UsuarioId = null
            };

            var viewModelEditar = new AnimalEditarViewModel
            {
                Sobre = "pequeno e acinzentado",
                Idade = 7,
                Peso = 1.5,
                Altura = 0.2,
                Castrado = true,
                DataAdocao = null,
                Status = StatusInstituicao.AptoParaAdocao,
                UsuarioId = 1
            };

            // Act
            _animalMapeamentoEntidade.AtualizarCampos(animal, viewModelEditar);

            // Assert
            animal.Sobre.Should().Be(viewModelEditar.Sobre);
            animal.Idade.Should().Be(viewModelEditar.Idade);
            animal.Peso.Should().Be(viewModelEditar.Peso);
            animal.Altura.Should().Be(viewModelEditar.Altura);
            animal.Castrado.Should().Be(viewModelEditar.Castrado);
            animal.DataAdocao.Should().Be(viewModelEditar.DataAdocao);
            animal.Status.Should().Be(viewModelEditar.Status);
            animal.UsuarioId.Should().Be(viewModelEditar.UsuarioId);
        }

    }
}
