using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Servico.MapeamentoEntidades
{
    public  class AnimalMapeamentoEntidadeTest
    {
        private readonly IAnimalMapeamentoEntidade _animalMapeamentoEntidade;
        private readonly ISessionManager _session;

        public AnimalMapeamentoEntidadeTest()
        {
            _session = Substitute.For<ISessionManager>();
            _animalMapeamentoEntidade = new AnimalMapeamentoEntidade(_session);
        }


    }
}
