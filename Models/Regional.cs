using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SondagemPR.Models
{
    [Table("regional")]
    public class Regional
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do ponto")]
        [MinLength(5, ErrorMessage = "O nome deve ter pelo menos 5 caracteres")]
        [MaxLength(30, ErrorMessage = "O nome deve no máximo,30 caracteres")]
        [Column("nome_regional")]
        public string Name { get; set; } = string.Empty;
    }
}
