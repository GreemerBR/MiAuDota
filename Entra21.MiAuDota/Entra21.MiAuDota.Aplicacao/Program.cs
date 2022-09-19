using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.InjecoesDependencia;
using Entra21.MiAuDota.Servico.InjecoesDependencia;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;

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

builder.Services.AddControllersWithViews();

builder.Services
    .AdicionarEntityFramework(builder.Configuration)
    .AdicionarServicos()
    .AdicionarRepositorios()
    .AdicionarMapeamentoEntidades();

var app = builder.Build();


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
        name: "AreaUsuarios",
        areaName: "Usuarios",
        pattern: "Usuarios/{controller=HomeDriver}/{action=Index}/{id?}");

    endpoint.MapAreaControllerRoute(
        name: "AreaProtetores",
        areaName: "Protetores",
        pattern: "Protetores/{controller=Home}/{action=Index}/{id?}");

    endpoint.MapAreaControllerRoute(
        name: "AreaPublic",
        areaName: "Public",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoint.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
