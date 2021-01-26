using System;

namespace MyGameSystem
{
    class WelcomeCampaign : ICampaignService
    {
        public void CampaignAdd(Game game)
        {
            Console.WriteLine("This Campaign has been added.");
        }

        public void CampaingDelete(Game game)
        {
            Console.WriteLine("This Campaign has been deleted.");
        }

        public void CampaignSalePrice(Game game)
        {
            Console.WriteLine("The sale price of this game is" + game.Price + "$");
            Console.WriteLine("Discounts were applied for 'WELCOME' campaign.");
            game.Price -= game.Price * (0.1);
            Console.WriteLine("!!!The sale price with a campaign is" + game.Price + " $");
        }
    }

}