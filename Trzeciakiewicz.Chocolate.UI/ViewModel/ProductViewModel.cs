using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProductViewModel : BindableBase, IChocolate
    {
        private IChocolate _product;

        public ProductViewModel(IChocolate product)
        {
            _product = product;
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

        public string Name
        {
            get => _product.Name;
            set
            {
                _product.Name = value;
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
                RaisePropertyChanged("Type");
            }
        }

        private EChocolateStuffed _stuffed;

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
                RaisePropertyChanged("Stuffed");
            }
        }

        private EChocolateAdditions _additions;

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
                RaisePropertyChanged("Additions");
            }
        }


        private IProducer _producer;

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
