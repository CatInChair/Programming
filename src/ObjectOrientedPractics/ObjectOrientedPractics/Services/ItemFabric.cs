using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class ItemFabric
    {
        static private List<Model.Item> _pregen = new List<Model.Item> 
        { 
            new Model.Item("Pen", "This is very good pen", 1.49),
            new Model.Item("Apple", "Ohh, fruits!", 3.99),
            new Model.Item("Shirt", "Light-weight cloth", 799)
        };

        public static List<Model.Item> Generate(/*int amount*/) 
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
