using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_MethodD;
using Class_Cadete;
namespace Class_MethodC
{
    public class MethodC
    {
        private MethodD m = new MethodD();
        public Cadete setData(int id)
        {
            var cadete = new Cadete(){
                Id = id + 1,
                Name = m.setString("Nombre:"),
                Phone = m.setInt("Tel:"),
                Address = m.setString("Dirección:"),
            };
            return cadete;
        }
        private void bucleAdd(List<Cadete> cadete)
        {
            int op;
            do
            {
                op = m.setInt("1)Agregar\n2)Continuar");
                int n = 0;
                if(op == 1)
                {
                    cadete.Add(setData(n));
                }
            }while(op != 1 || op == 2);
        }
        public List<Cadete> setListClient()
        {
            var listCadete = new List<Cadete>();
            bucleAdd(listCadete);
            return listCadete;
        }
    }
}