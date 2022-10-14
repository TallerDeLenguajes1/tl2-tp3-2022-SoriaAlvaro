using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Base;
using Class_MethodExtra;
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
        public void setData(Person person, int id)
        {
            person.Id = id + 1;
            person.Name = Extra.setString("Nombre:");
            person.Address = Extra.setString("Dirección:");
            person.Phone = Extra.setInt("Tel:");
        }
    }
}