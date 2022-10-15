using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.InjecoesDependencia;
using Entra21.MiAuDota.Servico.InjecoesDependencia;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.AreaViewLocationFormats.Clear();
    options.AreaViewLocationFormats.Add("/Areas/{2}/Views/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Areas/{2}/Views/{1}/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Areas/{2}/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
    options.AreaViewLocationFormats.Add("/Views/{0}.cshtml");
});
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

builder.Services
    .AdicionarServicos()
    .AdicionarRepositorios()
    .AdicionarAutenticacoes()
    .AdicionarMapeamentoEntidades()
    .AdicionarMapeamentoViewModel()
    .AdicionarEntityFramework(builder.Configuration);

builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();


var app = builder.Build();
app.UseSession();

using (var scopo = app.Services.CreateScope())
{
    var contexto = scopo.ServiceProvider
        .GetService<MiAuDotaContexto>();
    contexto.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoint =>
{
    endpoint.MapAreaControllerRoute(
        name: "AreaAdministradores",
        areaName: "Administradores",
        pattern: "Administradores/{controller=Home}/{action=Index}/{id?}");

    endpoint.MapAreaControllerRoute(
        name: "AreaProtetores",
        areaName: "Protetores",
        pattern: "Protetores/{controller=Home}/{action=Index}/{id?}");

    endpoint.MapAreaControllerRoute(
        name: "AreaPublico",
        areaName: "Publico",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoint.MapAreaControllerRoute(
        name: "AreaUsuarios",
        areaName: "Usuarios",
        pattern: "Usuarios/{controller=Home}/{action=Index}/{id?}");

    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
