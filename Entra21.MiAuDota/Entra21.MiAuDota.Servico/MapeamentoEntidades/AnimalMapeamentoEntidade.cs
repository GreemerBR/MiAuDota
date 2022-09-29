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

        public void AtualizarCampos(Animal entity, AnimalEditarViewModel viewModel)
        {
            entity.Sobre = viewModel.Sobre;
            entity.Vacinas = viewModel.Vacinas;
            entity.Alergias = viewModel.Alergias;
            entity.OutrasInformacoesMedicas = viewModel.OutrasInformacoesMedicas;
            entity.Foto = viewModel.Foto;
            entity.Idade = viewModel.Idade;
            entity.Peso = viewModel.Peso;
            entity.Altura = viewModel.Altura;
            entity.Castrado = viewModel.Castrado;
            entity.DataAdocao = viewModel.DataAdocao;
            entity.Status = (StatusInstituicao)viewModel.Status;
            entity.UsuarioId = viewModel.UsuarioId;
        }

        public Animal ConstruirCom(AnimalCadastrarViewModel viewModel)
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
                Foto = viewModel.Foto,
                Idade = viewModel.Idade.GetValueOrDefault(),
                Peso = viewModel.Peso.GetValueOrDefault(),
                Altura = viewModel.Altura.GetValueOrDefault(),
                Castrado = viewModel.Castrado,
                Genero = (GeneroAnimal)viewModel.Genero,
                Status = (StatusInstituicao)viewModel.Status,
                UsuarioId = null,
                ProtetorId = _sessionManager.GetUser<Protetor>().Id
            };
        }
    }
}
