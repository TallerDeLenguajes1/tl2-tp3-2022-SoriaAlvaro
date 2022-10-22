using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Class_Cliente;
using Class_Pedido;
using Class_Helper;

var pathClientes = Directory.GetCurrentDirectory() + @"/CSV/clientes.csv";
var pathPedidos = Directory.GetCurrentDirectory() + @"/CSV/Pedidos.csv";
var pathCadetes = Directory.GetCurrentDirectory() + @"/CSV/cadetes.csv";

var h = new Helper();
System.Console.WriteLine("Dar de alta pedidos:");
var listPedidos = h.ProcessListPeido(pathPedidos, h.ProcessCSVCliente(pathClientes));

System.Console.WriteLine("Asignar Cadetes:");
var listCadetes = h.ProcessCSVCadete(pathCadetes);
h.asignarPedidos(listCadetes, listPedidos);
System.Console.WriteLine("Cadetes:");
foreach(var c in listCadetes)
{
    if(c.ListPedidos.Count() > 0){
        System.Console.WriteLine($"Id: {c.Id}");
        System.Console.WriteLine($"Nombre: {c.Name}");
        c.MostrarDatosPedidos();
        System.Console.WriteLine("=======================");
    }
}
System.Console.WriteLine("Cambiar estado:");