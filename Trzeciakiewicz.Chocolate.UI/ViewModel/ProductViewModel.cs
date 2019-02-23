using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProductViewModel
    {
        public ObservableCollection<IChocolate> GetData { get; set; }

        private IEnumerable<IChocolate> Product { get; set; }

        public ProductViewModel()
        {

        }

        public ProductViewModel(IEnumerable<IChocolate> products)
        {
            this.Product = products;           
            GetData = new ObservableCollection<IChocolate>();
            GetData.AddRange(Product);
        }
    }
}
