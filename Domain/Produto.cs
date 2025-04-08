using Localstockk.ValueObjects;

namespace Localstockk.Domain
{
    public class Produto
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public int Quantidade {  get; set; }

        public ProductType Type { get; set; }



    }
}
