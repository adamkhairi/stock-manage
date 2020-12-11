using System;
using System.Collections;
using System.Collections.Generic;


namespace stock_manage
{
  public class Program
    {
        public static void Main(string[] args)
        {
            bool ifExit = true;
            
            while (ifExit)
            {
                try
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("To Add an Article tap :\"add\""); 
                    Console.WriteLine("To Show Articles in Stock tap :\"show\"");
                    Console.WriteLine("To Exit tap : \"exit\" ");
                    Console.WriteLine("------------------------------------------");
                    var  choose = Console.ReadLine();
                    Console.WriteLine("------------------------------------------");
                    switch (choose.ToLower())
                    {
                        case "add":
                            //Article.CreateArticle();
                            Article.AddToMagasin(Article.CreateArticle(), Stock.magasin);
                            break;
                    
                        case  "show":
                            Article.showArtMag(Stock.magasin);
                            Console.WriteLine("-----------------------------------");
                        
                            if (Stock.magasin.Count == 0)
                            {
                                Console.WriteLine("Nothing to Show");
                            }
                            break;
                        case "exit":
                            ifExit = false;
                            break;
                        default:
                            Console.WriteLine("InvalidChoice !!!!");
                            Console.ReadLine();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
                
            }
          
            //Console.WriteLine(magasin1[0].articleName);
            // for (int i = 0;  i <= magasin1.Count ; i++)
            // {
            //     Console.WriteLine(magasin1[i].ArticleName);
            // }
        }
    }
}