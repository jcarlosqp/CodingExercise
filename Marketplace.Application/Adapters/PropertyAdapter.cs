using Marketplace.Domain.Entities;
using Marketplace.Infrastucture.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Marketplace.Application.Adapters
{
    public class PropertyAdapter
    {
        public static Property CreateProperty(Properties p)
        {
            var newProperty = new Property()
            {
                Address = FormatAddress(p.Address),
                YearBuilt = p.Physical?.YearBuilt ?? 0,
                ListPrice = p.Financial?.ListPrice ?? 0,
                MonthlyRent = p.Financial?.MonthlyRent ?? 0
            };

            newProperty.Process();
            return newProperty;
        }

        private static string FormatAddress(Address address)
        {
            return address?.Address1 ?? "" + ", " + address?.Address2 ?? "" + ", " +
                address?.City ?? "" + ", " + address?.Country ?? "";
        }

    }
}
