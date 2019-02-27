using Prism.Mvvm;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProducerViewModel : BindableBase, IProducer
    {
        private IProducer _producer;

        public ProducerViewModel(IProducer producer)
        {
            _producer = producer;
            
        }

        public string Name
        {
            get => _producer.Name;
            set
            {
                _producer.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        private ECountry _country;

        public ECountry OriginsCountry
        {
            get
            {
                if (_producer.Name != null)
                {
                    return _producer.OriginsCountry;
                }
                return _country;
            }
            set
            {
                _producer.OriginsCountry = value;
                RaisePropertyChanged("OriginsCountry");
            }
        }

        public int ID
        {
            get => _producer.ID;
            set
            {
                _producer.ID = value;
                RaisePropertyChanged("ID");
            }
        }
    }
}
