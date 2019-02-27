using Trzeciakiewicz.Chocolate.Core.Enums;

namespace Trzeciakiewicz.Chocolate.Interfaces
{
    public interface IChocolate
    {
        int ID { get; set; }
        string Name { get; set; }
        EChocolateType Type { get; set; }
        EChocolateStuffed Stuffed { get; set; }
        EChocolateAdditions Additions { get; set; }
        int ProducerID { get; set; }
        IProducer Producer { get; set; }
    }
}
