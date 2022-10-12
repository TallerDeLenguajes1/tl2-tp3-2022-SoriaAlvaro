using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Cliente;

namespace Class_Pedidos
{
    public class Pedidos
    {
        private int _nro;
        private string? _obs;
        private Cliente? _cliente;
        private bool _estado;

        public int Nro { get => _nro; set => _nro = value; }
        public string? Obs { get => _obs; set => _obs = value; }
        public Cliente? Cliente { get => _cliente; set => _cliente = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        //true: entregado
        //false: no entregado
    }
}