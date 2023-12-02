using System.ComponentModel.DataAnnotations;

namespace PokeCake.Api.Entities;

public class Categoria
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    public string Icone { get; set; } = string.Empty;

    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
