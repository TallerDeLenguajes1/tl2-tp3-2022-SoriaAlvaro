using System.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Person;
using Class_Cliente;
using Class_Cadete;
using Class_Pedidos;

namespace Class_MetodosDatos
{
    public class MethodData
    {
        public static string setString(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            string? text = Console.ReadLine();
            return text;
        }
        public static int setInt(string mensaje)
        {
            System.Console.WriteLine(mensaje);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static Cliente setDataCliente(int id)
        {
            Cliente cliente = new Cliente()
            {
                Id = id +1,
                Name = setString("Nombre:"),
                Phone = setInt("Tel:"),
                Address = setString("Dirección"),
                RefAddress = setString("Referencia de la dirección:"),
            };
            return cliente;
        }

        /* private static bool estadoDelPedido ()
        {
            System.Console.WriteLine();
            return
        } */
        public static Pedidos setDataPedidos(int nro)
        {
            Pedidos perdido = new Pedidos()
            {
                Nro = nro + 1,
                Obs = setString("Observación del pedido:"),
                Cliente = setDataCliente(nro),
                Estado = false
            };

            return perdido;
        }

        private static List<Pedidos> altaPedidos()
        {
            List<Pedidos> list = new List<Pedidos>();
            int op;
            do
            {
                op = setInt("1)Agregar Pedido\n2)Continuar");
                if(op == 1)
                {
                    int nro = 0;
                    list.Add(setDataPedidos(nro++));
                }
                if(op == 2){Console.Clear();}
            }while(op != 2 || op == 1);
            
            return list;
        }
        public static Cadete setDataCadete(int id)
        {
            Cadete cadete = new Cadete()
            {
                Id = id + 1,
                Name = setString("Nombre:"),
                Phone = setInt("Tel:"),
                Address = setString("Dirección"),
                ListPedidos = altaPedidos()
            };
            return cadete;
        }

        

    }
}