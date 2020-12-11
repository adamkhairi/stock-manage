using System;
using System.Collections;

namespace stock_manage
{
    
    public class Article
    {
        public static int refNum;
        public string articleName;
        public double sellPrice;
        public double buyPrice;
        
          

        public Article(int refNum, string articleName, double buyPrice, double sellPrice)
        {
            Article.refNum = 0;
            this.articleName = articleName;
            this.sellPrice = sellPrice;
            this.buyPrice = buyPrice;
            
            if (buyPrice > sellPrice)
            {
                throw new Exception("Invalid Price");
            }
        }
        public static Article CreateArticle()
        {
            Console.WriteLine("Article Title :");
            var  title = Console.ReadLine();
            
            Console.WriteLine("Article Buy Price");
            var  sel = Console.ReadLine();
            double sell = Convert.ToDouble(sel);
            
            Console.WriteLine("Price For Selling This Article"); 
            var  by = Console.ReadLine();
            double buy = Convert.ToDouble(by);
            
            //refNum = 0;

            Article art = new Article(refNum, title, sell, buy);
            art.buyPrice = 0;
            //refNum++;

            return art;
        }
        public void getArticleInfo()
        {
            Console.WriteLine($"Référence number : {refNum}. \nArticle Name : {articleName}. \nArticle Selling Price : {sellPrice}. \nArticle Buying Price :{buyPrice}.\n");
            
        }
        public static void AddToMagasin(Article art, ArrayList magasin)
        {
            refNum++;
            magasin.Add(art);
        }

        public static void showArtMag(ArrayList arr)
        {
            foreach (Article item in arr)
            {
                item.getArticleInfo();
            }
        }

        
    }
}