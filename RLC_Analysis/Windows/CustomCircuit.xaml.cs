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
        public Label[] valueLabels = new Label[8];
        
        public CustomCircuit()
        {
            InitializeComponent();
            circuit = new Circuit();

            valueLabels[0] = first_lb;
            valueLabels[1] = second_lb;
            valueLabels[2] = third_lb;
            valueLabels[3] = forth_lb;
            valueLabels[4] = fifth_lb;
            valueLabels[5] = six_lb;
            valueLabels[6] = seven_lb;
            valueLabels[7] = eight_lb;
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
                    Element element = new Element(imgData.elementType, 1);
                   circuit.elements.Add(element);
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

                ElementTypes type;
                if(first.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (first.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(first_tb.Text, out result))
                {
                    setElementValue(type, 1, result);
                    first_tb.Visibility = Visibility.Hidden;
                    first_lb.Visibility = Visibility.Visible;
                }

            }
            else if (second_tb.IsVisible)
            {
                second_lb.Content = second_tb.Text;

                ElementTypes type;
                if (second.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (second.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(second_tb.Text, out result))
                {
                    setElementValue(type, 2, result);
                    second_tb.Visibility = Visibility.Hidden;
                    second_lb.Visibility = Visibility.Visible;
                }
            }
            else if (third_tb.IsVisible)
            {
                third_lb.Content = third_tb.Text;

                ElementTypes type;
                if (third.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (third.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(third_tb.Text, out result))
                {
                    setElementValue(type, 3, result);
                    third_tb.Visibility = Visibility.Hidden;
                    third_lb.Visibility = Visibility.Visible;
                }
            }
            else if (forth_tb.IsVisible)
            {
                forth_lb.Content = forth_tb.Text;

                ElementTypes type;
                if (forth.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (forth.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(forth_tb.Text, out result))
                {
                    setElementValue(type, 4, result);
                    forth_tb.Visibility = Visibility.Hidden;
                    forth_lb.Visibility = Visibility.Visible;
                }
            }
            else if (fifth_tb.IsVisible)
            {
                fifth_lb.Content = fifth_tb.Text;

                ElementTypes type;
                if (fifth.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (fifth.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(fifth_tb.Text, out result))
                {
                    setElementValue(type, 5, result);
                    fifth_tb.Visibility = Visibility.Hidden;
                    fifth_lb.Visibility = Visibility.Visible;
                }
            }
            else if (six_tb.IsVisible)
            {
                six_lb.Content = six_tb.Text;

                ElementTypes type;
                if (six.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (six.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(six_tb.Text, out result))
                {
                    setElementValue(type, 6, result);
                    six_tb.Visibility = Visibility.Hidden;
                    six_lb.Visibility = Visibility.Visible;
                }
            }
            else if (seven_tb.IsVisible)
            {
                seven_lb.Content = seven_tb.Text;

                ElementTypes type;
                if (seven.Source.ToString().Contains("resistor"))
                {
                    type = ElementTypes.Resistor;
                }
                else if (seven.Source.ToString().Contains("capacitor"))
                {
                    type = ElementTypes.Capacitor;
                }
                else
                {
                    type = ElementTypes.Inductor;
                }

                double result;
                if (Double.TryParse(seven_tb.Text, out result))
                {
                    setElementValue(type, 7, result);
                    seven_tb.Visibility = Visibility.Hidden;
                    seven_lb.Visibility = Visibility.Visible;
                }
            }
            else if (eight_tb.IsVisible)
            {
                eight_lb.Content = eight_tb.Text;

                    ElementTypes type;
                    if (eight.Source.ToString().Contains("resistor"))
                    {
                        type = ElementTypes.Resistor;
                    }
                    else if (eight.Source.ToString().Contains("capacitor"))
                    {
                        type = ElementTypes.Capacitor;
                    }
                    else
                    {
                        type = ElementTypes.Inductor;
                    }

                    double result;
                    if (Double.TryParse(eight_tb.Text, out result))
                    {
                        setElementValue(type, 8, result);
                        eight_tb.Visibility = Visibility.Hidden;
                        eight_lb.Visibility = Visibility.Visible;
                    }
            }
        }

        void setElementValue(ElementTypes t, int num, double val)
        {
            foreach(Element el in circuit.elements)
            {
                if(el.number == num)
                {
                    switch(el.type)
                    {
                        case ElementTypes.Resistor:
                            el.ActiveResistance = val;
                            break;
                        case ElementTypes.Inductor:
                            el.Inductance = val;
                            break;
                        case ElementTypes.Capacitor:
                            el.Capacity = val;
                            break;
                    }
                }
            }
        }

        private void GetResult_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Добавлено " + circuit.elements.Count + " элементов.");
            int index = 0;
            bool isCorrect = true;
            foreach (Element el in circuit.elements)
            {
                index++;

                switch(el.type)
                {
                    case ElementTypes.Resistor:
                        if (el.ActiveResistance == 0)
                        {
                            MessageBox.Show("Не установлено значение " + el.number + "-го элемента.");
                            isCorrect = false;
                            break;
                        }
                        break;
                    case ElementTypes.Inductor:
                        if (el.Inductance == 0)
                        {
                            MessageBox.Show("Не установлено значение " + el.number + "-го элемента.");
                            isCorrect = false;
                            break;
                        }
                        break;
                    case ElementTypes.Capacitor:
                        if (el.Capacity == 0)
                        {
                            MessageBox.Show("Не установлено значение " + el.number + "-го элемента.");
                            isCorrect = false;
                            break;
                        }
                        break;
                }
               
            }

            if(isCorrect)
            {
                Results resultsWindow = new Results(circuit);
                resultsWindow.Owner = this;
                resultsWindow.Show();
            }
        }

        private void Ellipse_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Parameters paramsWindow = new Parameters(Code.ElementTypes.Voltage, Code.CircuitTypes.Custom);
            paramsWindow.Owner = this;
            paramsWindow.Show();
        }

    }
}
