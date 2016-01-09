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
            testGraph.Title = "Test Graph";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            testGraph.InvalidatePlot(true);

            int startingNumber;
            startingNumber = Int32.Parse(textBox.Text);

            CollatzConjecture collatzCalculator = new CollatzConjecture(startingNumber);

            Dictionary<int, int> collatzData = collatzCalculator.Calculate();

            List<DataPoint> collatzPoints = new List<DataPoint>();

            foreach (var kvp in collatzData)
            {
                collatzPoints.Add(new DataPoint(kvp.Key, kvp.Value));
            }

            TestSeries.ItemsSource = collatzPoints;
        }
    }
}
