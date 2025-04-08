using AutoMapper;
using Localstockk.Data.DTOs;
using Localstockk.Domain;

namespace Localstockk.Mappings
{
    public class ProdutoProfile : Profile
    {
        public ProdutoProfile() {

            CreateMap<Produto, ProdutoDto>();
            CreateMap<ProdutoCreateDto, Produto>();
            CreateMap<ProdutoUpdateDto, Produto>();
        }

    }
}
