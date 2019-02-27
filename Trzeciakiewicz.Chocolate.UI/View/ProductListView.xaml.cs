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

            this.DataContext = new ProductListViewModel();
        }
    }
}
