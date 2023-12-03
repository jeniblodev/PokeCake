using Microsoft.EntityFrameworkCore;
using PokeCake.Api.Context;
using PokeCake.Api.Entities;
using PokeCake.Models.DTOs;

namespace PokeCake.Api.Repositories;

public class CarrinhoCompraRepository : ICarrinhoCompraRepository
{
    private readonly PokeCakeContext _context;

    public CarrinhoCompraRepository(PokeCakeContext context)
    {
        _context = context;
    }

    private async Task<bool> CarrinhoItemExiste(int carrinhoId, int produtoId)
    {
        return await _context.CarrinhoItens.AnyAsync(c => c.CarrinhoId == carrinhoId && c.ProdutoId == produtoId);
    }

    public async Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
    {
        if (await CarrinhoItemExiste(carrinhoItemAdicionaDto.CarrinhoId,
            carrinhoItemAdicionaDto.ProdutoId) == false)
        {
            var item = await (from produto in _context.Produtos
                              where produto.Id == carrinhoItemAdicionaDto.ProdutoId
                              select new CarrinhoItem
                              {
                                  CarrinhoId = carrinhoItemAdicionaDto.CarrinhoId,
                                  ProdutoId = produto.Id,
                                  Quantidade = carrinhoItemAdicionaDto.Quantidade
                              }).SingleOrDefaultAsync();


            if (item is not null)
            {
                var resultado = await _context.CarrinhoItens.AddAsync(item);
                await _context.SaveChangesAsync();
                return resultado.Entity;
            }
        }
        return null;
    }

    public Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAtualizaQuantidadeDto carrinhoItemAtualizaQuantidadeDto)
    {
        throw new NotImplementedException();
    }

    public Task<CarrinhoItem> DeletaItem(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<CarrinhoItem> GetItem(int id)
    {
        return await (from carrinho in _context.Carrinhos
                      join carrinhoItem in _context.CarrinhoItens
                      on carrinho.Id equals carrinhoItem.CarrinhoId
                      where carrinhoItem.Id == id
                      select new CarrinhoItem
                      {
                          Id = carrinhoItem.Id,
                          ProdutoId = carrinhoItem.ProdutoId,
                          Quantidade = carrinhoItem.Quantidade,
                          CarrinhoId = carrinhoItem.CarrinhoId
                      }).SingleOrDefaultAsync();
    }

    public async Task<IEnumerable<CarrinhoItem>> GetItens(string usuarioId)
    {
        return await (from carrinho in _context.Carrinhos
                      join carrinhoItem in _context.CarrinhoItens
                      on carrinho.Id equals carrinhoItem.CarrinhoId
                      where carrinho.UsuarioId.ToString() == usuarioId
                      select new CarrinhoItem
                      {
                          Id = carrinhoItem.Id,
                          ProdutoId = carrinhoItem.ProdutoId,
                          Quantidade = carrinhoItem.Quantidade,
                          CarrinhoId = carrinhoItem.CarrinhoId
                      }).ToListAsync();
    }
}
