using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Localstockk.ValueObjects;

namespace Localstockk.Data.DTOs
{
    public class ProdutoCreateDto
    {
        public String Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public int Quantidade { get; set; }

        public ProductType Type { get; set; }

        public ProdutoCreateDto(string name, string description, decimal value, int quantity, ProductType tipo)
        {
            Name = name; 
            Description = description;
            Value = value;
            Quantidade = quantity;
            Type = tipo;
        }
    }
}
