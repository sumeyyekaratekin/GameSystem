using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem
{
    class GameManager
    {
        List<Game> games = new List<Game>() { };

        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("\nThe game named "+game.Name+" has been added to the "+game.Category +" category.");
        }

        public void Delete(string Name)
        {
            foreach (var game in games)
            {
                if (game.Name == Name)
                {
                    games.Remove(game);
                    Console.WriteLine("\nThe game named '" + game.Name + "' has been deleted");
                    break;
                }

                else
                {
                    continue;
                }
            }

        }

        public void Update(Game game)
        {
            Console.WriteLine("Information is Updated");
        }

        public void ListGame()
        {
            int i = 1;
            Console.WriteLine("GAMES");
            foreach (var game in games)
            {
                Console.WriteLine("\n Game Name :  "+game.Name+ "\n Game Category : "+ game.Category+"\n Game Price : "+ game.Price+"$");
                Console.WriteLine(" - - - - - - - - - - - -");
                i += 1;
            }
        }

        public void BuyGame(string Name, ICampaignService campaign)
        {
            foreach (var game in games)
            {
                if (game.Name == Name)
                {             
                    campaign.CampaignSalePrice(game);
                    
                }

                else
                {
                    continue;
                }
            }
        }

    }
}
