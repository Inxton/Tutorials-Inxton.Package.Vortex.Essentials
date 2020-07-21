using MainPlcHmi.Simulation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vortex.Connector;


namespace MainPlc
{
    /// <summary>
    /// Interaction logic for fbStationView.xaml
    /// </summary>
    public partial class fbStationView : UserControl
    {
        private UnitySimulation unity;

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
        
        private void ButtonOpenSimulation_Click(object sender, RoutedEventArgs e)
        {
            unity = new UnitySimulation();           
        }
    }

    public class EmptyNonEmptyStringToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value as string;

            return string.IsNullOrEmpty(val) ? Visibility.Hidden : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }

    public class ModeToTextConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Enum.GetName(typeof(enumMode), value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
