using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRODIGY_SD_01
{
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void TemperatureConverter_Load(object sender, EventArgs e)
        {
            cmbUnit.Items.Add("Celsius");
            cmbUnit.Items.Add("Fahrenheit");
            cmbUnit.Items.Add("Kelvin");
            cmbUnit.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double temperature = Convert.ToDouble(txtTemperature.Text);
                string unit = cmbUnit.SelectedItem.ToString();
                double fahrenheit, celsius, kelvin;
                switch (unit)
                {
                    case "Celsius":
                        celsius = temperature;
                        fahrenheit = celsius * 9 / 5 + 32;
                        kelvin = celsius + 273.15;
                        lblCelsius.Text = celsius.ToString() + "°C";
                        lblFahrenheit.Text = fahrenheit.ToString() + "°F";
                        lblKelvin.Text = kelvin.ToString() + "K";
                        break;

                    case "Fahrenheit":
                        fahrenheit = temperature;
                        celsius = (fahrenheit - 32) * 5 / 9;
                        kelvin = celsius + 273.15;
                        lblCelsius.Text = celsius.ToString() + "°C";
                        lblFahrenheit.Text = fahrenheit.ToString() + "°F";
                        lblKelvin.Text = kelvin.ToString() + "K";
                        break;

                    case "Kelvin":
                        kelvin = temperature;
                        celsius = kelvin - 273.15;
                        fahrenheit = celsius * 9 / 5 + 32;
                        lblCelsius.Text = celsius.ToString() + "°C";
                        lblFahrenheit.Text = fahrenheit.ToString() + "°F";
                        lblKelvin.Text = kelvin.ToString() + "K";
                        break;
                }
            }
            catch (FormatException) { MessageBox.Show("Invalid input! Try again"); }

        }
    }
}
