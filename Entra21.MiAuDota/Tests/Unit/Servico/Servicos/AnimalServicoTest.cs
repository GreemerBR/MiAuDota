using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Unit.Servico.Servicos
{
    public class AnimalServicoTest
    {

        private readonly IAnimalServico _animalServico;
        private readonly IAnimalRepositorio _animalRepositorio;
        private readonly IAnimalMapeamentoEntidade _mapeamentoEntidade;
        private readonly IAnimalMapeamentoViewModel _mapeamentoViewModel;


        public AnimalServicoTest()
        {
            _animalRepositorio = Substitute.For<IAnimalRepositorio>();
            _mapeamentoEntidade = Substitute.For<IAnimalMapeamentoEntidade>();
            _mapeamentoViewModel = Substitute.For<IAnimalMapeamentoViewModel>();
            _animalServico = new AnimalServico(_animalRepositorio, _mapeamentoEntidade, _mapeamentoViewModel);

        }

        [Fact]
        public void Test_Apagar()
        {
            // Arrange
            var id = 10;

            // Act
            _animalServico.Apagar(id);

            // Assert
            _animalRepositorio
                .Received()
                .Apagar(Arg.Is(10));
        }
        [Fact]
        public void Test_Cadastrar()
        {
            // Arrange
            var viewModelEsperado = new AnimalCadastrarViewModel
            {
                Nome = "Tobias",
                Raca = "Vira-Lata",
                Especie = "Cachorro",
                Sobre = "muito legal",
                Vacinas = "Todas",
                Alergias = "Nenhuma",
                OutrasInformacoesMedicas = "atualmente gripado coitado",
                Foto = "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg",
                Idade = 2,
                Peso = 1.2,
                Altura = 0.3,
                Castrado = true,
                DataAdocao = new DateTime(2021,05,04),
                Genero = 1,
                Status = 2,
                UsuarioId = 1,
            };

            var animalEsperado = new Animal()
            {
                Nome = viewModelEsperado.Nome,
                Raca = viewModelEsperado.Raca,
                Especie = viewModelEsperado.Especie,
                Sobre = viewModelEsperado.Sobre,
                Vacinas = viewModelEsperado.Vacinas,
                Alergias = viewModelEsperado.Alergias,
                OutrasInformacoesMedicas = viewModelEsperado.OutrasInformacoesMedicas,
                Foto = viewModelEsperado.Foto,
                Idade = (Byte)viewModelEsperado.Idade,
                Peso = (Double)viewModelEsperado.Peso,
                Altura = (Double)viewModelEsperado.Altura,
                Castrado = viewModelEsperado.Castrado,
                DataAdocao = viewModelEsperado.DataAdocao,
                Genero = (GeneroAnimal)viewModelEsperado.Genero,
                Status = (StatusInstituicao)viewModelEsperado.Status,
                UsuarioId = viewModelEsperado.UsuarioId,

            };

            _mapeamentoEntidade.ConstruirCom(
                Arg.Is<AnimalCadastrarViewModel>(viewModel =>
                    viewModel.Nome == viewModelEsperado.Nome))
                .Returns(animalEsperado);

            // Act
            _animalServico.Cadastrar(viewModelEsperado);

            // Assert
            _animalRepositorio
                .Received(1).
                Cadastrar(Arg.Is<Animal>(animal => ValidarRaca(animal, animalEsperado)));
        }
        private bool ValidarRaca(Animal animal, Animal animalEsperado)
        {
            animal.Nome.Should().Be(animalEsperado.Nome);
            animal.Raca.Should().Be(animalEsperado.Raca);
            animal.Especie.Should().Be(animalEsperado.Especie);
            animal.Sobre.Should().Be(animalEsperado.Sobre);
            animal.Vacinas.Should().Be(animalEsperado.Vacinas);
            animal.Alergias.Should().Be(animalEsperado.Alergias);
            animal.OutrasInformacoesMedicas.Should().Be(animalEsperado.OutrasInformacoesMedicas);
            animal.Foto.Should().Be(animalEsperado.Foto);
            animal.Idade.Should().Be(animalEsperado.Idade);
            animal.Peso.Should().Be(animalEsperado.Peso);
            animal.Altura.Should().Be(animalEsperado.Altura);
            animal.Castrado.Should().Be(animalEsperado.Castrado);
            animal.DataAdocao.Should().Be(animalEsperado.DataAdocao);
            animal.Genero.Should().Be(animalEsperado.Genero);
            animal.Status.Should().Be(animalEsperado.Status);
            animal.UsuarioId.Should().Be(animalEsperado.UsuarioId);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }
    }
}
