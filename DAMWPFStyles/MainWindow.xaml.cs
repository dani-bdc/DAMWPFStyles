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

namespace DAMWPFStyles
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

        private void simpleStyleButton_Click(object sender, RoutedEventArgs e)
        {
            new SimpleStyleWindow().ShowDialog();
        }

        private void eventTriggerButton_Click(object sender, RoutedEventArgs e)
        {
            new EventTriggerWindow().ShowDialog();
        }

        private void propertyTriggerButton_Click(object sender, RoutedEventArgs e)
        {
            new PropertyTriggerWindow().ShowDialog();
        }

        private void dataTriggerButton_Click(object sender, RoutedEventArgs e)
        {
            new DataTriggerWindow().ShowDialog();
        }

        private void animationTriggerButton_Click(object sender, RoutedEventArgs e)
        {
            new AnimationTriggerWindow().ShowDialog();
        }
    }
}
