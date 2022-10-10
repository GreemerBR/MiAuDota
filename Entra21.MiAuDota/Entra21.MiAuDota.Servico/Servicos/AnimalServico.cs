﻿using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.Helpers;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AnimalServico
        : BaseServico<Animal, Administrador, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel, IAnimalRepositorio, IAnimalMapeamentoEntidade, IAnimalMapeamentoViewModel>,
        IAnimalServico
    {
        public AnimalServico(
            IAnimalRepositorio baseRepositorio, 
            IAnimalMapeamentoEntidade baseMapeamentoEntidade, 
            IAnimalMapeamentoViewModel mapeamentoViewModel, 
            ISessionManager sessionManager) 
            : base(
                  baseRepositorio, 
                  baseMapeamentoEntidade, 
                  mapeamentoViewModel, 
                  sessionManager)
        {
        }

        public Animal CadastrarAnimal(AnimalCadastrarViewModel viewModel, string caminhoArquivos)
        {
            var caminho = SalvarArquivo(viewModel, caminhoArquivos);

            var entity = _baseMapeamentoEntidade.ConstruirCom(viewModel);

            entity.Foto = caminho;

            _baseRepositorio.Cadastrar(entity);

            return entity;
        }

        private string SalvarArquivo(AnimalCadastrarViewModel viewModel, string caminhoArquivos, string? arquivoAntigo = "")
        {
            if (viewModel.Arquivo == null)
                return string.Empty;

            var caminhoPastaImagens = Path.Combine(caminhoArquivos, ArquivoHelper.ObterCaminhoPastas());

            if (!Directory.Exists(caminhoPastaImagens))
                Directory.CreateDirectory(caminhoPastaImagens);

            if (!string.IsNullOrEmpty(arquivoAntigo))
                ApagarArquivoAntigo(caminhoPastaImagens, arquivoAntigo);

            var informacaoDoArquivo = new FileInfo(viewModel.Arquivo.FileName);
            var nomeArquivo = Guid.NewGuid() + informacaoDoArquivo.Extension;

            var caminhoArquivo = Path.Combine(caminhoPastaImagens, nomeArquivo);

            using (var stream = new FileStream(caminhoArquivo, FileMode.Create))
            {
                viewModel.Arquivo.CopyTo(stream);

                return nomeArquivo;
            }
        }

        private void ApagarArquivoAntigo(string caminhoPastaImagens, string arquivoAntigo)
        {
            var caminhoArquivoAntigo = Path.Join(caminhoPastaImagens, arquivoAntigo);

            if (File.Exists(caminhoArquivoAntigo))
                File.Delete(caminhoArquivoAntigo);
        }
    }
}
