using Prism.Mvvm;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProducerViewModel : BindableBase
    {
        public ObservableCollection<IProducer> GetData { get; set; }

        private IEnumerable<IProducer> Producer { get; set; }

        public ProducerViewModel()
        {

        }

        public ProducerViewModel(IEnumerable<IProducer> producers)
        {
            this.Producer = producers;
            GetData = new ObservableCollection<IProducer>();
            GetData.AddRange(Producer);
        }
    }
}
