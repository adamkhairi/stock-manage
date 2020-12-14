using System;
using System.Collections;
using System.Collections.Generic;


namespace stock_manage
{
    public class Article
    {
        public int refNum = 0;
        public string articleName;
        public double sellPrice;
        public double buyPrice;

        public Article(int refNum, string articleName, double buyPrice, double sellPrice)
        {
            this.refNum = refNum;
            this.articleName = articleName;
            this.sellPrice = sellPrice;
            this.buyPrice = buyPrice;

            if (buyPrice > sellPrice)
            {
                throw new Exception("Invalid Price");
            }
        }

        public static Article CreateArticle(int refNum)
        {
            Console.WriteLine("Article Title :");
            var title = Console.ReadLine();

            Console.WriteLine("Article Buy Price");
            var sel = Console.ReadLine();
            double sell = Convert.ToDouble(sel);

            Console.WriteLine("Price For Selling This Article");
            var by = Console.ReadLine();
            double buy = Convert.ToDouble(by);


            Article art = new Article(refNum, title, sell, buy);
            

            return art;
        }

        public string getArticleInfo()
        {
            return"Référence number : "+ refNum +". \nArticle Name : "+ articleName +". \nArticle Selling Price : " + sellPrice+ ". \nArticle Buying Price : "+buyPrice+".\n";
        }

        public static void AddToMagasin(Article art, IDictionary<string, Article> magasin)
        {
            magasin.Add(art.articleName, art);
        }

        public static void showArtMag(IDictionary<string, Article> mag)
        {
            foreach (var item in mag)
            {
                //NAME of Articles 
                Console.WriteLine("Key :" +item.Key);
                Console.WriteLine("Value :" + item.Value.getArticleInfo());

                
            }
        }
    }
}