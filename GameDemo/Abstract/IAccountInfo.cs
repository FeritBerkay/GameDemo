using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IAccountInfo
    {
        void Register(IAccount account);
        void Update(IAccount account);
        void Delete(IAccount account);
        void Verify(IAccount account);

    }
}
