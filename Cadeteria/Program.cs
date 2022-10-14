using System;
using System.Collections.Generic;
using System.Linq;
using Class_Cliente;
using Class_Pedidos;

var p = new Pedidos();
var listaPedidos = new List<Pedidos>();

listaPedidos = p.AltaPedidos();

foreach(var lp in listaPedidos)
{
    lp.displayP();
    System.Console.WriteLine("\n");
}

