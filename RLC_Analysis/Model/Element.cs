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
        public int number;

        public Complex Resistance;

        public double ActiveResistance;
        public double Inductance;
        public double Capacity;

        public Element(ElementTypes t, int num)
        {
            type = t;
            number = num;

            Inductance = 0;
            Capacity = 0;
            ActiveResistance = 0;

        }

        public Element()
        {
            this.Resistance = new Complex();
        }

        public Element(Complex z)
        {
            this.Resistance = new Complex(z.Real(), z.Imaginary());
        }

        public Element(ElementTypes ElementType, double value, double w)
        {
            this.type = ElementType;
            switch (ElementType)
            {
                case ElementTypes.Resistor:
                    this.Resistance = new Complex(value, 0);
                    this.ActiveResistance = value;
                    break;
                case ElementTypes.Inductor:
                    this.Resistance = new Complex(0, w * value);
                    this.Inductance = value;
                    break;
                case ElementTypes.Capacitor:
                    this.Resistance = new Complex(0, (-1) / (w * value));
                    this.Capacity = value;
                    break;
            }
        }

        public void setResistance(double w, ElementTypes ElementType)
        {
            this.type = ElementType;
            switch (ElementType)
            {
                case ElementTypes.Resistor:
                    this.Resistance = new Complex(this.ActiveResistance, 0);
                    break;
                case ElementTypes.Inductor:
                    this.Resistance = new Complex(0, w * this.Inductance);
                    break;
                case ElementTypes.Capacitor:
                    this.Resistance = new Complex(0, (-1) / (w * this.Capacity));
                    break;
            }
        }

        public void setResistance(Complex res)
        {
            this.Resistance = new Complex(res.Real(), res.Imaginary());
        }
    }
}
