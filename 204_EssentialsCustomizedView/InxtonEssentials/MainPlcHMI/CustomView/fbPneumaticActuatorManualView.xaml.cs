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
using MainPlc;


namespace MainPlc
{
    /// <summary>
    /// Interaction logic for fbPneumaticActuatorManualView.xaml
    /// </summary>
    public partial class fbPneumaticActuatorManualView : UserControl
    {
        public fbPneumaticActuatorManualView()
        {
            InitializeComponent();
        }

        private fbPneumaticActuator _context
        {
            get
            {
                return this.DataContext as fbPneumaticActuator;
            }
        }

        private void ButtonExtend_Click(object sender, RoutedEventArgs e)
        {
            _context._manualExtend.Cyclic = true;
        }

        private void ButtonRetract_Click(object sender, RoutedEventArgs e)
        {
            _context._manualRetract.Cyclic = true;
        }
    }
}
