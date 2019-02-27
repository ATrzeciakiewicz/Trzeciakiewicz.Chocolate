using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.UI.ViewModel
{
    public class ProducerListViewModel : BindableBase
    {
        private ObservableCollection<IProducer> _producers;

        public ObservableCollection<IProducer> Producers
        {
            get => _producers;
            set
            {
                _producers = value;
                RaisePropertyChanged("Producers");
            }
        }

        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand EditCommand { get; private set; }
        public DelegateCommand DeleteCommand { get; private set; }

        private IEnumerable<IProducer> Producer { get; set; }
        private IProducer _editableProducer;

        public ProducerListViewModel()
        {
            GetData();
            InitializeCommands();
        }      

        private void GetData()
        {
            string _settingsProperty = UI.Properties.Settings.Default.DAO;
            BLC.BLC blc = new BLC.BLC(_settingsProperty);

            _editableProducer = blc.EmptyProducer();
            this.Producer = blc.GetProducers();

            Producers = new ObservableCollection<IProducer>();
            Producers.AddRange(Producer);

            EditProducer = new ProducerViewModel(blc.EmptyProducer());
        }

        private void InitializeCommands()
        {
            AddCommand = new DelegateCommand(Add, CanAdd);
            DeleteCommand = new DelegateCommand(Delete, CanDelete);
            EditCommand = new DelegateCommand(Edit, CanEdit);
        }

        private IProducer _selectedProducer;
        public IProducer SelectedProducer
        {
            get => _selectedProducer;
            set
            {
                _selectedProducer = value;
                if (_selectedProducer != null)
                {
                    EditProducer.Name = _selectedProducer.Name;
                    EditProducer.OriginsCountry = _selectedProducer.OriginsCountry;
                    EditProducer.ID = _selectedProducer.ID;
                }
                RaisePropertyChanged("SelectedProducer");
            }
        }

        private ProducerViewModel _editProducer;
        public ProducerViewModel EditProducer
        {
            get => _editProducer;
            set
            {
                _editProducer = value;
                RaisePropertyChanged("EditProducer");
            }
        }


        private void Add()
        {
            _editableProducer.ID = Producers.Count() + 1;
            _editableProducer.Name = EditProducer.Name;
            _editableProducer.OriginsCountry = EditProducer.OriginsCountry;

            EditProducer.Validate();

            if(!EditProducer.HasErrors)
                _producers.Add(_editableProducer);
        }

        private bool CanAdd()
        {
            return true;
        }

        private void Delete()
        {
            _producers.Remove(_producers.Where(x => x.ID == EditProducer.ID).Single());
        }

        private bool CanDelete()
        {
            return true;
        }

        private void Edit()
        {
            var editedProducer = _producers.Where(x => x.ID == EditProducer.ID).Single();

            int index = _producers.IndexOf(editedProducer);
            _editableProducer.ID = EditProducer.ID;
            _editableProducer.Name = EditProducer.Name;
            _editableProducer.OriginsCountry = EditProducer.OriginsCountry;

            _producers.Remove(editedProducer);
            _producers.Insert(index, _editableProducer);
        }

        private bool CanEdit()
        {
            return true;
        }
    }
}
