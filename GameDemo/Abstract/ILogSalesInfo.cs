using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface ILogSalesInfo
    {
        void BoughtFor(Sales sales, IAccount account);
        void DeletePackage(Sales sale);
        void PackageUpdate(Sales sale);
    }
}
