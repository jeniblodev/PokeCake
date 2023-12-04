namespace PokeCake.Api.Entities;

public class Carrinho
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }

    public int ClienteId { get; set; }

    public ICollection<CarrinhoItem> Itens { get; set; } = new List<CarrinhoItem>();
}
