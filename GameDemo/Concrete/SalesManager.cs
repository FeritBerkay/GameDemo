using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class SalesManager : ILogSalesInfo, ISalesInfo, IDiscount
    {
        public void AdminDiscount(Sales sales, IAccount account)
        {
            Console.WriteLine(account.Name + " Admin Discount avaliable");
        }

        public void BoughtFor(Sales sales, IAccount account)
        {
            Console.WriteLine(sales.PackageName + " Bought for= "+ account.Name);
        }

        public void defined(Sales sale, IAccount account)
        {
            Console.WriteLine("Thank you "+ account.Name + " You bought " + sale.PackageName);
        }

        public void DeletePackage(Sales sale)
        {
            Console.WriteLine(sale.PackageName+" Deleted.");
            
        }
        public void EmployeeDiscount(Sales sales, IAccount account)
        {
            Console.WriteLine(account.Name + " Employee Discount avaliable");
        }

        public void PackageUpdate(Sales sale)
        {
            Console.WriteLine(sale.PackageName + " Updated.");
        }

        public void StudentDiscount(Sales sales, IAccount account)
        {
            Console.WriteLine(account.Name + " Student Discount avaliable");
        }
    }
}
