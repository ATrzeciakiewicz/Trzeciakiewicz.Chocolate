using System.ComponentModel.DataAnnotations;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;
using Trzeciakiewicz.Chocolate.UI.Validation;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProducerViewModel : ValidationBase
    {
        private IProducer _producer;

        public ProducerViewModel(IProducer producer)
        {
            _producer = producer;
            
        }

        [Required]
        public string Name
        {
            get => _producer.Name;
            set
            {
                _producer.Name = value;
                Validate();
                RaisePropertyChanged("Name");
            }
        }

        private ECountry _country;
        [Required]
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
                Validate();
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
