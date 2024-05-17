using PontoTuristico.Models;

namespace PontoTuristico.Repositorio
{
    public interface IPontoTuristicoRepositorio
    {
        List<PontoTuristicoModel> BuscarTodos();
        PontoTuristicoModel Adicionar(PontoTuristicoModel pontoTuristico);
    }
}
