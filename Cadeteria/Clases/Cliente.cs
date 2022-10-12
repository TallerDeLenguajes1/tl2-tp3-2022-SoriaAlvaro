using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Person;

namespace Class_Cliente
{
    public class Cliente : Person
    {
        private string? _refAddress;

        public string? RefAddress { get => _refAddress; set => _refAddress = value; }
    }
}