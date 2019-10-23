using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Environment
{
    class Fractional_Knapsack
    {
        static public void Run()
        {
            FracKnap c1 = new FracKnap { };
            Item i1 = new Item(240, 10);
            Item i2 = new Item(100, 20);
            Item i3 = new Item(80, 15);
            Item i4 = new Item(150, 5);
            List<Item> items = new List<Item> { };
            items.Add(i1);
            items.Add(i2);
            items.Add(i3);
            items.Add(i4);
            Console.WriteLine(c1.MaxValue(items, 60));
        }
    }
    class FracKnap
    {
        public double MaxValue(List<Item> items, double wMax)
        {
            double maxValue = 0;
            items.Sort();
            int i = 0;
            while (wMax > 0 && i < items.Count)
            {
                if (i < items.Count && wMax >= items[i].Weight)
                {
                    maxValue += items[i].Value;
                    wMax -= items[i].Weight;
                    i++;
                }
                else if (i < items.Count)
                {
                    maxValue += items[i].Value * (wMax / items[i].Weight);
                    wMax = 0;
                }
            }
            return maxValue;
        }
    }
    class Item : IComparable<Item>
    {
        public double RelativeValue { get => (this.Value / this.Weight); }
        public double Value { get; set; }
        public double Weight { get; set; }
        public Item(double value, double weight)
        {
            Value = value;
            Weight = weight;
        }
        public int CompareTo(Item other)
        {
            double theReturn = this.RelativeValue - other.RelativeValue;
            if (theReturn == 0)
            {
                return 0;
            }
            else if (theReturn < 0)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
