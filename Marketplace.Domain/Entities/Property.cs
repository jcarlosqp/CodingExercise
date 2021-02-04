using System;

namespace Marketplace.Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public double ListPrice { get; set; }
        public double MonthlyRent { get; set; }
        public double GrossYield { get; set; }

        // domain logic
        public void Process()
        {
            if(ListPrice != 0 )
                this.GrossYield = MonthlyRent * 12 / ListPrice;
            else
                this.GrossYield = 0;
        }
    }
}
