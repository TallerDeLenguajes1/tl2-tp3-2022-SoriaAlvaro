using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Person;
using Class_Cliente;

namespace Class_MethodD
{
    public class MethodD
    {
        public string setString(string? mensaje)
        {
            Console.WriteLine(mensaje);
            string? str = Console.ReadLine();
            return str;
        }
        public int setInt(string? mensaje)
        {
            Console.WriteLine(mensaje);
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public virtual Cliente setData(int id)
        {
            var cliente = new Cliente(){
                Id = id + 1,
                Name = setString("Nombre:"),
                Phone = setInt("Tel:"),
                Address = setString("Dirección:"),
                RefAddress = setString("Referencia de dirección:")
            };
            return cliente;
        }
        private void bucleAdd(List<Cliente> cliente)
        {
            int op;
            do
            {
                op = setInt("1)Agregar\n2)Continuar");
                int n = 0;
                if(op == 1)
                {
                    cliente.Add(setData(n));
                }
            }while(op != 1 || op == 2);
        }
        public List<Cliente> setListClient()
        {
            var listCliente = new List<Cliente>();
            bucleAdd(listCliente);
            return listCliente;
        }
        
    }
}