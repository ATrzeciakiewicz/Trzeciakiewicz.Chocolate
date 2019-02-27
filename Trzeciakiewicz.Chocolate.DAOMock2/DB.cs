using System.Collections.Generic;
using System.Linq;
using Trzeciakiewicz.Chocolate.Core.Enums;
using Trzeciakiewicz.Chocolate.Interfaces;

namespace Trzeciakiewicz.Chocolate.DAOMock2
{
    public class DB : IDAO
    {
        private List<IChocolate> _chocolates;
        private List<IProducer> _producers;

        public DB()
        {
            _producers = ProducersList();
            _chocolates = ChocolateBarsList();

        }

        public IChocolate EmptyChocolate()
        {
            return new BO.Chocolate();
        }

        public IProducer EmptyProducer()
        {
            return new BO.Producer();
        }

        public IEnumerable<IChocolate> GetAllChocolates()
        {
            return _chocolates;
        }

        public IEnumerable<IProducer> GetAllProducers()
        {
            return _producers;
        }


        private List<IChocolate> ChocolateBarsList()
        {
            List<IChocolate> model = new List<IChocolate>()
            {
                new BO.Chocolate{ ID = 1, Name = "Toblerone", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 2, Name = "Daim", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 3, Name = "Green and Blacks", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 4, Name = "Milka", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Yoghurt, Additions = EChocolateAdditions.Without, ProducerID = 1},
                new BO.Chocolate{ ID = 5, Name = "Toffee Crisp", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 1},

                new BO.Chocolate{ ID = 6, Name = "100 Grand Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 2},
                new BO.Chocolate{ ID = 7, Name = "Aero", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 2},
                new BO.Chocolate{ ID = 8, Name = "Aero Caramel", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 2},
                new BO.Chocolate{ ID = 9, Name = "After Eight", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 2},
                new BO.Chocolate{ ID = 10, Name = "Baby Ruth", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 2},

                new BO.Chocolate{ ID = 11, Name = "Praliny orzechowe", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 12, Name = "Praliny czekoladowe", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 13, Name = "Praliny Karmelowe", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 14, Name = "Praliny truskawkowe", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 3},
                new BO.Chocolate{ ID = 15, Name = "Owoce w czekoladzie", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 3},

                new BO.Chocolate{ ID = 16, Name = "Whatchamacallit", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Cherry, Additions = EChocolateAdditions.Without, ProducerID = 4},
                new BO.Chocolate{ ID = 17, Name = "Zero Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.Without, ProducerID = 4},
                new BO.Chocolate{ ID = 18, Name = "Take 5", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.WholeNut, ProducerID = 4},
                new BO.Chocolate{ ID = 19, Name = "Skor", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Cookies, ProducerID = 4},
                new BO.Chocolate{ ID = 20, Name = "Reese's Sticks", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Cookies, ProducerID = 4},

                new BO.Chocolate{ ID = 21, Name = "Almond Joy", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 5},
                new BO.Chocolate{ ID = 22, Name = "Bournville", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 5},
                new BO.Chocolate{ ID = 23, Name = "Breakaway", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 5},
                new BO.Chocolate{ ID = 24, Name = "Cadbury Fruit & Nut", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Toffee, Additions = EChocolateAdditions.Without, ProducerID = 5},
                new BO.Chocolate{ ID = 25, Name = "Caramilk", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 5},

                new BO.Chocolate{ ID = 26, Name = "Dairy Caramel Milk", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Caramel, Additions = EChocolateAdditions.Without, ProducerID = 6},
                new BO.Chocolate{ ID = 27, Name = "Dairy Strawberry Milk", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 6},
                new BO.Chocolate{ ID = 28, Name = "Milky Raspberry Bar", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 6},
                new BO.Chocolate{ ID = 29, Name = "Milky Bar", Type = EChocolateType.White, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Cookies, ProducerID = 6},
                new BO.Chocolate{ ID = 30, Name = "Mounds", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 6},

                new BO.Chocolate{ ID = 31, Name = "Clark Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Raspberry, Additions = EChocolateAdditions.Without, ProducerID = 7},
                new BO.Chocolate{ ID = 32, Name = "Annette Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Strawberry, Additions = EChocolateAdditions.Without, ProducerID = 7},
                new BO.Chocolate{ ID = 33, Name = "Lucas Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 7},
                new BO.Chocolate{ ID = 34, Name = "Julie Bar", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Raisins, ProducerID = 7},
                new BO.Chocolate{ ID = 35, Name = "Manon bar", Type = EChocolateType.Dessert, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 7},

                new BO.Chocolate{ ID = 36, Name = "Orzechy w czekoladzie", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Hazelnut, ProducerID = 8},
                new BO.Chocolate{ ID = 37, Name = "Mleczne praliny", Type = EChocolateType.Milk, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.Without, ProducerID = 8},
                new BO.Chocolate{ ID = 38, Name = "Owocowe czekoladki", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.CandiedFruitPeels, ProducerID = 8},
                new BO.Chocolate{ ID = 39, Name = "Wiśnie w czekoladzie", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Cherry, Additions = EChocolateAdditions.Without, ProducerID = 8},
                new BO.Chocolate{ ID = 40, Name = "Orzechy & Rodzynki w czekoladzie", Type = EChocolateType.Dark, Stuffed = EChocolateStuffed.Without, Additions = EChocolateAdditions.RaisinNut, ProducerID = 8},
            };

            foreach (var item in model)
            {
                item.Producer = _producers.Where(x => x.ID == item.ProducerID).SingleOrDefault();
            }

            return model;
        }

        private List<IProducer> ProducersList()
        {
            List<IProducer> model = new List<IProducer>()
            {
                new BO.Producer{ ID = 1, Name = "Toblerone", OriginsCountry = ECountry.Switzerland},
                new BO.Producer{ ID = 2, Name = "Nestle", OriginsCountry = ECountry.Switzerland},
                new BO.Producer{ ID = 3, Name = "Łuksza", OriginsCountry = ECountry.Poland},
                new BO.Producer{ ID = 4, Name = "Hershey", OriginsCountry = ECountry.USA},
                new BO.Producer{ ID = 5, Name = "Corte", OriginsCountry = ECountry.Italy},
                new BO.Producer{ ID = 6, Name = "Candy Company", OriginsCountry = ECountry.France},
                new BO.Producer{ ID = 7, Name = "Boyer", OriginsCountry = ECountry.Belgium},
                new BO.Producer{ ID = 8, Name = "Bard", OriginsCountry = ECountry.Poland}
            };
            return model;
        }
    }
}
