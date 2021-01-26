using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IDiscount
    {
        void StudentDiscount(Sales sales, IAccount account);
        void EmployeeDiscount(Sales sales, IAccount account);
        void AdminDiscount(Sales sales, IAccount account);
    }
}
