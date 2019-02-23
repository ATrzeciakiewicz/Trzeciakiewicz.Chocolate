using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.DAOMock1
{
    public class DB : IDAO
    {
        private List<IChocolate> _chocolates;
        private List<IProducer> _producers;

        public DB()
        {
            _producers = ProducersList();
            _chocolates = ChocolatesList();

        }

        public IEnumerable<IChocolate> GetAllChocolates()
        {
            return _chocolates;
        }

        public IEnumerable<IProducer> GetAllProducers()
        {
            return _producers;
        }


        private List<IChocolate> ChocolatesList()
        {
            List<IChocolate> model = new List<IChocolate>()
            {
                new BO.Chocolate{ ID = 1, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 2, Name = "Chocolate", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 3, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 4, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Yoghurt, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 5, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 1},

                new BO.Chocolate{ ID = 6, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 2},
                new BO.Chocolate{ ID = 7, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 2},
                new BO.Chocolate{ ID = 8, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 2},
                new BO.Chocolate{ ID = 9, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 2},
                new BO.Chocolate{ ID = 10, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 2},

                new BO.Chocolate{ ID = 11, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 12, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 13, Name = "Chocolate", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 14, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 15, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 3},

                new BO.Chocolate{ ID = 16, Name = "Chocolate", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Cherry, Additions = EChocolateAdditions.Without, ProducerID = 4},
                new BO.Chocolate{ ID = 17, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.Without, ProducerID = 4},
                new BO.Chocolate{ ID = 18, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.WholeNut, ProducerID = 4},
                new BO.Chocolate{ ID = 19, Name = "Chocolate", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Cookies, ProducerID = 4},
                new BO.Chocolate{ ID = 20, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Cookies, ProducerID = 4},

                new BO.Chocolate{ ID = 21, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 5},
                new BO.Chocolate{ ID = 22, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 5},
                new BO.Chocolate{ ID = 23, Name = "Chocolate", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 5},
                new BO.Chocolate{ ID = 24, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Toffee, Additions = EChocolateAdditions.Without, ProducerID = 5},
                new BO.Chocolate{ ID = 25, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 5},

                new BO.Chocolate{ ID = 26, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Without, ProducerID = 6},
                new BO.Chocolate{ ID = 27, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 6},
                new BO.Chocolate{ ID = 28, Name = "Chocolate", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 6},
                new BO.Chocolate{ ID = 29, Name = "Chocolate", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Cookies, ProducerID = 6},
                new BO.Chocolate{ ID = 30, Name = "Chocolate", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 6},

                new BO.Chocolate{ ID = 31, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.Without, ProducerID = 7},
                new BO.Chocolate{ ID = 32, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 7},
                new BO.Chocolate{ ID = 33, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 7},
                new BO.Chocolate{ ID = 34, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 7},
                new BO.Chocolate{ ID = 35, Name = "Chocolate", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 7},

                new BO.Chocolate{ ID = 36, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 8},
                new BO.Chocolate{ ID = 37, Name = "Chocolate", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 8},
                new BO.Chocolate{ ID = 38, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 8},
                new BO.Chocolate{ ID = 39, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Cherry, Additions = EChocolateAdditions.Without, ProducerID = 8},
                new BO.Chocolate{ ID = 40, Name = "Chocolate", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 8},
            };

            foreach(var item in model)
            {
                item.Producer = _producers.Where(x => x.ID == item.ProducerID).SingleOrDefault();
            }

            return model;
        }

        private List<IProducer> ProducersList()
        {
            List<IProducer> model = new List<IProducer>()
            {
                new BO.Producer{ ID = 1, Name = "Milka", OriginsCountry = ECountry.Switzerland},
                new BO.Producer{ ID = 2, Name = "Lindt", OriginsCountry = ECountry.Switzerland},
                new BO.Producer{ ID = 3, Name = "Wawel", OriginsCountry = ECountry.Poland},
                new BO.Producer{ ID = 4, Name = "Hershey", OriginsCountry = ECountry.USA},
                new BO.Producer{ ID = 5, Name = "Amadei", OriginsCountry = ECountry.Italy},
                new BO.Producer{ ID = 6, Name = "Morin", OriginsCountry = ECountry.France},
                new BO.Producer{ ID = 7, Name = "Leonidas", OriginsCountry = ECountry.Belgium},
                new BO.Producer{ ID = 8, Name = "Terravita", OriginsCountry = ECountry.Poland}
            };
            return model;
        }
    }
}
