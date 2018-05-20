using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLC_Analysis.Code;

namespace RLC_Analysis.Model
{
    public class Element
    {
        public ElementTypes type;
        public double Inductance { get; set; }
        public double Capacity { get; set; }
        public double Resistance { get; set; }
        public double Amperage { get; set; }
        public double Voltage { get; set; }

        public Element()
        {
            Inductance = 0;
            Capacity = 0;
            Resistance = 0;
            Amperage = 0;
            Voltage = 0;
        }
    }
}
