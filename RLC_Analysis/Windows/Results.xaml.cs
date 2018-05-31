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

        }
    }
}
