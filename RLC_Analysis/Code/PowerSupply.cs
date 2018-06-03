using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RLC_Analysis.Code
{
    public class PowerSupply
    {
       
            public double Amplitude { get; set; }
            public double w { get; set; }
            public double Phase { get; set; }

            public PowerSupply()
            {
                this.Amplitude = 0;
                this.w = 0;
                this.Phase = 0;
            }

            public PowerSupply(double a, double f, double p)
            {
                this.Amplitude = a;
                this.w = 2 * f * Math.PI;
                this.Phase = p;
            }

            public void setFrequency(double f)
            {
                this.w = 2 * f * Math.PI;
            }

            public string getValue()
            {
                if (Phase == 0.0)
                {
                     return (Amplitude.ToString("#.##") + "*sin( " + w.ToString("#.##") + "t)");
                }
                else
                {
                    return (Amplitude.ToString("#.##") + "*sin( " + w.ToString("#.##") + "t + " + Phase.ToString("#.##") + ")");
                }
            }

        public override string ToString()
        {
            return getValue();
        }
    }
}
