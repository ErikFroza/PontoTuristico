using PontoTuristico.Models;

namespace PontoTuristico.Repositorio
{
    public interface IPontoTuristicoRepositorio
    {
        PontoTuristicoModel ListarPorId(int id);
        List<PontoTuristicoModel> BuscarTodos();
        PontoTuristicoModel Adicionar(PontoTuristicoModel pontoTuristico);
        PontoTuristicoModel Atualizar(PontoTuristicoModel pontoTuristico);
        bool Apagar(int id);
    }
}
