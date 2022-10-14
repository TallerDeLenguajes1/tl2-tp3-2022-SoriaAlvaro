using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Base;
using Class_Cadete;

namespace Class_Cadeteria
{
    public class Cadeteria : Base
    {
        protected string? name = "Repartidores";
        protected double phone = 300000000009;

        public string? Name { get => name;}
        public double Phone { get => phone;}
        private List<Cadete>? listCadetes = new List<Cadete>();

        public List<Cadete>? ListCadetes { get => listCadetes; set => listCadetes = value; }

        public void MostrarCadetes()
        {
            foreach(var cad in listCadetes)
            {
                cad.display();
            }
        }
        public void nuevoCadete(Cadete cadete)
        {
            this.listCadetes.Add(cadete);
        }
    }
}