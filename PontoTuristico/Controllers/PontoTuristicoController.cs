using Microsoft.AspNetCore.Mvc;
using PontoTuristico.Models;
using PontoTuristico.Repositorio;
using System.Numerics;

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

        public IActionResult Detalhe(int id)
        {
            PontoTuristicoModel pontoTuristico = _pontoTuristicoRepositorio.ListarPorId(id);
            return View(pontoTuristico);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id)
        {
            PontoTuristicoModel pontoTuristico = _pontoTuristicoRepositorio.ListarPorId(id);
            return View(pontoTuristico);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            PontoTuristicoModel pontoTuristico = _pontoTuristicoRepositorio.ListarPorId(id);
            return View(pontoTuristico);
        }

        public IActionResult Apagar(int id)
        {
            _pontoTuristicoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(PontoTuristicoModel pontoTuristico)
        {
            _pontoTuristicoRepositorio.Adicionar(pontoTuristico);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(PontoTuristicoModel pontoTuristico)
        {
            _pontoTuristicoRepositorio.Atualizar(pontoTuristico);
            return RedirectToAction("Index");
        }
    }
}
