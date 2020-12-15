using System;
using System.Collections;
using System.Collections.Generic;

namespace stock_manage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int refNum = 0;
            bool ifExit = true;

            programme(ifExit, refNum);
        }

        static void programme(bool ifExit, int refNum)
        {
            while (ifExit)
            {
                try
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("To Add an Article tap :\"add\"");
                    Console.WriteLine("To Show All Articles in Stock tap :\"show\"");
                    Console.WriteLine("To Search for Article in Stock tap :\"search\"");
                    Console.WriteLine("To Exit tap : \"exit\" ");
                    Console.WriteLine("------------------------------------------");

                    var choose = Console.ReadLine();

                    Console.WriteLine("------------------------------------------");

                    switch (choose.ToLower())
                    {
                        case "add":

                            Article.AddToMagasin(Article.CreateArticle(refNum));
                            refNum++;
                            break;

                        case "show":
                            Article.showArtMag(Stock.magasin);
                            Console.WriteLine("-----------------------------------");

                            if (Stock.magasin.Count == 0)
                            {
                                Console.WriteLine("Nothing to Show");
                                Console.ReadKey();
                                programme(ifExit, refNum);
                            }

                            break;
                        case "search":
                            Console.WriteLine("Article Title...?");
                            string title = Console.ReadLine();
                            Stock.search(title, Stock.magasin);

                            Console.WriteLine("Do wanna Remove it ?(y/n)");
                            var remove = Console.ReadLine();

                            if (remove.ToLower() == "y")
                            {
                                Stock.magasin.Remove(title);
                            }

                            else
                            {
                                programme(ifExit, refNum);
                            }

                            break;

                        case "exit":
                            ifExit = false;
                            break;

                        default:
                            Console.WriteLine("InvalidChoice !!!!");
                            programme(ifExit, refNum);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}