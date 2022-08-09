using System;

namespace AtividadePolimorf.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }


        public Double TotalPrice()
        {
         
          return Price+CustomFee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomFee})";
        }
    }

   


}
