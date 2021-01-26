using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameSystem
{
    class NewYearCampaign : ICampaignService
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
            Console.WriteLine("Discounts were applied for 'NEW YEAR' campaign.");
            game.Price -= game.Price * (0.25);
            Console.WriteLine("!!!The sale price with a campaign is" + game.Price + " $");
        }
    }

}