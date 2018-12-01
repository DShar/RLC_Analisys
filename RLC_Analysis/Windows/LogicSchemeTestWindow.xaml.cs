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
    /// Interaction logic for LogicSchemeTestWindow.xaml
    /// </summary>
    /// 


    public partial class LogicSchemeTestWindow : Window
    {
        bool IsSchemeCorrect = false;
        int attemptNumber = 0;

        public TextBox[] table_textBoxes = new TextBox[4];
        public TextBox[] table_textBoxes2 = new TextBox[8];
        public TextBox[] table_textBoxes3 = new TextBox[4];
        public Image[] elements = new Image[7];
        
        public LogicSchemeTestWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            table_textBoxes[0] = table_tb1;
            table_textBoxes[1] = table_tb2;
            table_textBoxes[2] = table_tb3;
            table_textBoxes[3] = table_tb4;

            table_textBoxes2[0] = table1_tb1;
            table_textBoxes2[1] = table1_tb2;
            table_textBoxes2[2] = table1_tb3;
            table_textBoxes2[3] = table1_tb4;
            table_textBoxes2[4] = table1_tb5;
            table_textBoxes2[5] = table1_tb6;
            table_textBoxes2[6] = table1_tb7;
            table_textBoxes2[7] = table1_tb8;

            table_textBoxes3[0] = table3_tb1;
            table_textBoxes3[1] = table3_tb2;
            table_textBoxes3[2] = table3_tb3;
            table_textBoxes3[3] = table3_tb4;

            elements[0] = first;
            elements[1] = second;
            elements[2] = third;
            elements[3] = forth;
            elements[4] = fifth;
            elements[5] = six;
            elements[6] = seven;
        }

        private void Img_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Image img = sender as Image;
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                RotateTransform rotation = img.RenderTransform as RotateTransform;

                ImageData imageData = new ImageData(img.Source, rotation.Angle);
                DataObject data1 = new DataObject(typeof(ImageData), imageData);
                DragDrop.DoDragDrop(this, data1, DragDropEffects.Copy | DragDropEffects.Move);
            }
        }

        private void diod_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                Image image = sender as Image;
                ContextMenu contextMenu = image.ContextMenu;
                contextMenu.PlacementTarget = image;
                contextMenu.IsOpen = true;
            }
        }

        private void Rotate90_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = sender as MenuItem;
            Image img = null;
            if (mnu != null)
            {
                img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
                
                RotateTransform rotation = img.RenderTransform as RotateTransform;
                if (rotation != null) // Make sure the transform is actually a RotateTransform
                {
                    double rotationInDegrees = rotation.Angle;
                    img.RenderTransformOrigin = new Point(0.5, 0.5);
                    RotateTransform rotateTransform = new RotateTransform(rotationInDegrees + 90);
                    img.RenderTransform = rotateTransform;
                }
            }
            
        }

        private void element_Drop(object sender, DragEventArgs e)
        {
            Image img = (Image)sender;
            if (e.Data.GetDataPresent(typeof(ImageData)))
            {
                ImageData imgData = e.Data.GetData(typeof(ImageData)) as ImageData;
                img.Source = imgData.source;
                RotateTransform rotate = new RotateTransform(imgData.angle);
                img.RenderTransform = rotate;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            attemptNumber += 1;
            if(!IsSchemeCorrect && attemptNumber<2)
            {
                if (first.Source.ToString().Contains("/images/diod.png") && second.Source.ToString().Contains("/images/diod.png") && third.Source.ToString().Contains("/images/diod.png") && forth.Source.ToString().Contains("/images/resistor2.png") && fifth.Source.ToString().Contains("/images/resistor2.png") && seven.Source.ToString().Contains("/images/resistor2.png") && six.Source.ToString().Contains("/images/npn-transistor.png"))
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes)
                    {
                        tb.IsEnabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Схема собрана неверно. Попробуйте ещё раз. У вас осталась 1 попытка.");
                }
            }
            else if(IsSchemeCorrect)
            {
                if(table_tb1.Text == "1" && table_tb2.Text == "1" && table_tb3.Text == "1" && table_tb4.Text == "0")
                {
                    MessageBox.Show("Таблица заполнена верно! Приступайте к следующей задаче.");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    secondTask.IsEnabled = true;
                    button_task1.IsEnabled = false;
                }

                else
                {
                    MessageBox.Show("Таблица заполнена неверно! Приступайте к следующей задаче.");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    secondTask.IsEnabled = true;
                    button_task1.IsEnabled = false;
                }

            }
            else if(!IsSchemeCorrect && attemptNumber == 2)
            {
                if (first.Source.ToString().Contains("/images/diod.png") && second.Source.ToString().Contains("/images/diod.png") && third.Source.ToString().Contains("/images/diod.png") && forth.Source.ToString().Contains("/images/resistor2.png") && fifth.Source.ToString().Contains("/images/resistor2.png") && seven.Source.ToString().Contains("/images/resistor2.png") && six.Source.ToString().Contains("/images/npn-transistor.png"))
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes)
                    {
                        tb.IsEnabled = true;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Попытки собрать схему закончились. Ваш результат сохранён. Можете приступить к следующей задаче.");
                    foreach(Image element in elements)
                    {
                        element.AllowDrop = false;
                    }
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    secondTask.IsEnabled = true;
                    button_task1.IsEnabled = false;
                }
                
            }
            
        }

        private void button_task2_Click(object sender, RoutedEventArgs e)
        {
            attemptNumber += 1;
            if (!IsSchemeCorrect && attemptNumber < 2)
            {
                if (transistor1.Source.ToString().Contains("/images/kmop-p.png") && transistor2.Source.ToString().Contains("/images/kmop-p.png") && transistor3.Source.ToString().Contains("/images/kmop-p.png") && transistor4.Source.ToString().Contains("/images/kmop-n.png") && transistor5.Source.ToString().Contains("/images/kmop-n.png") && transistor6.Source.ToString().Contains("/images/kmop-n.png"))
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes2)
                    {
                        tb.IsEnabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Схема собрана неверно. Попробуйте ещё раз. У вас осталась 1 попытка.");
                }
            }
            else if (IsSchemeCorrect)
            {
                if (table1_tb1.Text == "1" && table1_tb2.Text == "0" && table1_tb3.Text == "0" && table1_tb4.Text == "0" && table1_tb5.Text == "0" && table1_tb6.Text == "0" && table1_tb7.Text == "0" && table1_tb8.Text == "0")
                {
                    MessageBox.Show("Таблица заполнена верно! Приступайте к следующей задаче.");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    thirdTask.IsEnabled = true;
                    button_task2.IsEnabled = false;
                }

                else
                {
                    MessageBox.Show("Таблица заполнена неверно! Приступайте к следующей задаче.");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    thirdTask.IsEnabled = true;
                    button_task2.IsEnabled = false;
                }

            }
            else if (!IsSchemeCorrect && attemptNumber == 2)
            {
                if (table1_tb1.Text == "1" && table1_tb2.Text == "0" && table1_tb3.Text == "0" && table1_tb4.Text == "0" && table1_tb5.Text == "0" && table1_tb6.Text == "0" && table1_tb7.Text == "0" && table1_tb8.Text == "0")
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes2)
                    {
                        tb.IsEnabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Попытки собрать схему закончились. Ваш результат сохранён. Можете приступить к следующей задаче.");
                    foreach (Image element in elements)
                    {
                        element.AllowDrop = false;
                    }
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    thirdTask.IsEnabled = true;
                    button_task2.IsEnabled = false;
                }

            }
        }

        private void button_task3_Click(object sender, RoutedEventArgs e)
        {
            attemptNumber += 1;
            if (!IsSchemeCorrect && attemptNumber < 2)
            {
                if (first3.Source.ToString().Contains("/images/diod.png") && second3.Source.ToString().Contains("/images/diod.png") && third3.Source.ToString().Contains("/images/resistor2.png") && forth3.Source.ToString().Contains("/images/npn-transistor.png") && fifth3.Source.ToString().Contains("/images/resistor2.png"))
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes3)
                    {
                        tb.IsEnabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Схема собрана неверно. Попробуйте ещё раз. У вас осталась 1 попытка.");
                }
            }
            else if (IsSchemeCorrect)
            {
                if (table3_tb1.Text == "1" && table3_tb2.Text == "0" && table3_tb3.Text == "0" && table3_tb4.Text == "0")
                {
                    MessageBox.Show("Таблица заполнена верно! Teст пройден");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    button_task3.IsEnabled = false;
                    MainWindow mainMenu = new MainWindow();
                    mainMenu.Show();
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Таблица заполнена неверно! Тест окончен.");
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    button_task3.IsEnabled = false;
                    MainWindow mainMenu = new MainWindow();
                    mainMenu.Show();
                    this.Close();
                }

            }
            else if (!IsSchemeCorrect && attemptNumber == 2)
            {
                if (first3.Source.ToString().Contains("/images/diod.png") && second3.Source.ToString().Contains("/images/diod.png") && third3.Source.ToString().Contains("/images/resistor2.png") && forth3.Source.ToString().Contains("/images/npn-transistor.png") && fifth3.Source.ToString().Contains("/images/resistor2.png"))
                {
                    MessageBox.Show("Схема собрана верно. Заполните таблицу истиности");
                    IsSchemeCorrect = true;
                    //Дописать проверку на правильное положение элементов

                    foreach (TextBox tb in table_textBoxes3)
                    {
                        tb.IsEnabled = true;
                    }

                }
                else
                {
                    MessageBox.Show("Попытки собрать схему закончились. Ваш результат сохранён. Тест окончен.");
                    foreach (Image element in elements)
                    {
                        element.AllowDrop = false;
                    }
                    attemptNumber = 0;
                    IsSchemeCorrect = false;
                    button_task3.IsEnabled = false;
                    MainWindow mainMenu = new MainWindow();
                    mainMenu.Show();
                    this.Close();
                }

            }
        }

        /* private void Rotate180_Click(object sender, RoutedEventArgs e)
         {
             MenuItem mnu = sender as MenuItem;
             Image img = null;
             if (mnu != null)
             {
                 img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
                 TransformGroup transforms = img.RenderTransform as TransformGroup;

                 RotateTransform rotation = transforms.Children[0] as RotateTransform;
                 if (rotation != null) // Make sure the transform is actually a RotateTransform
                 {
                     double rotationInDegrees = rotation.Angle;
                     img.RenderTransformOrigin = new Point(0.5, 0.5);
                     RotateTransform rotateTransform = new RotateTransform(rotationInDegrees + 180);
                     transforms.Children[0] = rotateTransform;
                     img.RenderTransform = transforms;
                 }
             }
         }

         private void Mirror_Click(object sender, RoutedEventArgs e)
         {
             MenuItem mnu = sender as MenuItem;
             Image img = null;
             if (mnu != null)
             {
                 img = ((ContextMenu)mnu.Parent).PlacementTarget as Image;
                 TransformGroup transforms = img.RenderTransform as TransformGroup;

                 ScaleTransform transform = transforms.Children[1] as ScaleTransform;
                 if (transform != null) // Make sure the transform is actually a RotateTransform
                 {
                     double scale = transform.ScaleX;
                     img.RenderTransformOrigin = new Point(0.5, 0.5);
                     ScaleTransform scaleTransform = new ScaleTransform(scale * (-1), 1);
                     transforms.Children[1] = scaleTransform;
                     img.RenderTransform = transforms;
                 }
             }
         }
         */
    }
}
