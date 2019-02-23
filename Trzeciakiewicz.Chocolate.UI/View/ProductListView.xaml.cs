using System.Windows.Controls;
using Trzeciakiewicz.Chocolate.UI.ViewModel;

namespace Trzeciakiewicz.Chocolate.UI.View
{
    /// <summary>
    /// Interaction logic for ProductListView.xaml
    /// </summary>
    public partial class ProductListView : UserControl
    {
        public ProductListView()
        {
            InitializeComponent();

            string _settingsProperty = UI.Properties.Settings.Default.DAO;

            BLC.BLC blc = new BLC.BLC(_settingsProperty);

            this.DataContext = new ProductViewModel(blc.GetChocolates());
        }
    }
}
