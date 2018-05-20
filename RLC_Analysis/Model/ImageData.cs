using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace RLC_Analysis.Model
{
    public class ImageData
    {
            public ImageSource source { get; set; }
            public double angle { get; set; }

            public ImageData(ImageSource s, double a)
            {
                source = s;
                angle = a;
            }
    }
}
