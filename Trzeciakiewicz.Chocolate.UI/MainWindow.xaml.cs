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
using Trzeciakiewicz.Chocolate.BLC;

namespace Trzeciakiewicz.Chocolate.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string _settingsProperty = UI.Properties.Settings.Default.DAO;

            BLC.BLC blc = new BLC.BLC(_settingsProperty);

            var producers = blc.GetProducers();

            var product = blc.GetChocolates();
        }
    }
}
