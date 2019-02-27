using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trzeciakiewicz.Chocolate.Interfaces
{
    public interface IDAO
    {
        IEnumerable<IProducer> GetAllProducers();
        IEnumerable<IChocolate> GetAllChocolates();
        IProducer EmptyProducer();
        IChocolate EmptyChocolate();
    }
}
