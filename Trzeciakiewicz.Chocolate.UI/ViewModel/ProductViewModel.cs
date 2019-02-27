using System.Collections.Generic;
using System.Collections.ObjectModel;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;
using System.ComponentModel.DataAnnotations;
using Trzeciakiewicz.Chocolate.UI.Validation;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProductViewModel : ValidationBase
    {
        private IChocolate _product;

        public ProductViewModel(IChocolate product, IEnumerable<IProducer> producers)
        {
            _product = product;
            _producers = new ObservableCollection<IProducer>(producers);
        }

        public int ID
        {
            get => _product.ID;
            set
            {
                _product.ID = value;
                RaisePropertyChanged("ID");
            }
        }

        [Required]
        public string Name
        {
            get => _product.Name;
            set
            {
                _product.Name = value;
                Validate();
                RaisePropertyChanged("Name");
            }
        }

        public int ProducerID
        {
            get => _product.ProducerID;
            set
            {
                _product.ProducerID = value;
                RaisePropertyChanged("ProducerID");
            }
        }

        private EChocolateType _type;
        [Required]
        public EChocolateType Type
        {
            get
            {
                if (_product.Name != null)
                {
                    return _product.Type;
                }
                return _type;
            }
            set
            {
                _product.Type = value;
                Validate();
                RaisePropertyChanged("Type");
            }
        }

        private EChocolateStuffed _stuffed;
        [Required]
        public EChocolateStuffed Stuffed
        {
            get
            {
                if (_product.Name != null)
                {
                    return _product.Stuffed;
                }
                return _stuffed;
            }
            set
            {
                _product.Stuffed = value;
                Validate();
                RaisePropertyChanged("Stuffed");
            }
        }

        private EChocolateAdditions _additions;
        [Required]
        public EChocolateAdditions Additions
        {
            get
            {
                if (_product.Name != null)
                {
                    return _product.Additions;
                }
                return _additions;
            }
            set
            {
                _product.Additions = value;
                Validate();
                RaisePropertyChanged("Additions");
            }
        }


        private IProducer _producer;
        [Required]
        public IProducer Producer
        {
            get
            {
                if (_product.Name != null)
                {
                    return _product.Producer;
                }
                return _producer;
            }
            set
            {
                _product.Producer = value;
                _producer = value;
                Validate();
                RaisePropertyChanged("Producer");
            }
        }

        private ObservableCollection<IProducer> _producers;

        public ObservableCollection<IProducer> Producers
        {
            get => _producers;
        }
    }
}
