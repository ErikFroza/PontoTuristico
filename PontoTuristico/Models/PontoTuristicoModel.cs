using PontoTuristico.Enums;

namespace PontoTuristico.Models
{
    public class PontoTuristicoModel
    {
        public int Id {  get; set; }    
        public string Nome { get; set; }
        public string Cep { get; set; }
        public EstadoEnum Estado { get; set; }
        public string Cidade { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
