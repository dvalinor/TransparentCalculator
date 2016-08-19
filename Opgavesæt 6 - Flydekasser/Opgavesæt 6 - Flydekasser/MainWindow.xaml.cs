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

namespace Opgavesæt_6___Flydekasser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double density = 430; //kg/m^3
        private string shape = "Box";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void rdbShape_Checked(object sender, RoutedEventArgs e)
        {
            shape = ((RadioButton)sender).Content.ToString();
            switch (shape)
            {
                case "Box":
                    lblWidth.Content = "Width";
                    lblDepth.IsEnabled = true;
                    txtDepth.IsEnabled = true;
                    break;
                case "Cylinder":
                    lblWidth.Content = "Radius";
                    lblDepth.IsEnabled = false;
                    txtDepth.IsEnabled = false;
                    break;
            }
        }

        private void rdbMaterial_Checked(object sender, RoutedEventArgs e)
        {
            string material = ((RadioButton)sender).Content.ToString();

            switch (material)
            {
                case "Wood":
                    density = 430;
                    break;
                case "Aluminium":
                    density = 2712;
                    break;
                case "Plastic":
                    density = 1300;
                    break;
                case "Glass":
                    density = 2400;
                    break;
                case "Iron":
                    density = 7870;
                    break;
            }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            Calclulator calc = new Calclulator();

            double h = double.Parse(txtHeight.Text);
            double t = double.Parse(txtThickness.Text);

            double weight = 0;
            double volume = 0;
            double boyancy = 0;

            switch (shape)
            {
                case "Box":
                    double w = double.Parse(txtWidth.Text);
                    double d = double.Parse(txtDepth.Text);
                    weight = calc.CalculateBoxWeight(h, w, d, t, density);
                    volume = calc.CalculateBoxVolume(h, w, d);
                    break;
                case "Cylinder":
                    double r = double.Parse(txtWidth.Text);
                    weight = calc.CalculateCylinderWeight(h, r, t, density);
                    volume = calc.CalculateCylinderVolume(h, r);
                    break;
            }

            boyancy = calc.CalculateBoyancyProvess(weight, volume);

            txtWeight.Text = Math.Round(weight, 2).ToString() + " kg.";
            txtVolume.Text = Math.Round(volume, 2).ToString() + " m^3";
            txtBoyancy.Text = Math.Round(boyancy, 2).ToString() + " kg.";
        }
    }
}
