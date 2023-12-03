using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokeCake.Api.Mappings;
using PokeCake.Api.Repositories;
using PokeCake.Models.DTOs;

namespace PokeCake.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CarrinhoCompraController : ControllerBase
{
    private readonly ICarrinhoCompraRepository carrinhoComprasRepo;
    private readonly IProdutoRepository produtoRepo;

    private ILogger<CarrinhoCompraController> logger;

    public CarrinhoCompraController(ICarrinhoCompraRepository carrinhoComprasRepo, IProdutoRepository produtoRepo, ILogger<CarrinhoCompraController> logger)
    {
        this.carrinhoComprasRepo = carrinhoComprasRepo;
        this.produtoRepo = produtoRepo;
        this.logger = logger;
    }

    [HttpGet]
    [Route("{usuarioId}/GetItens")]
    public async Task<ActionResult<IEnumerable<CarrinhoItemDto>>> GetItens(string usuarioId)
    {
        try
        {
            var carrinhoItens = await carrinhoComprasRepo.GetItens(usuarioId);
            if (carrinhoItens == null)
            {
                return NoContent(); 
            }

            var produtos = await this.produtoRepo.GetProdutos();
            if (produtos == null)
            {
                throw new Exception("Não foram encontrados produtos cadastrados.");
            }

            var carrinhoItensDto = carrinhoItens.ConverterCarrinhoItensParaDto(produtos);
            return Ok(carrinhoItensDto);
        }
        catch (Exception ex)
        {
            logger.LogError("## Erro ao obter itens do carrinho");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CarrinhoItemDto>> GetItem(int id)
    {
        try
        {
            var carrinhoItem = await carrinhoComprasRepo.GetItem(id);
            if (carrinhoItem == null)
            {
                return NotFound($"Item não encontrado"); 
            }

            var produto = await produtoRepo.GetProduto(carrinhoItem.ProdutoId);

            if (produto == null)
            {
                return NotFound($"Item não existe na fonte de dados");
            }
            var cartItemDto = carrinhoItem.ConverterCarrinhoItemParaDto(produto);

            return Ok(cartItemDto);
        }
        catch (Exception ex)
        {
            logger.LogError($"## Erro ao obter o item ={id} do carrinho");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CarrinhoItemDto>> PostItem([FromBody]
    CarrinhoItemAdicionaDto carrinhoItemAdicionaDto)
    {
        try
        {
            var novoCarrinhoItem = await carrinhoComprasRepo.AdicionaItem(carrinhoItemAdicionaDto);

            if (novoCarrinhoItem == null)
            {
                return NoContent(); 
            }

            var produto = await produtoRepo.GetProduto(novoCarrinhoItem.ProdutoId);

            if (produto == null)
            {
                throw new Exception($"Produto não localizado (Id:({carrinhoItemAdicionaDto.ProdutoId})");
            }

            var novoCarrinhoItemDto = novoCarrinhoItem.ConverterCarrinhoItemParaDto(produto);

            return CreatedAtAction(nameof(GetItem), new { id = novoCarrinhoItemDto.Id },
                novoCarrinhoItemDto);

        }
        catch (Exception ex)
        {
            logger.LogError("## Erro criar um novo item no carrinho");
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<CarrinhoItemDto>> DeleteItem(int id)
    {
        try
        {
            var carrinhoItem = await carrinhoComprasRepo.DeletaItem(id);

            if (carrinhoItem == null) 
            {
                return NotFound();
            }

            var produto = await produtoRepo.GetProduto(carrinhoItem.ProdutoId);

            if (produto is null) 
            {
                return NotFound();
            }

            var carrinhoItemDto = carrinhoItem.ConverterCarrinhoItemParaDto(
                produto);
            return Ok(carrinhoItemDto);

            

        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
