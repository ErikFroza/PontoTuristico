using Microsoft.AspNetCore.Mvc;
using PontoTuristico.Models;
using PontoTuristico.Repositorio;

namespace PontoTuristico.Controllers
{
    public class PontoTuristicoController : Controller
    {

        private readonly IPontoTuristicoRepositorio _pontoTuristicoRepositorio;

        public PontoTuristicoController(IPontoTuristicoRepositorio pontoTuristicoRepositorio)
        {
            _pontoTuristicoRepositorio = pontoTuristicoRepositorio;
        }

        public IActionResult Index()
        {
            List<PontoTuristicoModel> pontoTuristico = _pontoTuristicoRepositorio.BuscarTodos();
            return View(pontoTuristico);
        }

        public IActionResult Detalhe()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(PontoTuristicoModel pontoTuristico)
        {
            _pontoTuristicoRepositorio.Adicionar(pontoTuristico);
            return RedirectToAction("Index");
        }
    }
}
