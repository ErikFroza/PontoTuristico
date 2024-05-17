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
            try
            {
                bool apagado = _pontoTuristicoRepositorio.Apagar(id);

                if(apagado)
                {
                    TempData["MensagemSucesso"] = "Ponto turistico removido com sucesso!";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos remover o ponto turistico!";
                }

                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possivel remover o ponto turistico, mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Criar(PontoTuristicoModel pontoTuristico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pontoTuristicoRepositorio.Adicionar(pontoTuristico);
                    TempData["MensagemSucesso"] = "Ponto turistico cadastrado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(pontoTuristico);
            } 
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possivel cadastrar o ponto turistico, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public IActionResult Alterar(PontoTuristicoModel pontoTuristico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _pontoTuristicoRepositorio.Atualizar(pontoTuristico);
                    TempData["MensagemSucesso"] = "Ponto turistico alterado com sucesso!";
                    return RedirectToAction("Index");
                }

                return View("Editar", pontoTuristico);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não foi possivel atualizar o ponto turistico, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
