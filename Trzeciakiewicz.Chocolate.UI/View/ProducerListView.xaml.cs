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

            this.DataContext = new ProducerListViewModel();
        }
    }
}
