using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Helper;

namespace Class_Persona
{
    public class Persona
    {
        private int _id;
        private string? _name;
        private string? _address;
        private double _phone;

        public int Id { get => _id; set => _id = value; }
        public string? Name { get => _name; set => _name = value; }
        public string? Address { get => _address; set => _address = value; }
        public double Phone { get => _phone; set => _phone = value; }

        public virtual void MostrarDatos()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Nombre: {Name}");
            System.Console.WriteLine($"Dirección: {Address}");
            System.Console.WriteLine($"Tel: {Phone}");
        }
        
        public virtual Persona Parseflow(string row)
        {
            var columns = row.Split(",");
            return new Persona()
            {
                Id = int.Parse(columns[0]),
                Name = columns[1],
                Address = columns[2],
                Phone = int.Parse(columns[3])
            };
        }
    }
}