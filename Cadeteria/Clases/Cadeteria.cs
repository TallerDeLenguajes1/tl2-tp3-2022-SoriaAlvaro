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
        private List<Cadete>? listCadetes;

        public List<Cadete>? ListCadetes { get => listCadetes; set => listCadetes = value; }
    }
}