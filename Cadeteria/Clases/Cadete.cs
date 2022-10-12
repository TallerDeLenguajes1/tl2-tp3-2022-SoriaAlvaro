using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Person;
using Class_Pedidos;

namespace Class_Cadete
{
    public class Cadete : Person
    {
        private List<Pedidos>? _listPedidos;
        private double jornal = 300;

        public List<Pedidos>? ListPedidos { get => _listPedidos; set => _listPedidos = value; }

        public double JornalACobrar ()
        {
            int cantPedidos = ListPedidos.Count();

            return cantPedidos * jornal;
        }
    }
} 