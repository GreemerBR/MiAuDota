using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class AnimalMapeamentoEntidade : IAnimalMapeamentoEntidade
    {
        private readonly ISessionManager _sessionManager;

        public AnimalMapeamentoEntidade(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        public void AtualizarCampos(Animal entity, AnimalEditarViewModel viewModel, string caminho = "")
        {
            entity.Nome = viewModel.Nome;
            entity.Raca = viewModel.Raca;
            entity.Especie = viewModel.Especie;
            entity.Sobre = viewModel.Sobre;
            entity.Vacinas = viewModel.Vacinas;
            entity.Alergias = viewModel.Alergias;
            entity.OutrasInformacoesMedicas = viewModel.OutrasInformacoesMedicas;

            if (!string.IsNullOrEmpty(caminho))
                entity.Foto = caminho;

            entity.Idade = viewModel.Idade;
            entity.Peso = viewModel.Peso;
            entity.Altura = viewModel.Altura;
            entity.Castrado = viewModel.Castrado;
            entity.DataAdocao = viewModel.DataAdocao;
            entity.Status = (StatusInstituicao)viewModel.Status;
            entity.Porte = DeterminarPorte(viewModel.Peso, viewModel.Altura);
            entity.UsuarioId = viewModel.UsuarioId;
        }

        public void AtualizarSenha(Animal entity, AnimalEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void AtualizarStatus(Animal entity, AnimalEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Animal ConstruirCom(AnimalCadastrarViewModel viewModel, string caminho)
        {
            return new Animal
            {
                Nome = viewModel.Nome,
                Raca = viewModel.Raca,
                Especie = viewModel.Especie,
                Sobre = viewModel.Sobre,
                Vacinas = viewModel.Vacinas,
                Alergias = viewModel.Alergias,
                OutrasInformacoesMedicas = viewModel.OutrasInformacoesMedicas,
                Foto = caminho,
                Idade = viewModel.Idade,
                Peso = viewModel.Peso,
                Altura = viewModel.Altura,
                Castrado = viewModel.Castrado,
                Genero = (GeneroAnimal)viewModel.Genero,
                Status = (StatusInstituicao)viewModel.Status,
                Porte = DeterminarPorte(viewModel.Peso, viewModel.Altura),
                UsuarioId = null,
                ProtetorId = _sessionManager.GetUser<Protetor>().Id
            };
        }

        private PorteDoAnimal DeterminarPorte(double peso, double altura)
        {
            if (peso <= 15 && altura <= 35)
                return PorteDoAnimal.Pequeno;
            else if (peso <= 25 && altura <= 49)
                return PorteDoAnimal.Medio;
            else
                return PorteDoAnimal.Grande;
        }
    }
}
