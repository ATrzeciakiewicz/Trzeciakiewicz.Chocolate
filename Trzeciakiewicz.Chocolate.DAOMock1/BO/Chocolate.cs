﻿using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.DAOMock1.BO
{
    public class Chocolate : IChocolate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public EChocolateType Type { get; set; }
        public EChocolateStuffed Stuffed { get; set; }
        public EChocolateAdditions Additions { get; set; }
        public int ProducerID { get; set; }
        public IProducer Producer { get; set; }
    }
}
