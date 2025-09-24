using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFabric
    {
        static private List<Model.Customer> _pregen = new List<Model.Customer>
        {
            new Model.Customer("Kale", "London"),
            new Model.Customer("Jane", "Moskow"),
            new Model.Customer("Jacob", "Astana")
        };

        public static List<Model.Customer> Generate(/*int amount*/)
        {
            /*List<Model.Item> items = new List<Model.Item>();

            for (int i = 0; i < amount; i++)
            {
                items.Add(new Model.Item(...));
            }

            return items;*/
            return _pregen;
        }
    }
}
