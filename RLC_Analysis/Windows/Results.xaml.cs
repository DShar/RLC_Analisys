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

namespace RLC_Analysis.Windows
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        protected Circuit circuit;

        public Results(Circuit circ)
        {
            InitializeComponent();
            circuit = circ;

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
            }
            MessageBox.Show(m1 + "      \n" + m2);



        }
    }
}
