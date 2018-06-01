using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RLC_Analysis.Model;
using RLC_Analysis.Code;

namespace RLC_Analysis.Windows
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        protected Circuit circuit;
        protected double w;

        public Results(Circuit circ)
        {
            InitializeComponent();
            circuit = circ;
            w = circuit.power.w;

            WriteResults();
        }

        private void MainMenu_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите закрыть окно? \n Ваши результаты не сохранятся.", "Закрыть окно?", MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.Yes);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow mainMenu = new MainWindow();
                mainMenu.Show();
                this.Close();
            }
        }

        public void WriteResults()
        {
            string m1 = string.Empty;
            string m2 = string.Empty;

            foreach (Element el in circuit.elements)
            {
                m1 += el.number;
            }
            circuit.elements.Sort(delegate (Element el1, Element el2) { return el1.number.CompareTo(el2.number); });
            
            foreach( Element el in circuit.elements)
            {
                m2 += el.number;

                el.setResistance(w, el.type);
            }
            MessageBox.Show(m1 + "      \n" + m2);

            circuit.Resistance1 = ((Complex.Sum(circuit.elements[0].Resistance, circuit.elements[1].Resistance))
                * circuit.elements[2].Resistance) /
                (Complex.Sum(circuit.elements[0].Resistance, circuit.elements[1].Resistance, circuit.elements[2].Resistance));

            Resistanse_1.Text += circuit.Resistance1.ToString();

            circuit.Resistance2 = ((circuit.elements[3].Resistance * circuit.elements[4].Resistance)/
                (Complex.Sum(circuit.elements[3].Resistance,  circuit.elements[4].Resistance)));

            Resistanse_2.Text += circuit.Resistance2.ToString();

            circuit.Resistance3 = ((Complex.Sum(circuit.elements[5].Resistance, circuit.elements[6].Resistance))
                * circuit.elements[7].Resistance) /
                (Complex.Sum(circuit.elements[5].Resistance, circuit.elements[6].Resistance, circuit.elements[7].Resistance));

            Resistanse_3.Text += circuit.Resistance3.ToString();

            //Расчёт амплитуды контурных токов
            //I(I)max = E / Zэкв  Zэкв - tempResistance1
            //I(II)max = E / Zдел Zдел - tempResistance2

            Complex tempResistance1 = new Complex();
            tempResistance1 = circuit.Resistance3 + circuit.Resistance1 +
                ((circuit.Resistance1 * circuit.Resistance3) / circuit.Resistance2);

            Complex tempResistance2 = new Complex();
            Complex Constant1 = new Complex(1, 0);  // 1 в виде комплексного числа (1+0i)
            tempResistance2 = (circuit.Resistance1 + circuit.Resistance2) / (Constant1 + (circuit.Resistance2 / tempResistance1));


            double Emax = circuit.power.Amplitude;

            //Ток вo 2 контуре
            circuit.I3 = new PowerSupply(Emax / Complex.Abs(tempResistance1), circuit.power.w / (2 * System.Math.PI), circuit.power.Phase + System.Math.Atan2(tempResistance1.Imaginary(), tempResistance1.Real()));
            Amperage_3.Text += circuit.I3.getValue();

            //Ток в первом контуре
            circuit.I1 = new PowerSupply(Emax / Complex.Abs(tempResistance2), circuit.power.w / (2 * System.Math.PI), circuit.power.Phase + System.Math.Atan2(tempResistance2.Imaginary(), tempResistance2.Real()));
            Amperage_1.Text += circuit.I1.getValue();

            //Ток во второой ветви I2=I1-I3;
            double a1, b1, a2, b2, a3, b3, Imax2, phase2;

            a1 = System.Math.Sqrt((circuit.I1.Amplitude * circuit.I1.Amplitude) / (1 + System.Math.Tan((circuit.I1.Phase * System.Math.PI) / 180) * System.Math.Tan((circuit.I1.Phase * System.Math.PI) / 180)));
            b1 = a1 * System.Math.Tan((circuit.I1.Phase * System.Math.PI) / 180);

            a3 = System.Math.Sqrt((circuit.I3.Amplitude * circuit.I3.Amplitude) / (1 + System.Math.Tan((circuit.I3.Phase * System.Math.PI) / 180) * System.Math.Tan((circuit.I3.Phase * System.Math.PI) / 180)));
            b3 = a3 * System.Math.Tan((circuit.I3.Phase * System.Math.PI) / 180);

            a2 = a1 - a3;
            b2 = b1 - b3;

            Complex temp = new Complex(a2, b2);
            Imax2 = Complex.Abs(temp);
            phase2 = System.Math.Atan2(b2,a2);

            circuit.I2 = new PowerSupply(Imax2, circuit.power.w / (2 * System.Math.PI), phase2);
            Amperage_2.Text += circuit.I2.getValue();

        }
    }
}
