using System;
using System.Collections;
using System.Collections.Generic;

namespace stock_manage
{
    public class  Stock
    {
        public static IDictionary<string, Article> magasin = new Dictionary<string, Article>();

        public static void search(string title ,IDictionary<string, Article> magasin)
        {
            foreach (var item in magasin)
            {
                string itemTitle = item.Key.ToLower();
                string inputTitle = title.ToLower();
                if (itemTitle == inputTitle)
                {
                    Console.WriteLine(item.Value.getArticleInfo());

                }
            }
        }

        // public void AddToStock(Object obj)
        // {
        //     magasin.Add(obj);
        // }
    }
}