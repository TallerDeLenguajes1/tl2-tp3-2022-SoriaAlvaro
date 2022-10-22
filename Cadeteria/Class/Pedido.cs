using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Cliente;

namespace Class_Pedido
{
    public class Pedido
    {
        private int _nro;
        private string? _obs;
        private Cliente _nuevoCliente = new Cliente();
        private bool? _estado = false;

        public bool? Estado { get => _estado; set => _estado = value; }
        public Cliente NuevoCliente { get => _nuevoCliente; set => _nuevoCliente = value; }
        public string? Obs { get => _obs; set => _obs = value; }
        public int Nro { get => _nro; set => _nro = value; }
        
        public void MostrarDatos()
        {
           /*  System.Console.WriteLine("Datos del Cliente: ");
            NuevoCliente.MostrarDatos(); */
            System.Console.WriteLine($"Nro: {Nro}");
            System.Console.WriteLine($"Obs Pedido: {Obs}");
        }
        public  Pedido ParseflowPedido(string row, Cliente c)
        {
            var columns = row.Split(",");
            return new Pedido()
            {
                Nro = int.Parse(columns[0]),
                Obs = columns[1],
                NuevoCliente = c
            };
        }
    }
}