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

namespace MainPlc
{
    /// <summary>
    /// Interaction logic for fbStationView.xaml
    /// </summary>
    public partial class fbStationView : UserControl
    {
        public fbStationView()
        {
            InitializeComponent();
        }

        private fbStation _context
        {
            get
            {
                return this.DataContext as fbStation;
            }
        }

        private void ButtonAutomat_Click(object sender, RoutedEventArgs e)
        {
            _context._modeSelector.Cyclic = (int)enumMode.Automat;
        }

        private void ButtonGround_Click(object sender, RoutedEventArgs e)
        {
            _context._modeSelector.Cyclic = (int)enumMode.Ground;
        }

        private void ButtonManual_Click(object sender, RoutedEventArgs e)
        {
            _context._modeSelector.Cyclic = (int)enumMode.Manual;
        }
    }
}
