using GestaoPedidos.Api.Models;

namespace GestaoPedidos.Api.Services;

public interface IProdutoService
{
    Task<List<Produto>> ObterTodosAsync();

    Task<Produto?> ObterPorIdAsync(int id);

    Task AdicionarAsync(Produto produto);

    Task AtualizarAsync(Produto produto);

    Task<bool> RemoverAsync(int id);
}