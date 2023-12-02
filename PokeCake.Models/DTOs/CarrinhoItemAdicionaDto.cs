using System.ComponentModel.DataAnnotations;

namespace PokeCake.Models.DTOs;
internal class CarrinhoItemAdicionaDto
{
    [Required]
    public int CarrinhoId { get; set; }
    [Required]
    public int ProdutoId { get; set; }
    [Required]
    public int Quantidade { get; set; }
}
