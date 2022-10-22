using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Persona;
using Class_Pedido;

namespace Class_Cadete
{
    public class Cadete : Persona
    {
        private List<Pedido> _listPedidos = new List<Pedido>();

        public List<Pedido> ListPedidos { get => _listPedidos; set => _listPedidos = value; }

        public void JornalACobrar()
        {
            int cantP = ListPedidos.Count();
            System.Console.WriteLine($"Jornal a cobrar: {cantP * 300}");
        }

        public override Cadete Parseflow(string row)
        {
            var columns = row.Split(",");
            return new Cadete()
            {
                Id = int.Parse(columns[0]),
                Name = columns[1],
                Address = columns[2],
                Phone = int.Parse(columns[3])
            };
        }

        public void setPedidos (Pedido pedido)
        {
            ListPedidos.Add(pedido);
        }

        public void MostrarDatosPedidos()
        {

            System.Console.WriteLine("Pedidos asignados al cadete:");
            foreach(var pedidos in ListPedidos)
            {
                pedidos.MostrarDatos();
            }
        }
    }
}