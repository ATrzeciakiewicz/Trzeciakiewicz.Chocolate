using System.Collections.Generic;
using System.Collections.ObjectModel;
using Trzeciakiewicz.Chocolate.Interfaces;
using Prism.Mvvm;
using Prism.Commands;
using System.Linq;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProductListViewModel : BindableBase
    {
        private ObservableCollection<IChocolate> _products;

        public ObservableCollection<IChocolate> Products
        {
            get => _products;
            set
            {
                _products = value;
                RaisePropertyChanged("Products");
            }
        }

        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand EditCommand { get; private set; }
        public DelegateCommand DeleteCommand { get; private set; }      

        private IEnumerable<IChocolate> Product { get; set; }
        private IChocolate _editableProduct;

        public ProductListViewModel()
        {
            GetData();
            InitializeCommands();
        }

        private void GetData()
        {
            string _settingsProperty = UI.Properties.Settings.Default.DAO;
            BLC.BLC blc = new BLC.BLC(_settingsProperty);

            _editableProduct = blc.EmptyChocolate();
            this.Product = blc.GetChocolates();

            Products = new ObservableCollection<IChocolate>();
            Products.AddRange(Product);

            EditProduct = new ProductViewModel(blc.EmptyChocolate(), blc.GetProducers());
        }

        private void InitializeCommands()
        {
            AddCommand = new DelegateCommand(Add, CanAdd);
            DeleteCommand = new DelegateCommand(Delete, CanDelete);
            EditCommand = new DelegateCommand(Edit, CanEdit);
        }

        private IChocolate _selectedProduct;
        public IChocolate SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                _selectedProduct = value;
                if (_selectedProduct != null)
                {
                    EditProduct.Name = _selectedProduct.Name;
                    EditProduct.ID = _selectedProduct.ID;
                    EditProduct.ProducerID = _selectedProduct.ProducerID;
                    EditProduct.Additions = _selectedProduct.Additions;
                    EditProduct.Stuffed = _selectedProduct.Stuffed;
                    EditProduct.Type = _selectedProduct.Type;
                    EditProduct.Producer = _selectedProduct.Producer;

                }
                RaisePropertyChanged("SelectedProduct");
            }
        }

        private ProductViewModel _editProduct;
        public ProductViewModel EditProduct
        {
            get => _editProduct;
            set
            {
                _editProduct = value;
                RaisePropertyChanged("EditProduct");
            }
        }


        private void Add()
        {
            _editableProduct.ID = Products.Count() + 1;
            _editableProduct.Name = EditProduct.Name;
            _editableProduct.Additions = EditProduct.Additions;
            _editableProduct.Stuffed = EditProduct.Stuffed;
            _editableProduct.Type = EditProduct.Type;
            
            if(EditProduct.Producer != null)
            {
                _editableProduct.ProducerID = EditProduct.Producer.ID;
                _editableProduct.Producer = EditProduct.Producer;
            }
            EditProduct.Validate();

            if (!EditProduct.HasErrors)
                _products.Add(_editableProduct);
        }

        private bool CanAdd()
        {
            return true;
        }

        private void Delete()
        {
            _products.Remove(_products.Where(x => x.ID == EditProduct.ID).Single());
        }

        private bool CanDelete()
        {
            return true;
        }

        private void Edit()
        {
            var editedProducer = _products.Where(x => x.ID == EditProduct.ID).Single();

            int index = _products.IndexOf(editedProducer);
            _editableProduct.ID = EditProduct.ID;
            _editableProduct.Name = EditProduct.Name;
            _editableProduct.ProducerID = EditProduct.ProducerID;
            _editableProduct.Additions = EditProduct.Additions;
            _editableProduct.Stuffed = EditProduct.Stuffed;
            _editableProduct.Type = EditProduct.Type;
            _editableProduct.Producer = EditProduct.Producer;

            _products.Remove(editedProducer);
            _products.Insert(index, _editableProduct);
        }

        private bool CanEdit()
        {
            return true;
        }        
    }
}
