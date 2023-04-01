using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prestacao_de_servico.Models
{
    [Table("Cadastros")]
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Rua { get; set; }

        [Required]
        public int Numero { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }
                        
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem.")]
        public string ConfirmarSenha { get; set; }

        [Required]
        public TipoUsuario Tipo { get; set; }

        [Required]
        public TipoServico Servico { get; set; }

        public virtual Login Login { get; set; }
    }

    public enum TipoUsuario
    {
        Usuario,
        PrestadorServico
    }

    public enum TipoServico
    {
        Hidraulica,
        Eletrica,
        Pedreiro,
        Soldagem,
        Pintura,
        Baba,
        CuidadorDeAnimais
    }
}

