using PontoTuristico.Enums;
using System.ComponentModel.DataAnnotations;

namespace PontoTuristico.Models
{
    public class PontoTuristicoModel
    {
        public int Id {  get; set; }
        [Required(ErrorMessage = "Digite o nome do ponto turistico")]
        [StringLength(100, ErrorMessage = "O campo nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o cep do ponto turistico")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Selecione uma opção.")]
        public EstadoEnum? Estado { get; set; }
        [Required(ErrorMessage = "Digite a cidade do ponto turistico")]
        [StringLength(100, ErrorMessage = "O campo cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Digite a referencia do ponto turistico")]
        [StringLength(100, ErrorMessage = "O campo referência deve ter no máximo 100 caracteres.")]
        public string Referencia { get; set; }
        [Required(ErrorMessage = "Digite a descrição do ponto turistico")]
        [StringLength(100, ErrorMessage = "O campo descrição deve ter no máximo 100 caracteres.")]
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
