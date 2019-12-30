using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Customer : IChocoBuyers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public List<ChocolateOrder> ChocoOrders { get; set; }
        public double TotalExpenses
        {
            get
            {
                double returnValue = 0;
                foreach (var order in ChocoOrders)
                {
                    returnValue += order.TotalPrice;
                }
                return returnValue;
            }
        }
        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            ChocoOrders = new List<ChocolateOrder>();
        }
        public Customer(string fName, string lName, ChocolateOrder order)
        {
            FirstName = fName;
            LastName = lName;
            ChocoOrders = new List<ChocolateOrder>();
            ChocoOrders.Add(order);
        }

        public List<Chocolate> CreateOrder(int dark, int white, int milk, int peanut, int almond)
        {
            List<Chocolate> newOrder = new List<Chocolate>();

            //for (int i = 0; i < dark; i++)
            //{
            //    Chocolate newDarkChoco = new Chocolate(Kind.Dark);
            //    newOrder.Add(newDarkChoco);
            //}

            //for (int i = 0; i < white; i++)
            //{
            //    Chocolate newWhiteChoco = new Chocolate(Kind.White);
            //    newOrder.Add(newWhiteChoco);
            //}

            //for (int i = 0; i < milk; i++)
            //{
            //    Chocolate newMilkChoco = new Chocolate(Kind.Milk);
            //    newOrder.Add(newMilkChoco);
            //}

            //for (int i = 0; i < peanut; i++)
            //{
            //    Chocolate newPeanutChoco = new Chocolate(Kind.Peanut);
            //    newOrder.Add(newPeanutChoco);
            //}
            AddChoco(almond, newOrder);
            AddChoco(white, newOrder);
            AddChoco(dark, newOrder);
            AddChoco(milk, newOrder);
            AddChoco(peanut, newOrder);


            return newOrder;

        }

        private static void AddChoco(int kind, List<Chocolate> newOrder)
        {
            for (int i = 0; i < kind; i++)
            {
                Chocolate choco = new Chocolate((Kind)Enum.Parse(typeof(Kind), nameof(kind), true));
                newOrder.Add(choco);
            }
        }
    }
}
