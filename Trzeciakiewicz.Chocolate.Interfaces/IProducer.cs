using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trzeciakiewicz.Chocolate.Core.Enums;

namespace Trzeciakiewicz.Chocolate.Interfaces
{
    public interface IProducer
    {
        int ID { get; set; }
        string Name { get; set; }
        ECountry OriginsCountry { get; set; }
    }
}
