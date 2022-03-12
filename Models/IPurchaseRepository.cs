using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<PurchaseNoun> Purchases { get; }

        void SavePurchase(PurchaseNoun purchase);
    }
}
