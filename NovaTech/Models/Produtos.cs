using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NovaTech.Models

    [Table("Produtos")]
    public class Produtos
    {
    
	[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

	[Required]
	[StringLength(30)]
	public string Nome { get; set; }

    [Required]
	[StringLength(25)]
	public string Cor { get; set; }

    }
