using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack // ♣-Club / ♥-Heart / ♠-Spade / ♦-Diamond
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = " ♠ ♥ ♣ ♦ BlackJack Game ";
            PlayBlackJack();
        }

        static void PlayBlackJack()
        {
        Again:
            Console.WriteLine(" Welcome! BlackJack Game ");
            Console.WriteLine("-------------------------");
            Console.Write("ENTER YOUR NAME: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            bool dealAgain = true;

            try
            {
                int computerScore = 0;
                int userScore = 0;

                int cardIndex = 0;
                int currentCard = 0;
                string displayCard;

                var arrCards = new List<KeyValuePair<string, int>>()
                {
                new KeyValuePair<string, int>("A♣", 1),
                new KeyValuePair<string, int>("2♣", 2),
                new KeyValuePair<string, int>("3♣", 3),
                new KeyValuePair<string, int>("4♣", 4),
                new KeyValuePair<string, int>("5♣", 5),
                new KeyValuePair<string, int>("6♣", 6),
                new KeyValuePair<string, int>("7♣", 7),
                new KeyValuePair<string, int>("8♣", 8),
                new KeyValuePair<string, int>("9♣", 9),
                new KeyValuePair<string, int>("10♣",10),
                new KeyValuePair<string, int>("J♣", 10),
                new KeyValuePair<string, int>("Q♣", 10),
                new KeyValuePair<string, int>("K♣", 10),

                new KeyValuePair<string, int>("A♥", 1),
                new KeyValuePair<string, int>("2♥", 2),
                new KeyValuePair<string, int>("3♥", 3),
                new KeyValuePair<string, int>("4♥", 4),
                new KeyValuePair<string, int>("5♥", 5),
                new KeyValuePair<string, int>("6♥", 6),
                new KeyValuePair<string, int>("7♥", 7),
                new KeyValuePair<string, int>("8♥", 8),
                new KeyValuePair<string, int>("9♥", 9),
                new KeyValuePair<string, int>("10♥",10),
                new KeyValuePair<string, int>("J♥", 10),
                new KeyValuePair<string, int>("Q♥", 10),
                new KeyValuePair<string, int>("K♥", 10),

                new KeyValuePair<string, int>("A♠", 1),
                new KeyValuePair<string, int>("2♠", 2),
                new KeyValuePair<string, int>("3♠", 3),
                new KeyValuePair<string, int>("4♠", 4),
                new KeyValuePair<string, int>("5♠", 5),
                new KeyValuePair<string, int>("6♠", 6),
                new KeyValuePair<string, int>("7♠", 7),
                new KeyValuePair<string, int>("8♠", 8),
                new KeyValuePair<string, int>("9♠", 9),
                new KeyValuePair<string, int>("10♠",10),
                new KeyValuePair<string, int>("J♠", 10),
                new KeyValuePair<string, int>("Q♠", 10),
                new KeyValuePair<string, int>("K♠", 10),

                new KeyValuePair<string, int>("A♦", 1),
                new KeyValuePair<string, int>("2♦", 2),
                new KeyValuePair<string, int>("3♦", 3),
                new KeyValuePair<string, int>("4♦", 4),
                new KeyValuePair<string, int>("5♦", 5),
                new KeyValuePair<string, int>("6♦", 6),
                new KeyValuePair<string, int>("7♦", 7),
                new KeyValuePair<string, int>("8♦", 8),
                new KeyValuePair<string, int>("9♦", 9),
                new KeyValuePair<string, int>("10♦",10),
                new KeyValuePair<string, int>("J♦", 10),
                new KeyValuePair<string, int>("Q♦", 10),
                new KeyValuePair<string, int>("K♦", 10),

                };

                Random rndGenerator = new Random();

                {
                Player:
                    if (dealAgain)
                    {
                        cardIndex = rndGenerator.Next(0, 51);
                        currentCard = Convert.ToInt32(arrCards[cardIndex].Value);
                        displayCard = Convert.ToString(arrCards[cardIndex].Key);
                        userScore = userScore + currentCard;
                        Console.WriteLine(name.ToString() + " gets " + displayCard.ToString() + " Card // Total Score: " + userScore.ToString());



                        if (userScore > 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("         " + name + " LOST! :(      ");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine();

                            Console.Write("PLAY AGAIN(Y/N)?");
                            string playAgain = Console.ReadLine();
                            Console.WriteLine();

                            switch (playAgain.ToUpper())
                            {
                                case "Y":
                                    goto Again;
                                case "N":
                                    break;
                            }

                            Console.ReadKey();


                        }
                        if (userScore == 21)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine("   SCORED 21. " + name + " WON! :)  ");
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine();

                            Console.Write("PLAY AGAIN(Y/N)?");
                            string playAgain = Console.ReadLine();
                            Console.WriteLine();

                            switch (playAgain.ToUpper())
                            {
                                case "Y":
                                    goto Again;
                                case "N":
                                    break;
                            }

                            Console.ReadKey();
                        }


                    }
                    Console.Write("MORE A CARD(Y/N)?");
                    string moreCards = Console.ReadLine();
                    Console.WriteLine();

                    switch (moreCards.ToUpper())
                    {
                        case "Y":
                            goto Player;
                        case "N":
                            goto Computer;
                    }

                }

            Computer:
                cardIndex = rndGenerator.Next(0, 51);
                currentCard = Convert.ToInt32(arrCards[cardIndex].Value);
                displayCard = Convert.ToString(arrCards[cardIndex].Key);
                computerScore = computerScore + currentCard;
                Console.WriteLine("Computer gets " + displayCard.ToString() + " Card // Total Score: " + computerScore.ToString());
                Console.WriteLine();

                if (computerScore < 19)
                {
                    goto Computer;
                }

                if (computerScore > 21)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(" COMPUTER LOST. " + name + " WON!!!");
                    Console.WriteLine("------------------------------------");
                }

                if (computerScore == userScore)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("              D R A W               ");
                    Console.WriteLine("------------------------------------");

                }
                if (computerScore < userScore && userScore <= 21)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine(" " + name + " WON!!!! CONGRATULATIONS!!!  ");
                    Console.WriteLine("------------------------------------------");

                }
                if (computerScore > userScore && computerScore <=21)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("         COMPUTER WON !!! :(        ");
                    Console.WriteLine("------------------------------------");
                }

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}