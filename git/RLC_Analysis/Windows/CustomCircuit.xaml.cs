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
    /// Interaction logic for CustomCircuit.xaml
    /// </summary>
    public partial class CustomCircuit : Window
    {
        public Circuit circuit;
        
        public CustomCircuit()
        {
            InitializeComponent();
            circuit = new Circuit();
        }

        private void element_Drop(object sender, DragEventArgs e)
        {
            Image img = (Image)sender;
            ImageData imgData = new ImageData();
            Element el = new Element();
            
            if (e.Data.GetDataPresent(typeof(ImageData)))
            {
                imgData = e.Data.GetData(typeof(ImageData)) as ImageData;
                img.Source = imgData.source;
            }
            if (img.Name == "eight" || img.Name == "six")
            {
                img.RenderTransformOrigin = new Point(0.5, 0.5);
                RotateTransform rotateTransform = new RotateTransform(90);
                img.RenderTransform = rotateTransform;
            }
            if (img.Name == "first")
            {
                first_lb.Content = "0";
                //если не был добавлен ни один элемент
                if(circuit.elements.Count() == 0)
                {
                   circuit.elements.Add(new Element(imgData.elementType, 1));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if(element.number == 1)
                        {
                            count++;
                            el = element;
                            isAdded = true;
                        }
                    }
                    //если был ранее добавлен
                    if(isAdded)
                    {
                        if (count > 1)
                        {
                            MessageBox.Show("(Добавлено несколько элементов с номером 1");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType,1));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 1));
                    }
                }
            }
            else if (img.Name == "second")
            {
                second_lb.Content = "0";

                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 2));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 2)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 2");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 2));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 2));
                    }
                }
            }
            else if (img.Name == "third")
            {
                third_lb.Content = "0";
                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 3));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 3)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 3");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 3));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 3));
                    }
                }
            }
            else if (img.Name == "forth")
            {
                forth_lb.Content = "0";

                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 4));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 4)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 4");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 4));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 4));
                    }
                }
            }
            else if (img.Name == "fifth")
            {
                fifth_lb.Content = "0";

                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 5));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 5)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 5");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 5));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 5));
                    }
                }
            }
            else if (img.Name == "six")
            {
                six_lb.Content = "0";
                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 6));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 6)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 6");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 6));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 6));
                    }
                }
            }
            else if (img.Name == "seven")
            {
                seven_lb.Content = "0";

                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 7));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 7)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 7");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 7));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 7));
                    }
                }
            }
            else if (img.Name == "eight")
            {
                eight_lb.Content = "0";

                if (circuit.elements.Count() == 0)
                {
                    circuit.elements.Add(new Element(imgData.elementType, 8));
                }
                //если какие-то элементы добавлены
                else
                {
                    int count = 0;
                    bool isAdded = false;
                    foreach (var element in circuit.elements)
                    {
                        //проверка, был ли добавлен элемент на это место
                        if (element.number == 8)
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
                            MessageBox.Show("(Добавлено несколько элементов с номером 8");
                        }
                        else
                        {
                            circuit.elements.Remove(el);
                            circuit.elements.Add(new Element(imgData.elementType, 8));
                        }
                    }
                    //если добавляется первый раз
                    else
                    {
                        circuit.elements.Add(new Element(imgData.elementType, 8));
                    }
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

                if(img.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if(img.Source.ToString().Contains("capacitor"))
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
            if (first_tb.IsVisible)
            {
                first_lb.Content = first_tb.Text;
                first_tb.Visibility = Visibility.Hidden;
                first_lb.Visibility = Visibility.Visible;
            }
            else if (second_tb.IsVisible)
            {
                second_lb.Content = second_tb.Text;
                second_tb.Visibility = Visibility.Hidden;
                second_lb.Visibility = Visibility.Visible;
            }
            else if (third_tb.IsVisible)
            {
                third_lb.Content = third_tb.Text;
                third_tb.Visibility = Visibility.Hidden;
                third_lb.Visibility = Visibility.Visible;
            }
            else if (forth_tb.IsVisible)
            {
                forth_lb.Content = forth_tb.Text;
                forth_tb.Visibility = Visibility.Hidden;
                forth_lb.Visibility = Visibility.Visible;
            }
            else if (fifth_tb.IsVisible)
            {
                fifth_lb.Content = fifth_tb.Text;
                fifth_tb.Visibility = Visibility.Hidden;
                fifth_lb.Visibility = Visibility.Visible;
            }
            else if (six_tb.IsVisible)
            {
                six_lb.Content = six_tb.Text;
                six_tb.Visibility = Visibility.Hidden;
                six_lb.Visibility = Visibility.Visible;
            }
            else if (seven_tb.IsVisible)
            {
                seven_lb.Content = seven_tb.Text;
                seven_tb.Visibility = Visibility.Hidden;
                seven_lb.Visibility = Visibility.Visible;
            }
            else if (eight_tb.IsVisible)
            {
                eight_lb.Content = eight_tb.Text;
                eight_tb.Visibility = Visibility.Hidden;
                eight_lb.Visibility = Visibility.Visible;
            }
        }

        private void GetResult_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Parameters paramsWindow = new Parameters(Code.ElementTypes.Voltage, Code.CircuitTypes.Custom);
            paramsWindow.Owner = this;
            paramsWindow.Show();
        }

    }
}
