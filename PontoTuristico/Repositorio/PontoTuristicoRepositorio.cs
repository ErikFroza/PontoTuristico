using Microsoft.EntityFrameworkCore;
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

        public PontoTuristicoModel ListarPorId(int id)
        {
            return _bancoContext.PontoTuristico.FirstOrDefault(x => x.Id == id);
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

        public PontoTuristicoModel Atualizar(PontoTuristicoModel pontoTuristico)
        {
            PontoTuristicoModel pontoTuristicoDB = ListarPorId(pontoTuristico.Id);

            if (pontoTuristicoDB == null) throw new SystemException("Houve um erro na atualização do ponto turistico!");

            pontoTuristicoDB.DataAtualizacao = DateTime.Now;
            pontoTuristicoDB.Nome = pontoTuristico.Nome;
            pontoTuristicoDB.Cep = pontoTuristico.Cep;
            pontoTuristicoDB.Estado = pontoTuristico.Estado;
            pontoTuristicoDB.Cidade = pontoTuristico.Cidade;
            pontoTuristicoDB.Referencia = pontoTuristico.Referencia;
            pontoTuristicoDB.Descricao = pontoTuristico.Descricao;

            _bancoContext.PontoTuristico.Update(pontoTuristicoDB);
            _bancoContext.SaveChanges();
            
            return pontoTuristicoDB;
        }

        public bool Apagar(int id)
        {
            PontoTuristicoModel pontoTuristicoDB = ListarPorId(id);

            if (pontoTuristicoDB == null) throw new SystemException("Houve um erro na deleção do ponto turistico!");

            _bancoContext.PontoTuristico.Remove(pontoTuristicoDB);
            _bancoContext.SaveChanges();
            
            return true;
        }
    }
}
