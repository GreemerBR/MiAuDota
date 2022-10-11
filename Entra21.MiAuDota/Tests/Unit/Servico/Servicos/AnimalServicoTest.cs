using Entra21.MiAuDota.Repositorio.Entidades;
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
            var viewModel = new AnimalCadastrarViewModel
            {
                

            };


            // Act
            _animalServico.Cadastrar(viewModel);

            // Assert
            _animalRepositorio
                .Received(1).
                Cadastrar(Arg.Is<Animal>(animal => ValidarRaca(animal, viewModel)));
        }
        private bool ValidarRaca(Animal animal, AnimalCadastrarViewModel viewModel)
        {
            animal.Nome.Should().Be(viewModel.Nome);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }
    }
}
