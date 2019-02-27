using System.Collections.Generic;

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
