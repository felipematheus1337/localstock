
using Localstockk.Data.DTOs;

namespace Localstockk.Services
{
    public interface IProdutoService
    {
        ProdutoDto Create(ProdutoCreateDto dto);
        void Update(ProdutoUpdateDto dto);
        void Remove(int id);
        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetOne(int id);




    }
}
