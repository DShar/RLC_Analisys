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
    /// Interaction logic for MatrixWindow.xaml
    /// </summary>
    public partial class MatrixWindow : Window
    {
        Circuit circuit = new Circuit();
        Label[] valLabels = new Label[5];

        public MatrixWindow(Circuit circ, Label[] valueLabels)
        {
            InitializeComponent();
            circuit = circ;
            valLabels = valueLabels;
            CreateTableOKB(circuit);
            CreateTableROKB(circuit);
        }

        private void CreateTableOKB(Circuit circuit)
        {
            FlowDocument oDoc = new FlowDocument();
            // Create the Table...
            Table table1 = new Table();
            oDoc.Blocks.Add(table1);

            // Set some global formatting properties for the table.
            table1.CellSpacing = 10;
            table1.Background = Brushes.White;
            table1.BorderBrush = Brushes.Black;
            
                int rang = 3 + circuit.elements.Where(e => e.type == ElementTypes.Inductor).ToList().Count;
                for (int x = 0; x < 3; x++)
                {
                    table1.Columns.Add(new TableColumn());                   
                }               
            

            // Create and add an empty TableRowGroup to hold the table's Rows.
            table1.RowGroups.Add(new TableRowGroup());
            table1.RowGroups[0].Rows.Add(new TableRow());
      //--------------------------------------------------1 ROW---------------------------------------------------------------//
                TableRow currentRow = table1.RowGroups[0].Rows[0];
                string element1 = "Yвн";
                switch (circuit.elements.First(e => e.number == 3).type)
                {
                    case ElementTypes.Capacitor:
                        element1 += "+p" + valLabels[2].Content.ToString();
                        break;
                    case ElementTypes.Inductor:
                        element1 += "+1/p" + valLabels[2].Content.ToString();
                        break;
                    default:
                        element1 += "+" + valLabels[2].Content.ToString();
                        break;
                }
                switch (circuit.elements.First(e => e.number == 1).type)
                {
                    case ElementTypes.Capacitor:
                        element1 += "+p" + valLabels[0].Content.ToString();
                        break;
                    case ElementTypes.Inductor:
                        element1 += "+1/p" + valLabels[0].Content.ToString();
                        break;
                    default:
                        element1 += "+" + valLabels[0].Content.ToString();
                        break;
                }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element1))));
                switch(circuit.elements.First(e => e.number == 1).type)
                {
                    case ElementTypes.Capacitor:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[0].Content.ToString()))));
                    break;
                    case ElementTypes.Inductor:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-1/p" + valLabels[0].Content.ToString()))));
                    break;
                    default:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[0].Content.ToString()))));
                    break;
                }
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U1"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("    "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("E*Yвн"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));

            //-------------------------------------------------------2 ROW-----------------------------------------------------------------//
            table1.RowGroups[0].Rows.Add(new TableRow());
                currentRow = table1.RowGroups[0].Rows[1];
                switch (circuit.elements.First(e => e.number == 1).type)
                {
                    case ElementTypes.Capacitor:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[0].Content.ToString()))));
                        break;
                    case ElementTypes.Inductor:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-1/p" + valLabels[0].Content.ToString()))));
                        break;
                    default:
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[0].Content.ToString()))));
                        break;
                }
            string element2 = "";
            switch (circuit.elements.First(e => e.number == 1).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "p" + valLabels[0].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += "1/p" + valLabels[0].Content.ToString();
                    break;
                default:
                    element2 += valLabels[0].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 4).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "+p" + valLabels[3].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += "+1/p" + valLabels[3].Content.ToString();
                    break;
                default:
                    element2 += "+" + valLabels[3].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "+p" + valLabels[1].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += "+1/p" + valLabels[1].Content.ToString();
                    break;
                default:
                    element2 += "+" + valLabels[1].Content.ToString();
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element2))));
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[1].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-1/p" + valLabels[1].Content.ToString()))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[1].Content.ToString()))));
                    break;
            }

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U2"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("  =  "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));

            //----------------------------------------------------3 ROW----------------------------------------------------------------//
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[2];

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[1].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-1/p" + valLabels[1].Content.ToString()))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[1].Content.ToString()))));
                    break;
            }

            string element3 = "";
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    element3 += "p" + valLabels[1].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element3 += "1/p" + valLabels[1].Content.ToString();
                    break;
                default:
                    element3 += valLabels[1].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 5).type)
            {
                case ElementTypes.Capacitor:
                    element3 += "+p" + valLabels[4].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element3 += "+1/p" + valLabels[4].Content.ToString();
                    break;
                default:
                    element3 += "+" + valLabels[4].Content.ToString();
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element3))));

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U3"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("    "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
           
            OKB.Content = oDoc;
        }


        private void CreateTableROKB(Circuit circuit)
        {
            FlowDocument oDoc = new FlowDocument();
            // Create the Table...
            Table table1 = new Table();


            oDoc.Blocks.Add(table1);

            // Set some global formatting properties for the table.
            table1.CellSpacing = 0;
            table1.Background = Brushes.White;
            table1.BorderBrush = Brushes.Black;

            int inductorsCount = circuit.elements.Where(e => e.type == ElementTypes.Inductor).ToList().Count;

            int rang = 3 + inductorsCount;
            for (int x = 0; x < rang; x++)
            {
                table1.Columns.Add(new TableColumn());
            }

            //Elements in additional rows
            List<int>[] AdditionalElements = new List<int>[inductorsCount];
            int i = 0;
            foreach (var ind in circuit.elements.Where(e => e.type == ElementTypes.Inductor))
            {
                switch (ind.number)
                {
                    case 1:
                        AdditionalElements[i++] = new List<int> { -1, 1, 0};
                        break;
                    case 2:
                        AdditionalElements[i++] = new List<int> { 0, -1, 1};
                        break;
                    case 3:
                        AdditionalElements[i++] = new List<int> { 1, 0, 0 };
                        break;
                    case 4:
                        AdditionalElements[i++] = new List<int> { 0, 1, 0 };
                        break;
                    case 5:
                        AdditionalElements[i++] = new List<int> { 0, 0, 1 };
                        break;
                }
            }

            // Create and add an empty TableRowGroup to hold the table's Rows.
            table1.RowGroups.Add(new TableRowGroup());
            table1.RowGroups[0].Rows.Add(new TableRow());
            //--------------------------------------------------1 ROW---------------------------------------------------------------//
            TableRow currentRow = table1.RowGroups[0].Rows[0];
            string element1 = "Yвн";
            switch (circuit.elements.First(e => e.number == 3).type)
            {
                case ElementTypes.Capacitor:
                    element1 += "+p" + valLabels[2].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element1 += string.Empty;
                    break;
                default:
                    element1 += "+" + valLabels[2].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 1).type)
            {
                case ElementTypes.Capacitor:
                    element1 += "+p" + valLabels[0].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element1 += string.Empty;
                    break;
                default:
                    element1 += "+" + valLabels[0].Content.ToString();
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element1))));
            switch (circuit.elements.First(e => e.number == 1).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[0].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[0].Content.ToString()))));
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            if(inductorsCount > 0)
            {
                for(int it=0; it< inductorsCount; it++)
                {
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(0).ToString()))));
                }
            }

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U1"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("    "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("E*Yвн"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));

            //-------------------------------------------------------2 ROW-----------------------------------------------------------------//
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[1];
            switch (circuit.elements.First(e => e.number == 1).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[0].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[0].Content.ToString()))));
                    break;
            }
            string element2 = "";
            switch (circuit.elements.First(e => e.number == 1).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "p+" + valLabels[0].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += string.Empty;
                    break;
                default:
                    element2 += valLabels[0].Content.ToString() + "+";
                    break;
            }
            switch (circuit.elements.First(e => e.number == 4).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "p" + valLabels[3].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += string.Empty;
                    break;
                default:
                    element2 += valLabels[3].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    element2 += "+p" + valLabels[1].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element2 += string.Empty;
                    break;
                default:
                    element2 += "+" + valLabels[1].Content.ToString();
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element2))));
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[1].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[1].Content.ToString()))));
                    break;
            }
            if (inductorsCount > 0)
            {
                for (int it = 0; it < inductorsCount; it++)
                {
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(1).ToString()))));
                }
            }

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U2"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("  =  "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            //----------------------------------------------------3 ROW----------------------------------------------------------------//
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[2];

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-p" + valLabels[1].Content.ToString()))));
                    break;
                case ElementTypes.Inductor:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
                    break;
                default:
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-" + valLabels[1].Content.ToString()))));
                    break;
            }

            string element3 = "";
            switch (circuit.elements.First(e => e.number == 2).type)
            {
                case ElementTypes.Capacitor:
                    element3 += "p" + valLabels[1].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element3 += string.Empty;
                    break;
                default:
                    element3 += valLabels[1].Content.ToString();
                    break;
            }
            switch (circuit.elements.First(e => e.number == 5).type)
            {
                case ElementTypes.Capacitor:
                    element3 += "+p" + valLabels[4].Content.ToString();
                    break;
                case ElementTypes.Inductor:
                    element3 += string.Empty;
                    break;
                default:
                    element3 += "+" + valLabels[4].Content.ToString();
                    break;
            }
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(element3))));
            if (inductorsCount > 0)
            {
                for (int it = 0; it < inductorsCount; it++)
                {
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(2).ToString()))));
                }
            }

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("U3"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("    "))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
            //-------------------------------------------------------4 ROW -------------------------------------------//

            if (inductorsCount > 0)
            {
                for (int it = 0; it < inductorsCount; it++)
                {
                    table1.RowGroups[0].Rows.Add(new TableRow());
                    currentRow = table1.RowGroups[0].Rows[3 + it];
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(0).ToString()))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(1).ToString()))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run(AdditionalElements[it].ElementAt(2).ToString()))));

                    for(int k = 0; k < inductorsCount; k++)
                    {
                        currentRow.Cells.Add(new TableCell(new Paragraph(new Run("-pL"))));
                    }

                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("L"))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("    "))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("0"))));
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("|"))));
                }
            }
            
            ROKB.Content = oDoc;
        }
    }
}
