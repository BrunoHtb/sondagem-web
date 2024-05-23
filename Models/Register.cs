using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace SondagemPR.Models
{
    [Table("sondagem_cadastro")]
    public class Register
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do ponto")]
        [MinLength(5, ErrorMessage = "O nome deve ter pelo menos 5 caracteres")]
        [MaxLength(30, ErrorMessage = "O nome deve no máximo,30 caracteres")]
        [Column("nome")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "A latitude prevista deve no máximo ,30 caracteres")]
        [Column("latitude_prevista")]
        public string LatitudePrevista { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "A longitude prevista deve no máximo 30 caracteres")]
        [Column("longitude_prevista")]
        public string LongitudePrevista { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "A latitude deve no máximo 30 caracteres")]
        [Column("latitude")]
        public string Latitude { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "A longitude deve no máximo 30 caracteres")]
        [Column("longitude")]
        public string Longitude { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "A rodovia deve no máximo 10 caracteres")]
        [Column("rodovia")]
        public string Rodovia { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "O km deve no máximo 10 caracteres")]
        [Column("km")]
        public string Km { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "O metro deve no máximo 10 caracteres")]
        [Column("metro")]
        public string Metro { get; set; } = string.Empty;

        [MaxLength(15, ErrorMessage = "O trecho deve no máximo 15 caracteres")]
        [Column("trecho")]
        public string Trecho { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "O lote deve no máximo 10 caracteres")]
        [Column("lote")]
        public string Lote { get; set; } = string.Empty;

        [Column("foto")]
        public string NomeFoto { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "A area deve no máximo 10 caracteres")]
        [Column("area")]
        public string Area {  get; set; } = string.Empty;

        [Column("camada")]
        public string Camadas { get; set; } = string.Empty;

        [Column("espessura")]
        public string Espessuras { get; set; } = string.Empty;

        [MaxLength(15, ErrorMessage = "A espessura deve no máximo 15 caracteres")]
        [Column("status")]
        public string Status { get; set; } = string.Empty;

        [Column("observacao")]
        public string Observacao { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "A entrega deve no máximo 30 caracteres")]
        [Column("entrega")]
        public string Entrega { get; set; } = string.Empty;

        [MaxLength(50, ErrorMessage = "O nome deve no máximo 50 caracteres")]
        [Column("regional")]
        public string Regional { get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "O nome deve no máximo 30 caracteres")]
        [Column("data_cadastro")]
        public string DataCadastro { get; set; } = string.Empty;

        [MaxLength(10, ErrorMessage = "O nome deve no máximo 10 caracteres")]
        [Column("login")]
        public string UsuarioCampo { get; set; } = string.Empty;   
    }
}
