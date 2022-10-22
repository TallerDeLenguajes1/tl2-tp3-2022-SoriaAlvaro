using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class_Cadete;
namespace Class_Cadeteria
{
    public class Cadeteria
    {
        private string? _name;
        private double _phone;
        private List<Cadete> _cadetes = new List<Cadete>();

        public string? Name { get => _name; set => _name = value; }
        public double Phone { get => _phone; set => _phone = value; }
        public List<Cadete> Cadetes { get => _cadetes; set => _cadetes = value; }

        public void MostrarDatos()
        {
            foreach(var cad in Cadetes)
            {
                cad.MostrarDatos();
                cad.MostrarDatosPedidos();
            }
        }
    }
}