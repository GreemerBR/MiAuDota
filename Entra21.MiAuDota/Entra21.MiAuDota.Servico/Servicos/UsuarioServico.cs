using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class UsuarioServico: IUsuarioServico
    {

        private readonly IRepositorio<Usuario> _usuarioRespositorio;
        private readonly IUsuarioMapeamentoEntidade _mapeamentoEntidade;

        public UsuarioServico(
            IRepositorio<Usuario> usuarioRespositorio,
            IUsuarioMapeamentoEntidade mapeamentoEntidade) 
        {
            _usuarioRespositorio = usuarioRespositorio;
            _mapeamentoEntidade = mapeamentoEntidade;
        }

        public bool Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario Cadastrar(UsuarioCadastrarViewModel viewModel)
        {
            var usuario = _mapeamentoEntidade.ConstruirCom(viewModel);

            _usuarioRespositorio.Cadastrar(usuario);

            return usuario;
        }

        public bool Editar(UsuarioEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Usuario? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ObterTodos(string pesquisa)
        {
            throw new NotImplementedException();
        }
    }
}

