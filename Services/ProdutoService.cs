using GestaoPedidos.Api.Models;
using GestaoPedidos.Api.Repositories;

namespace GestaoPedidos.Api.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;

    public ProdutoService(IProdutoRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Produto>> ObterTodosAsync()
    {
        return await _repository.ObterTodosAsync();
    }

    public async Task<Produto?> ObterPorIdAsync(int id)
    {
        return await _repository.ObterPorIdAsync(id);
    }

    public async Task AdicionarAsync(Produto produto)
    {
        await _repository.AdicionarAsync(produto);
    }

    public async Task AtualizarAsync(Produto produto)
    {
        await _repository.AtualizarAsync(produto);
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var produto = await _repository.ObterPorIdAsync(id);

        if (produto is null)
        {
            return false;
        }

        await _repository.RemoverAsync(produto);

        return true;
    }
}