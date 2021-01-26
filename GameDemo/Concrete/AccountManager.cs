using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class AccountManager : IAccountInfo
    {
        public void Delete(IAccount account)
        {
            Console.WriteLine(account.Name + " Account deleted");
        }

        public void Register(IAccount account)
        {
            Console.WriteLine(account.Name + " Account Created. WELCOME");
        }

        public void Update(IAccount account)
        {
            Console.WriteLine(account.Name + " Account Updated");
        }

        public void Verify(IAccount account)
        {
            if (account.TcNo==0)
            {
                Console.WriteLine(account.Name + " Account is not confirmed. Please Give Your Nationallty Id");
            }
            else  
            {
                Console.WriteLine("TcNo= " + account.TcNo + " Account confirmed");
            }
        }
    }
}
