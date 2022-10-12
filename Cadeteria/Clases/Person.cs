using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Base;

namespace Class_Person
{
    public class Person : Base
    {
        private int _id;
        private string? _address;

        public int Id { get => _id; set => _id = value; }
        public string? Address { get => _address; set => _address = value; }

        public virtual void display()
        {
            System.Console.WriteLine($"Id: {Id}");
            System.Console.WriteLine($"Nombre: {Name}");
            System.Console.WriteLine($"Tel: {Phone}");
            System.Console.WriteLine($"Dirección: {Address}");
        }
    }
}