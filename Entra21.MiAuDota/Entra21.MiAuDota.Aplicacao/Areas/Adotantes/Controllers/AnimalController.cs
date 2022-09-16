﻿using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Adotantes.Controllers
{
    [Area("Adotantes")]
    [Route("/adotantes/animal")]
    public class AnimalController
        : BaseController<Animal, IAnimalServico, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel, IAnimalRepositorio, IAnimalMapeamentoEntidade>
    {
        public AnimalController(IAnimalServico servico) : base(servico)
        {
        }
    }
}