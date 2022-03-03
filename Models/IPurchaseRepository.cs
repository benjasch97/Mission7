using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public interface IPurchaseRepository
    {
        public IQueryable<PurchaseNoun> Purchases { get; }

        public void SavePurchase(PurchaseNoun purchase);
    }
}
