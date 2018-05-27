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
using RLC_Analysis.Code;

namespace RLC_Analysis.Windows
{
    /// <summary>
    /// Interaction logic for SeriesCircuitWindow.xaml
    /// </summary>
    /// 
    public struct ParametersList
    {
        public int position;
        public ElementTypes type;
        public double value;
    }

    public partial class SeriesCircuitWindow : Window
    {
        //Значения параметров элементов
        public ParametersList[] parametersValues = new ParametersList[3];

        //параметры источника питания
        public PowerSupply power_supply = new PowerSupply();

        //Названия элементов
        public Label[] parameters_labels = new Label[3];

        public SeriesCircuitWindow()
        {
            InitializeComponent();
            parameters_labels[0] = this.firstLabel;
            parameters_labels[1] = this.secondLabel;
            parameters_labels[2] = this.thirdLabel;
        }

        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Image img = sender as Image;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DataObject data1 = new DataObject(typeof(ImageSource), img.Source);
                DragDrop.DoDragDrop(this, data1, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void Image_Drop(object sender, DragEventArgs e)
        {
            Image img = (Image)sender;
            if (e.Data.GetDataPresent(typeof(ImageSource)))
            {
                img.Source = e.Data.GetData(typeof(ImageSource)) as ImageSource;
            }
            if (img.Name != "second")
            {
                RotateTransform rotateTransform = new RotateTransform(90);
                img.RenderTransform = rotateTransform;
            }
            if (img.Name == "first")
            {
                firstLabel.Content = "0";
            }
            else if (img.Name == "second")
            {
                secondLabel.Content = "0";
            }
            else if (img.Name == "third")
            {
                thirdLabel.Content = "0";
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Ellipse ellipse = (Ellipse) sender;
        
            Window parameters = new Parameters(ElementTypes.Voltage, CircuitTypes.Series);
            parameters.Owner = this;
            parameters.Show();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Label lb = sender as Label;
            lb.Visibility = Visibility.Hidden;
            TextBox tb = lb.Target as TextBox;
            tb.Text = lb.Content.ToString();
            tb.Visibility = Visibility.Visible;
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (firstTextBox.IsVisible)
            {
                firstLabel.Content = firstTextBox.Text;
                firstTextBox.Visibility = Visibility.Hidden;
                firstLabel.Visibility = Visibility.Visible;
            }
            else if (secondTextBox.IsVisible)
            {
                secondLabel.Content = secondTextBox.Text;
                secondTextBox.Visibility = Visibility.Hidden;
                secondLabel.Visibility = Visibility.Visible;
            }
            else if (thirdTextBox.IsVisible)
            {
                thirdLabel.Content = thirdTextBox.Text;
                thirdTextBox.Visibility = Visibility.Hidden;
                thirdLabel.Visibility = Visibility.Visible;
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

    }
}
