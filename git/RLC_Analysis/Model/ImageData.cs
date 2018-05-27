using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RLC_Analysis.Code;

namespace RLC_Analysis.Model
{
    public class ImageData
    {
            public ImageSource source { get; set; }
            public double angle { get; set; }
            public ElementTypes elementType { get; set; }

            public ImageData()
            {
                angle = 0;
            }

            public ImageData(ImageSource s, double a)
            {
                source = s;
                angle = a;
            }

            public ImageData(ImageSource s, ElementTypes type)
            {
                source = s;
                elementType = type;
            }
    }
}
