﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    class User:IAccount
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int TcNo { get; set; }
    }
}
