using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount kemal = new User { UserId=320, Name = "Kemal", Surname = "Dayı", Id = 31, Mail = "KemalProKing@gmail.com", TcNo = 1234 };
            IAccount burak = new Admin { AdminId = 42, Name = "Burak", Surname = "Yıldız", Id = 12, Mail = "Burak@gmail.com" };
            Sales hall = new Sales {PackageName="Token in the hall", Price="21Tl", Tokens=1000 };
            Sales start = new Sales { PackageName = "Starter Pack", Price="13Tl", Tokens=750 };
            
            
            
            
            AccountManager accountManager = new AccountManager();
            accountManager.Verify(kemal);
            accountManager.Delete(kemal);
            accountManager.Update(kemal);
            accountManager.Register(kemal);
            Console.WriteLine("##############################################################");
            accountManager.Verify(burak);
            accountManager.Delete(burak);
            accountManager.Update(burak);
            accountManager.Register(burak);
            Console.WriteLine("##############################################################");

            SalesManager salesManager = new SalesManager();
            salesManager.BoughtFor(hall, kemal);
            salesManager.defined(hall, kemal);
            salesManager.StudentDiscount(hall, kemal);
            salesManager.PackageUpdate(hall);
            salesManager.DeletePackage(hall);
            Console.WriteLine("##############################################################");
            salesManager.BoughtFor(start, burak);
            salesManager.defined(start, burak);
            salesManager.StudentDiscount(start, burak);
            salesManager.PackageUpdate(start);
            salesManager.DeletePackage(start);
        }
    }
}
