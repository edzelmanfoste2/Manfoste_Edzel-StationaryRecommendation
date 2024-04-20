using Models;
using StationaryBusiness;
namespace StationaryRecommendationUI
{
    internal class Program
    {
           public static void Display(StationaryModel model)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Product Name: " + model.productName);
                Console.WriteLine("Product Type: " + model.productType);
                Console.WriteLine("Product Description: " + model.description);
                Console.WriteLine("Product material: " + model.material);
                Console.WriteLine("Product Color: " + model.color);
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Recommended Stationaries!");
                Console.WriteLine("-----------------------");
                Console.WriteLine("~Welcome to Dream Stationary~");
                Console.WriteLine("Please sign-in to check stationary product recommendation. Press enter to proceed.");
                string choice = Console.ReadLine();

                Console.WriteLine("-------SignIn-------");
                Console.WriteLine("Input your Username: ");
                string username = Console.ReadLine();
                UsersLogic usersLogic = new UsersLogic();
                bool result = usersLogic.VerifyUsers(username);

                if (result)
                {
                    Console.WriteLine("`````````````````````````````````````");
                    Console.WriteLine("Welcome! Check on the following recommendations you want.");
                    Choice();
                }
                else
                {
                    Console.WriteLine("Please try again.");
                }
            }

            public static void Choice()
            {
            StationaryLogic products = new StationaryLogic();
            List<StationaryModel> recommendedStationaries = products.RCMP();
            Console.WriteLine("-----------------------------------");
                Console.WriteLine("These are the following choices, " +
                                   "\n a. Recommended Stationaries" +
                                   "\n b. Pens" +
                                   "\n c. Papers" +
                                   "\n d. Search" + "\n");

                Console.WriteLine("Input your choice: ");
                char option = Console.ReadLine()[0];

                switch (option)
                {
                    case 'a':
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("----------->Recommended Stationaries<-----------");
                        Display(recommendedStationaries[0]);
                        Display(recommendedStationaries[1]);
                        Display(recommendedStationaries[2]);
                        Display(recommendedStationaries[3]);
                        Display(recommendedStationaries[4]);
                        Display(recommendedStationaries[5]);
                        Display(recommendedStationaries[6]);
                        answer();
                          
                        break;

                    case 'b':
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("----------->Recommended Pens<-----------");
                        Display(recommendedStationaries[6]);
                        Display(recommendedStationaries[4]);
                        Display(recommendedStationaries[1]);
                        answer();

                    break;

                    case 'c':
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("----------->Recommended Paper<-----------");
                        Display(recommendedStationaries[2]);
                        Display(recommendedStationaries[3]);
                        Display(recommendedStationaries[5]);
                        answer();
                    break;

                    case 'd':
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("---------Search Product by Color-----------");
                    Console.WriteLine("Search a color: ");
                    string color = Console.ReadLine();

                    List<StationaryModel> list = new List<StationaryModel>();
                    bool found = false;
                    foreach (var item in recommendedStationaries)
                    {
                        if (item.color.Contains(color))
                        {
                            found = true;
                            Display(item);

                            Console.WriteLine("Item Color Found, Press enter to continue.");
                            Console.ReadKey(true);
                            Console.Clear();
                        }
                    }
                        {
                        if (!found) { 
                            
                            Console.WriteLine("Item with that color is not found, Press enter to continue.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    answer();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                }

            }
        public static void choice2()
            {
                Choice();
            }

        public static void answer()
        {
            Console.Write("\n Check another product? Yes/No: ");
            string ans = Console.ReadLine();

            if (ans == "Yes" || ans == "yes")
            {
                choice2();
            }
            else if (ans == "No" || ans == "no")
            {
                Console.WriteLine("Thank you!");
            } else
            {
                Console.WriteLine("Please try again---");
                choice2();
            }
        }

    }
    }

