using System;
using System.Collections.Generic;

namespace uhm
{
    public class classHealingItems
    {
        public static List<classItems> GetList()
        {
            return new List<classItems>
            {
                new classItems
                {
                    ItemName = "Fresh Water",
                    ItemValue = 50,
                },
                new classItems
                {
                    ItemName = "Hyper Potion",
                    ItemValue = 200,
                },
                new classItems
                {
                    ItemName = "Lemonade",
                    ItemValue = 80,
                },
                new classItems
                {
                    ItemName = "Fruit",
                    ItemValue = 10,
                }
                
            };
        }
    }
}