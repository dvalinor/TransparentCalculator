using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace TransparentCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);

            InputHandler.HandleInput(this, e);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left) {
                this.DragMove();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e) {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            //MessageBox.Show(((Button)sender).Content.ToString());
            string btn = ((Button)sender).Content.ToString();
            if (btn == ".") {
                if (Display.Text.Last() == '.' && Display.Text.Last() == '/' && Display.Text.Last() == '*' && Display.Text.Last() == '-' && Display.Text.Last() == '+' && Display.Text.Last() == '=') {
                    return;
                }

                Display.Text += btn;

            } else if (btn == "=") {
                System.Data.DataTable dt = new System.Data.DataTable();

                var eval = dt.Compute(Display.Text, "");
                eval = String.Format("{0:0.000}", eval);
                Display.Text = eval.ToString().Replace(',', '.');

            } else {
                Display.Text += btn;
            }


        }
    }
}
