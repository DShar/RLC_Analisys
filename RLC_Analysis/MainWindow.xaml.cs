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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using Microsoft.Win32;
using RLC_Analysis.Windows;

namespace RLC_Analysis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            //SaveFileDialog dlg = new SaveFileDialog();
            //dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //dlg.DefaultExt = ".pdf";
            ////dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            //if (dlg.ShowDialog() ?? false)
            //{
            //    using (XmlWriter writer = XmlWriter.Create(dlg.FileName))
            //    {
            //        // SimpleDiagramXmlSerializer ser = CreateSerializer();
            //        // ser.Serialize(writer, (SimpleDiagramModel)(ds.Diagram));
            //    }
            //}

            Window win;
            win = new UserGuide();
            win.Show();
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dlg.Multiselect = false;
            dlg.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            if (dlg.ShowDialog() ?? false)
            {
                using (XmlReader reader = XmlReader.Create(dlg.FileName))
                {
                    //SimpleDiagramXmlSerializer ser = CreateSerializer();
                    //ds.Diagram = ser.Deserialize(reader);
                }
            }
        }

        private void learningVariants_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Next_btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Window win;
        //    switch (learningVariants.SelectedIndex)
        //    {
        //        case 0:
        //            win = new ParallelCircuitWindow();
        //            break;
        //        case 1:
        //            win = new SeriesCircuitWindow();
        //            break;
        //        case 2:
        //            win = new ElectronicTasksWindow();
        //            break;
        //        case 3:
        //            win = new LogicSchemeTestWindow();
        //            break;
        //        case 4:
        //            win = new CustomCircuit();
        //            break;
        //        case 5:
        //            win = new MathModeling();
        //            break;
        //        default:
        //            win = new MainWindow();
        //            break;
        //    }
        //    win.Show();
        //    this.Close();
        //}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new ParallelCircuitWindow();

            win.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new SeriesCircuitWindow();

            win.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new ElectronicTasksWindow();

            win.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new LogicSchemeTestWindow();

            win.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new CustomCircuit();

            win.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Window win;

            win = new MathModeling();

            win.Show();
            this.Close();
        }
    }


}
