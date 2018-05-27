using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RLC_Analysis.Code;

namespace RLC_Analysis.Model
{
  
    public class Circuit
    {
        public List<Element> elements;
        public PowerSupply power;

        protected double Voltage_sum { get; set; }
        protected double Current_sum { get; set; }
        protected double Resistance_sum { get; set; }

        public Circuit()
        {
            elements = new List<Element>();

            power = new PowerSupply();

            Voltage_sum = 0;
            Current_sum = 0;
            Resistance_sum = 0;
        }

        public virtual double SumVoltage()
        {
            return Voltage_sum;
        }

        public virtual double SumAmperage()
        {
            return Current_sum;
        }
    }
}
