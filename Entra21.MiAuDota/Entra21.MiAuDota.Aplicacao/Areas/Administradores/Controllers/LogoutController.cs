﻿using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [AdministradorEstaLogado]
    [Area("Administradores")]
    [Route("administradores/Logout")]
    public class LogoutController : Controller
    {
        private readonly ILogonServico _logonServico;

        public LogoutController(ILogonServico logonServico)
        {
            _logonServico = logonServico;
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            _logonServico.Logout<Administrador>();
            return RedirectToAction("Index", "Home", "Publico");
        }
    }
}
