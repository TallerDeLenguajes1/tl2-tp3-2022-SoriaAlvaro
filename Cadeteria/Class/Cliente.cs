using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Persona;

namespace Class_Cliente
{
    public class Cliente : Persona
    {
        private string? _datosRefDireccion;

        public string? DatosRefDireccion { get => _datosRefDireccion; set => _datosRefDireccion = value; }

        public override void MostrarDatos()
        {
            System.Console.WriteLine($"ID: {Id}");
            System.Console.WriteLine($"Nombre: {Name}");
            System.Console.WriteLine($"Dirección: {Address}");
            System.Console.WriteLine($"Tel: {Phone}");
            System.Console.WriteLine($"Referencia de la dirección: {DatosRefDireccion}");
        }

        public override Cliente Parseflow(string row)
        {
            var columns = row.Split(",");
            return new Cliente()
            {
                Id = int.Parse(columns[0]),
                Name = columns[1],
                Address = columns[2],
                Phone = int.Parse(columns[3]),
                DatosRefDireccion = columns[4]
            };
        }
    }
}