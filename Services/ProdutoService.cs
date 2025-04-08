using System;
using Localstockk.Data.DTOs;
using Localstockk.Data.Repositories;
using Localstockk.Domain;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;

namespace Localstockk.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }


        public ProdutoDto Create(ProdutoCreateDto dto)
        {
            var produto = _repository.Create(_mapper.Map<Produto>(dto));
            return _mapper.Map<ProdutoDto>(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            return _repository.ObterTodos()
                .Select(p => _mapper.Map<ProdutoDto>(p))
                .ToList();
        }

        public ProdutoDto GetOne(int id)
        {
            Produto? prod = _repository.ObterPorId(id);

            if (prod == null) return null;
           
            ProdutoDto result = _mapper.Map<ProdutoDto>(prod);

            return result;
        }

        public void Remove(int id)
        {
           _repository.Remover(id);
        }

        public void Update(ProdutoUpdateDto dto)
        {
            if (string.IsNullOrEmpty(dto.Name) || dto.Value == 0m || string.IsNullOrEmpty(dto.Description))
            {
                return;
            }

            _repository.Atualizar(_mapper.Map<Produto>(dto));
        }

    }
}
