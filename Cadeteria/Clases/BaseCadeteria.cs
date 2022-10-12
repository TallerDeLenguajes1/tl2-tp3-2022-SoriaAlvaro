using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_Base
{
    public class Base
    {
        protected string? name;
        protected int phone;

        public string? Name { get => name; set => name = value; }
        public int Phone { get => phone; set => phone = value; }
    }
}