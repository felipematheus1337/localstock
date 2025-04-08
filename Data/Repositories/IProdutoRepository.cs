using Localstockk.Domain;

namespace Localstockk.Data.Repositories
{
    public interface IProdutoRepository
    {
        Produto ObterPorId(int id);
        IEnumerable<Produto> ObterTodos();
        void Atualizar(Produto produto);
        void Remover(int id);
        void SaveChanges();
    }
}
