using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace NovaTech.Models;

    [Table("Produtos")]
    public class Produto
    {
    
	[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

	[Required]
	[StringLength(255)]
	public string Nome { get; set; }

    [Required]
	[StringLength(255)]
	public string Cor { get; set; }

    [Required]
	public int Categoria_id { get; set; }
	[ForeignKey("Categoria_id")]
	public Categoria Categoria { get; set; }

    [Required]
	[StringLength(1000)]
	public string Descricao { get; set; }

    [Required]
	public decimal Preco { get; set; }

    [Required]
	public int Quantidade { get; set; }

   [Required]
	[StringLength(200)]
	public string Imagem { get; set; }

    }
