using System.Windows.Controls;
using Trzeciakiewicz.Chocolate.UI.ViewModel;

namespace Trzeciakiewicz.Chocolate.UI.View
{
    /// <summary>
    /// Interaction logic for ProducerListView.xaml
    /// </summary>
    public partial class ProducerListView : UserControl
    {
        public ProducerListView()
        {
            InitializeComponent();

            GetProducers();
        }

        private void GetProducers()
        {
            string _settingsProperty = UI.Properties.Settings.Default.DAO;

            BLC.BLC blc = new BLC.BLC(_settingsProperty);

            this.DataContext = new ProducerViewModel(blc.GetProducers());
        }
    }
}
