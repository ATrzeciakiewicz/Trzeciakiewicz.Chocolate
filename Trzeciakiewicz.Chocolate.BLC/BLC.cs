using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.BLC
{
    public class BLC
    {
        private string _settingsProperty;
        private IDAO _dao = null;

        public BLC(string settingsProperty)
        {
            _settingsProperty = settingsProperty;
            CreateMockInstance();
        }

        public IEnumerable<IChocolate> GetChocolates()
        {
            return _dao.GetAllChocolates();
        }

        public IEnumerable<IProducer> GetProducers()
        {
            return _dao.GetAllProducers();
        }

        private void CreateMockInstance()
        {
            Assembly assembly = Assembly.LoadFrom($"AgnieszkaTrzeciakiewicz.Chocolate.{_settingsProperty}.dll");
            Type type = assembly.GetType($"AgnieszkaTrzeciakiewicz.Chocolate.{_settingsProperty}.DB");

            _dao = (IDAO)Activator.CreateInstance(type);
        }
    }
}
