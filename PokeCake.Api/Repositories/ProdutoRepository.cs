using Microsoft.EntityFrameworkCore;
using PokeCake.Api.Context;
using PokeCake.Api.Entities;

namespace PokeCake.Api.Repositories;

public class ProdutoRepository: IProdutoRepository
{
    private readonly PokeCakeContext _context;

    public ProdutoRepository(PokeCakeContext context)
    {
        _context = context;
    }

    public async Task<Produto> GetProduto(int id)
    {
        var produto = await _context.Produtos
            .Include(c => c.Categoria)
            .SingleOrDefaultAsync(c => c.Id == id);

        return produto;
    }

    public async Task<IEnumerable<Produto>> GetProdutos()
    {
        var produtos = await _context.Produtos
            .Include(p => p.Categoria)
            .ToListAsync();

        return produtos;
    }

    public async Task<IEnumerable<Produto>> GetProdutosPorCategoria(int id)
    {
        var produtos = await _context.Produtos
            .Include(p => p.Categoria)
            .Where(p => p.CategoriaId == id).ToListAsync();

        return produtos;
    }

    public async Task<IEnumerable<Categoria>> GetCategorias()
    {
        var categorias = await _context.Categorias.ToListAsync();
        return categorias;
    }
}
