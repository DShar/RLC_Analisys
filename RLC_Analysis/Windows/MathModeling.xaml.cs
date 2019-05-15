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
    /// Interaction logic for MathModeling.xaml
    /// </summary>
    public partial class MathModeling : Window
    {
        public Circuit circuit;
        public Label[] valueLabels = new Label[5];

        public MathModeling()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            circuit = new Circuit();

            valueLabels[0] = first_lb;
            valueLabels[1] = second_lb;
            valueLabels[2] = third_lb;
            valueLabels[3] = forth_lb;
            valueLabels[4] = fifth_lb;
        }

        private void Image_Drop(object sender, DragEventArgs e)
        {
            Image img = (Image)sender;
            ImageData imgData = new ImageData();

            if (e.Data.GetDataPresent(typeof(ImageData)))
            {
                imgData = e.Data.GetData(typeof(ImageData)) as ImageData;
                img.Source = imgData.source;
            }
            if (img.Name == "third" || img.Name == "forth" || img.Name == "fifth")
            {
                img.RenderTransformOrigin = new Point(0.5, 0.5);
                RotateTransform rotateTransform = new RotateTransform(90);
                img.RenderTransform = rotateTransform;
            }

            switch(img.Name)
            {
                case "first":
                    AddElement(1,imgData);
                    break;
                case "second":
                    AddElement(2, imgData);
                    break;
                case "third":
                    AddElement(3, imgData);
                    break;
                case "forth":
                    AddElement(4, imgData);
                    break;
                case "fifth":
                    AddElement(5, imgData);
                    break;
                default:
                    MessageBox.Show("Не получилось найти место для вставки :(");
                    break;
            }

        }

        private void AddElement(int num, ImageData imgData)
        {
            Element el = new Element();

            ElementTypes elType = GetElementType(imgData);
            string name = "";
            switch(elType)
            {
                case ElementTypes.Resistor:
                    name = "Y";
                    break;
                case ElementTypes.Capacitor:
                    name = "C";
                    break;
                case ElementTypes.Inductor:
                    name = "L";
                    break;
            }

            //Подсчёт кол-ва элементов данного типа
            int countElementsOfType;
            countElementsOfType = circuit.elements.Where(e => e.type == elType).ToList().Count;

            //если не был добавлен ни один элемент
            if (circuit.elements.Count == 0)
            {
                Element element = new Element(imgData.elementType, num);
                circuit.elements.Add(element);

                name += countElementsOfType + 1;
                valueLabels[num-1].Content = name;
            }
            //если какие-то элементы добавлены
            else
            {
                int count = 0;
                bool isAdded = false;

                foreach (var element in circuit.elements)
                {
                    //проверка, был ли добавлен элемент на это место
                    if (element.number == num)
                    {
                        count++;
                        el = element;
                        isAdded = true;
                    }
                }
                //если был ранее добавлен
                if (isAdded)
                {
                    if (count > 1)
                    {
                        MessageBox.Show("(Добавлено несколько элементов с номером " + num);
                    }
                    else
                    {
                        circuit.elements.Remove(el);
                        circuit.elements.Add(new Element(imgData.elementType, num));

                        name += countElementsOfType + 1;
                        valueLabels[num - 1].Content = name;
                    }
                }
                //если добавляется первый раз
                else
                {
                    circuit.elements.Add(new Element(imgData.elementType, num));

                    name += countElementsOfType + 1;
                    valueLabels[num - 1].Content = name;
                }
            }
        }

        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Image img = sender as Image;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                ElementTypes type;

                if (img.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (img.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }
                ImageData data = new ImageData(img.Source, type);
                DataObject data1 = new DataObject(typeof(ImageData), data);
                DragDrop.DoDragDrop(this, data1, DragDropEffects.Copy | DragDropEffects.Move);
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

        private ElementTypes GetElementType(ImageData img)
        {
            ElementTypes type;

            if (img.source.ToString().Contains("resistor"))
            {
                type = ElementTypes.Resistor;
            }
            else if (img.source.ToString().Contains("capacitor"))
            {
                type = ElementTypes.Capacitor;
            }
            else
            {
                type = ElementTypes.Inductor;
            }

            return type;
        }

        private void GetResult_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            int countElements;
            countElements = circuit.elements.Count;
            bool isCorrect = true;

            if (countElements != 5)
            {
                MessageBox.Show("Не все элементы выбраны!");
                isCorrect = false;
            }

            if(isCorrect)
            {
                MatrixWindow win = new MatrixWindow(circuit,valueLabels);
                win.Owner = this;
                win.Show();
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }
    }
}
