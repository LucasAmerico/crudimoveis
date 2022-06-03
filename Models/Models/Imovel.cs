using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class Imovel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Tipo do Imóvel")]
        public string TipoDoImovel { get; set; }

        [Required(ErrorMessage = "Informe o valor de venda")]
        public decimal ValorDeVenda { get; set; }

        [Required(ErrorMessage = "Informe o valor de locação")]
        public decimal ValorDeLocacao { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o número")]
        public int Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe o estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe o cep")]
        public string Cep { get; set; }
    }
}
