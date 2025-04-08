using Localstockk.ValueObjects;

namespace Localstockk.Domain
{
    public class Produto
    {
        public int Id { get; set; }

        public String name { get; set; }

        public string description { get; set; }

        public decimal Value { get; set; }

        public ProductType type { get; set; }



    }
}
