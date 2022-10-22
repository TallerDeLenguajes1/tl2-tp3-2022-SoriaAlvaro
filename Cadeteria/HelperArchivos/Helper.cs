using System.Diagnostics;
using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Pedido;
using Class_Cliente;
using Class_Cadete;
using Class_Persona;

namespace Class_Helper
{
    public class Helper
    {
        public string getDirectory(string? archivo)
        {
            string? path = Directory.GetCurrentDirectory() + @"/CSV" + @"/" + archivo + ".csv";
            return path;
        }
        public List<Cliente> ProcessCSVCliente(string path)
        {
            var rows = File.ReadAllLines(path);
            return (from list in rows
            .Skip(1)
            select ( new Cliente().Parseflow(list))).ToList();
        }
        public List<Cadete> ProcessCSVCadete(string path)
        {
            var rows = File.ReadAllLines(path);
            return (
                from list in rows
                .Skip(1)
                select (new Cadete().Parseflow(list))
            ).ToList();
        }
        public void asignarPedidos(List<Cadete> cadetes, List<Pedido> pedidos){
            int cantP = pedidos.Count(),
                cantC = cadetes.Count();
            var ran = new Random();
            while((cantP--) > 0){
                cadetes.ElementAt(ran.Next(cantC)).ListPedidos.Add(pedidos.OrderBy(x => ran.Next()).Take(1).First());
            }
        }
        public  List<Pedido> ProcessListPeido(string path, List<Cliente> lClientes)
        {
            var rows = File.ReadAllLines(path);
            var ran = new Random();
            return (from list in rows
            .Skip(1)
            let cliente = lClientes.OrderBy(x => ran.Next()).Take(1)
            from cl in cliente
            select ( new Pedido().ParseflowPedido(list, cl))).ToList();
        }

        public void EliminarPedido(List<Pedido> pedidos, int op)
        {
            pedidos.RemoveAll(p => p.Nro == op);
        }

        public void CambiarEstadoTrue(List<Cadete> cadetes, int op)
        {
            cadetes.Where(p => p.Id == op)
                    .Select(p => p.ListPedidos.Select(l => l.Estado = true));
        }

        public int setOption(List<Cadete> cadetes)
        {
            System.Console.WriteLine("Elija a un Cadete");
            foreach(var c in cadetes){
                System.Console.WriteLine($"{c.Id}) {c.Name}");
            }
            System.Console.WriteLine("Opción:");
            return int.Parse(Console.ReadLine());
        }

        /* public void MoverPedidos() */
    }
}