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

namespace RLC_Analysis.Windows
{
    /// <summary>
    /// Interaction logic for ElectronicTasksWindow.xaml
    /// </summary>
    public partial class ElectronicTasksWindow : Window
    {
        public ElectronicTasksWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool IsCorrect;

            IsCorrect = (R2.Text == "20") && (R3.Text == "40") && (L1.Text == "20j" || L1.Text == "20 j" || L1.Text == "20*j") && (L3.Text == "40j" || L3.Text == "40 j" || L3.Text == "40*j") && (C2.Text == "-20j" || C2.Text == "-20 j" || C2.Text == "-20*j" || C2.Text == "(-1)*20j");
            if(IsCorrect)
            {
                MessageBox.Show("Задача решена! Ваш ответ записан, можете приступить к выполнению следующей задачи.");
                secondTask.IsEnabled = true;
                firstTask.IsEnabled = false;
            }
            else
            {
                MessageBox.Show("Ваш ответ записан, можете приступить к выполнению следующей задачи.");
                secondTask.IsEnabled = true;
                firstTask.IsEnabled = false;
            }
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool IsCorrect;

            IsCorrect = (((Ic.Text == "0,7") && (Ib.Text == "0,7") && (Ia.Text == "0,7")) || ((Ic.Text == "0.7") && (Ib.Text == "0.7") && (Ia.Text == "0.7"))) && (degree_Ia.Text == "j45" || degree_Ia.Text == "j*45") && (degree_Ib.Text == "-j75" || degree_Ib.Text == "-j*75" || degree_Ib.Text == "(-1)*j75") && (degree_Ic.Text == "j165" || degree_Ic.Text == "j*165");

            if (IsCorrect)
            {
                MessageBox.Show("Задача решена! Ваш ответ записан.");
                secondTask.IsEnabled = false;
                MainWindow mainMenu = new MainWindow();
                mainMenu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Ваш ответ записан.");
                secondTask.IsEnabled = false;
                MainWindow mainMenu = new MainWindow();
                mainMenu.Show();
                this.Close();
            }
        }
    }
}
