using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Person;
using Class_MethodExtra;
namespace Class_Cliente
{
    public class Cliente : Person
    {
        private string? _refAddress;

        public string? RefAddress { get => _refAddress; set => _refAddress = value; }

        
        public string? setRefAddress(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            string? str = Console.ReadLine();
            return str;
        }
    }
}