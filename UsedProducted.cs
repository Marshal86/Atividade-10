using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePolimorf.Entities
{
    class UsedProducted : Product
    {
        public DateTime ManuFactureDate { get; set; }


        public UsedProducted()
        {

        }

        public UsedProducted(string name, double price, DateTime manuFactureDate) : base(name,price)
        {
            ManuFactureDate = manuFactureDate;
        }


        public override string PriceTag()
        {
            return ($"{Name}(used)  $ {Price} ( Manufacture date: {ManuFactureDate})");
        }



    }
}
