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
    /// Interaction logic for fbStepConveyorManualView.xaml
    /// </summary>
    public partial class fbStepConveyorManualView : UserControl
    {
        public fbStepConveyorManualView()
        {
            InitializeComponent();
        }

        private fbStepConveyor _context
        {
            get
            {
                return this.DataContext as fbStepConveyor;
            }
        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            _context._manualMove.Cyclic = true;
        }

    }
}
