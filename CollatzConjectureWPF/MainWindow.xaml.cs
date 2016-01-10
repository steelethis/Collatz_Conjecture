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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace CollatzConjectureWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CollatzGraph.Title = "Results of Collatz Conjecture";
        }

        private void Start_OnClick(object sender, RoutedEventArgs e)
        {
            CollatzGraph.InvalidatePlot(true);

            int startingNumber;
            try
            {
                startingNumber = Int32.Parse(textBox.Text);
            }
            catch
            {
                MessageBox.Show("Invalid input!");
                return;
            }


            CollatzConjecture collatzCalculator = new CollatzConjecture(startingNumber);

            Dictionary<int, int> collatzData = collatzCalculator.Calculate();

            List<ScatterPoint> collatzPoints = new List<ScatterPoint>();

            foreach (var kvp in collatzData)
            {
                collatzPoints.Add(new ScatterPoint(kvp.Key, kvp.Value));
            }

            DataSeries.ItemsSource = collatzPoints;

        }
    }
}
