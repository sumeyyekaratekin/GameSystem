using MyGameSystem.Interface;
using MyGameSystem.Managers;
using System;

namespace MyGameSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(new Player() { Tc = "1111111112", YearOfBirth = 1996, Name = "adminName", Surname = "adminSurname" });
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game() { Name = "Game1", Category = "Action", Price = 180 });
            
            while (true)
            {
                Console.WriteLine("\nOptions");
                Console.WriteLine("(PA) : Player Add\t(PD) : Player Delete\t(PL) : Players List\n(GA) Game Add \t(GD) Game Delete\t(GL) Game List\n(CC) Choise Campaign\n(E) : EXİT\n");
                string x = Console.ReadLine();

                if (x == "PA")
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Player Information you want to add...");
                    Console.WriteLine("Tc :");
                    string TcNo = Console.ReadLine();
                    Console.WriteLine("Name: ");
                    string PlayerName = Console.ReadLine();
                    Console.WriteLine("Surname:");
                    string PlayerSurname = Console.ReadLine();
                    Console.WriteLine("Year of Birth");
                    int BirthYear = Convert.ToInt32(Console.ReadLine());

                    
                    ValidateManager validateManager = new ValidateManager();
                   
                    validateManager.Validate(new Person() { Tc = TcNo, Name = PlayerName, Surname = PlayerSurname, YearOfBirth = BirthYear });
                }

                else if (x == "PD")
                {
                    Console.WriteLine("Enter the name of the player you want to delete:");
                    playerManager.Delete(Console.ReadLine());
                }

                else if (x == "PL")
                {
                    Console.Clear();
                    playerManager.ListPlayer();
                }

                else if (x == "GA")
                {
                    Console.WriteLine("Enter the information of the game you want to add");
                    Console.WriteLine("Game Name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Game Category");
                    string Category = Console.ReadLine();
                    Console.WriteLine("Game Price");
                    double Price = Convert.ToDouble(Console.ReadLine());

                    gameManager.Add(new Game() { Name = Name, Category = Category, Price = Price });
                }

                else if (x == "GD")
                {
                    Console.WriteLine("Enter the name of the game you want to delete:");
                    gameManager.Delete(Console.ReadLine());
                }

                else if (x == "GL")
                {
                    Console.Clear();
                    gameManager.ListGame();
                }

                else if (x == "CC")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("CAMPAİGNS \n(1)Welcome Campaign \t(2)New Year Campaign \t(3)Student Compaign \n(4)-Menü");
                        Console.WriteLine("- - - - - - - - - - - -");

                        int choice2 = Convert.ToInt32(Console.ReadLine());

                        if (choice2 == 1)
                        {
                            gameManager.ListGame();
                            Console.WriteLine("Write the name of the game you want to apply 'WELCOME Campaign' from the games above:");
                            string name = Console.ReadLine();
                            ICampaignService campaign = new WelcomeCampaign();
                            gameManager.BuyGame(name, campaign);
                        }

                        else if (choice2 == 2)
                        {
                            gameManager.ListGame();
                            Console.WriteLine("Write the name of the game you want to apply 'NEW YEAR Campaign' from the games above:");
                            string name = Console.ReadLine();
                            ICampaignService campaign = new NewYearCampaign();
                            gameManager.BuyGame(name, campaign);
                        }

                        else if (choice2 == 3)
                        {
                            gameManager.ListGame();
                            Console.WriteLine("Write the name of the game you want to apply 'Student Campaign' from the games above:");
                            string name = Console.ReadLine();
                            ICampaignService campaign = new StudentCampaign();
                            gameManager.BuyGame(name, campaign);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
            }
                
        }
    }
}
