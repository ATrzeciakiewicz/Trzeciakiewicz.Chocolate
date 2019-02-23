using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.BLC
{
    public class BLC
    {
        private readonly string _settingsProperty;
        private IDAO _dao;

        public BLC(string settingsProperty)
        {
            _settingsProperty = settingsProperty;
            CreateMockInstance();
        }

        public IEnumerable<IChocolate> GetChocolates()
        {
            if (_dao == null)
                return new List<IChocolate>();
            return _dao.GetAllChocolates();
        }

        public IEnumerable<IProducer> GetProducers()
        {
            if (_dao == null)
                return new List<IProducer>();
            return _dao.GetAllProducers();
        }

        private void CreateMockInstance()
        {
            string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

            string loadDirectly = $"{path}\\Trzeciakiewicz.Chocolate.{_settingsProperty}\\bin\\Debug\\Trzeciakiewicz.Chocolate.{_settingsProperty}.dll";

            string xcopy = $"Trzeciakiewicz.Chocolate.{_settingsProperty}.dll";

            string assemblyType = $"Trzeciakiewicz.Chocolate.{_settingsProperty}.DB";

            if (File.Exists(xcopy))
            {
                Assembly assembly = Assembly.LoadFrom(xcopy);
                Type type = assembly.GetType(assemblyType);

                _dao = (IDAO)Activator.CreateInstance(type);
            }
            else if (File.Exists(loadDirectly))
            {
                Assembly assembly = Assembly.LoadFrom(loadDirectly);
                Type type = assembly.GetType(assemblyType);

                _dao = (IDAO)Activator.CreateInstance(type);
            }
        }
    }
}
