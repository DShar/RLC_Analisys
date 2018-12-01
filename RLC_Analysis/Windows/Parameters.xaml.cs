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
    /// Interaction logic for Parameters.xaml
    /// </summary>
    public partial class Parameters : Window
    {
        ElementTypes elementType;
        CircuitTypes circuitType;

        protected PowerSupply voltage = new PowerSupply();

        protected bool isCorrectAmplitude = false;
        protected bool isCorrectFrequency = false;
        protected bool isCorrectPhase = false;

        public Parameters(ElementTypes type, CircuitTypes circ_type)
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();

            elementType = type;
            circuitType = circ_type;
        }

        private void SetParameters(SeriesCircuitWindow mainWindow)
        {
            
        }

        private void SetParameters(ParallelCircuitWindow mainWindow)
        {
            
        }

        private void SetParameters(CustomCircuit mainWindow)
        {
            double result;

            if (Double.TryParse(this.amplitude.Text, out result))
            {
                if (amplitude.Text != "")
                {
                    voltage.Amplitude = Double.Parse(amplitude.Text);
                    if (Double.Parse(amplitude.Text) < 0 || Double.Parse(amplitude.Text) > 1000)
                    {
                        isCorrectAmplitude = false;
                    }
                    else
                    {
                        isCorrectAmplitude = true;
                    }
                }
                else
                {
                    isCorrectAmplitude = false;
                }
            }
            else
            {
                isCorrectAmplitude = false;
            }

            if (Double.TryParse(this.frequency.Text, out result))
            {
                if (frequency.Text != "")
                {
                    voltage.setFrequency(Double.Parse(frequency.Text));
                    if (Double.Parse(frequency.Text) < 0)
                    {
                        isCorrectFrequency = false;
                    }
                    else
                    {
                        isCorrectFrequency = true;
                    }
                }
                else
                {
                    isCorrectFrequency = false;
                }
            }
            else
            {
                isCorrectFrequency = false;
            }

            if (Double.TryParse(this.phase.Text, out result))
            {
                if (phase.Text != "")
                {
                    voltage.Phase = Double.Parse(phase.Text);
                    if (Double.Parse(phase.Text) < 0 || Double.Parse(phase.Text) > 360)
                    {
                        isCorrectPhase = false;
                    }
                    else
                    {
                        isCorrectPhase = true;
                    }
                }
                else
                {
                    isCorrectPhase = true;
                    voltage.Phase = 0;
                }
            }
            else
            {
                isCorrectPhase = false;
            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            switch(circuitType)
            {
                case CircuitTypes.Parallel:
                    ParallelCircuitWindow ParallelMainWindow = (ParallelCircuitWindow)this.Owner;
                    SetParameters(ParallelMainWindow);
                    this.Close();
                    break;
                case CircuitTypes.Series:
                    SeriesCircuitWindow seriesMainWindow = (SeriesCircuitWindow)this.Owner;
                    SetParameters(seriesMainWindow);
                    this.Close();
                    break;
                case CircuitTypes.Custom:
                    CustomCircuit customMainWindow = (CustomCircuit)this.Owner;
                    SetParameters(customMainWindow);
                    if (isCorrectAmplitude && isCorrectFrequency && isCorrectPhase)
                    {
                        customMainWindow.circuit.power = voltage;
                        customMainWindow.voltage_label.Content = voltage.getValue();
                        this.Close();
                    }
                    else
                    {
                        if(!isCorrectAmplitude)
                        {
                            error_amplitude.Text = "Неккооректное значение";
                        }
                        if(!isCorrectFrequency)
                        {
                            error_frequency.Text = "Неккооректное значение";
                        }
                        if(!isCorrectPhase)
                        {
                            error_phase.Text = "Неккооректное значение";
                        }
                    }
                    this.Close();
                    break;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

