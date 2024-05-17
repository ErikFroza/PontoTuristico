using PontoTuristico.Data;
using PontoTuristico.Models;

namespace PontoTuristico.Repositorio
{
    public class PontoTuristicoRepositorio : IPontoTuristicoRepositorio
    {

        private readonly BancoContext _bancoContext;

        public PontoTuristicoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<PontoTuristicoModel> BuscarTodos()
        {
            return _bancoContext.PontoTuristico.ToList();
        }

        public PontoTuristicoModel Adicionar(PontoTuristicoModel pontoTuristico)
        {
            pontoTuristico.DataCadastro = DateTime.Now;
            _bancoContext.PontoTuristico.Add(pontoTuristico);
            _bancoContext.SaveChanges();
            return pontoTuristico;
        }

    }
}
