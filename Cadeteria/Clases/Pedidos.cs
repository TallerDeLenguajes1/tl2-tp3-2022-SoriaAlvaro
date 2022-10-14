using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Cliente;
using Class_MethodExtra;
namespace Class_Pedidos
{
    public class Pedidos
    {
        private int _nro;
        private string? _obs;
        private Cliente? _cliente = new Cliente();
        private bool _estado;

        public int Nro { get => _nro; set => _nro = value; }
        public string? Obs { get => _obs; set => _obs = value; }
        public Cliente? ClienteP { get => _cliente; set => _cliente = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        //true: entregado
        //false: no entregado
        private void mensajeDeEstado(bool estado)
        {
            if(estado){System.Console.WriteLine("Entregado");}
            else{System.Console.WriteLine("No entregado");}
        }
        public void displayP (){
            System.Console.WriteLine($"Nro: {this._nro}");
            System.Console.WriteLine($"Observación: {this._obs}");
            System.Console.WriteLine("Cliente:\n");
            ClienteP.display();
            mensajeDeEstado(this._estado);
        }
        private void altaPedido(Pedidos pedido, int nro)
        {
            pedido.Nro = nro + 1;
            pedido.Obs = Extra.setString("Observación del pedido");
            pedido.ClienteP.setData(pedido.ClienteP, nro);
            pedido.Estado = false;
        }
        private void CicloAgregarPedidos (List<Pedidos> pedidos)
        {
            int op;
            int n = 0;
            do
            {
                op = Extra.setInt("1)Agregar Pedido\n2)Continuar");
                if(op == 1){
                    var pedido = new Pedidos();
                    altaPedido(pedido, n);
                    pedidos.Add(pedido);
                    Console.Clear();
                    n++;
                }
                if(op == 2){
                    Console.Clear();
                    break;
                 }
            }while(op == 1 || op != 2);

        }
        public List<Pedidos> AltaPedidos()
        {
            var list = new List<Pedidos>();
            CicloAgregarPedidos(list);
            return list;
        }
    }
}