using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.DAOMock1.BO
{
    public class Producer : IProducer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ECountry OriginsCountry { get; set; }

        public override string ToString()
        {
            return $"Producer name: {Name}, origins country: {OriginsCountry}";
        }
    }
}
