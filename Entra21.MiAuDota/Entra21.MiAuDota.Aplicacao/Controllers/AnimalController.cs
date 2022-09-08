using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("animal")]
    public class AnimalController : Controller
    {
        //private readonly IAnimalServico _animalServico;
        //private readonly IWebHostEnvironment _webHostEnvironment;

        //public AnimalController(IAnimalServico animalServico,
        //       IWebHostEnvironment webHostEnvironment)
        //{
        //    _animalServico = animalServico;
        //    _webHostEnvironment = webHostEnvironment;
        //}

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet("galeria")]
        //public IActionResult Galeria()
        //{
        //    var animais = _animalServico.ObterTodos();

        //    ViewBag.CaminhoServidor = _webHostEnvironment.WebRootPath;

        //    return View(animais);
        //}

        //[HttpGet("obterTodos")]
        //public IActionResult ObterTodos()
        //{
        //    var animais = _animalServico.ObterTodos();

        //    return Ok(animais);
        //}

        //[HttpGet("obterPorId")]
        //public IActionResult ObterPorId([FromQuery] int id)
        //{
        //    var animais = _animalServico.ObterPorId(id);

        //    return Ok(animais);
        //}

        //[HttpPost("cadastrar")]
        //public IActionResult Cadastrar([FromForm] AnimalCadastrarViewModel animalCadastrarViewModel)
        //{
        //    if (!ModelState.IsValid)
        //        return UnprocessableEntity(ModelState);

        //    var animal = _animalServico.Cadastrar(animalCadastrarViewModel, _webHostEnvironment.WebRootPath);

        //    return Ok(animal);
        //}

        //[HttpPost("editar")]
        //public IActionResult Editar([FromForm] AnimalEditarViewModel animalEditarViewModel)
        //{
        //    if (!ModelState.IsValid)
        //        return UnprocessableEntity(ModelState);

        //    var atualizou = _animalServico.Editar(animalEditarViewModel, _webHostEnvironment.WebRootPath);

        //    return Ok(new { status = atualizou });
        //}

        //[HttpGet("apagar")]
        //public IActionResult Apagar([FromQuery] int id)
        //{
        //    var apagou = _animalServico.Apagar(id);

        //    if (!apagou)
        //        return NotFound();

        //    return Ok();
        //}
    }
}
