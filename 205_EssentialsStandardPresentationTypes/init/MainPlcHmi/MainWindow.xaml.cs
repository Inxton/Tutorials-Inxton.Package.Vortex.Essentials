using MainPlc;
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

namespace MainPlcHmi
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


        public MainPlcTwinController _context
        {
            get
            {
                return this.DataContext as MainPlcTwinController;
            }
        }

        private void LoadToPlcButton_Click(object sender, RoutedEventArgs e)
        {
            _context.MAIN._station._data.FlushShadowToOnline();
        }
    }
}
