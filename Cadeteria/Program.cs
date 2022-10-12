using System;
using System.Collections.Generic;
using System.Linq;
using Class_MetodosDatos;

int op;
do
{
    op = MethodData.setInt("1)\n2)");
    if(op == 1)
    {
        Console.Clear();
        System.Console.WriteLine("Hola");
        Console.ReadKey();
        Console.Clear();
    }
}while(op == 1);