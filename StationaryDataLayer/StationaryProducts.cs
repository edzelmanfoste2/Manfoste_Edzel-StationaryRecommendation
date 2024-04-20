using Models;
namespace StationaryDataLayer
{
    public class StationaryProducts
    {
        public StationaryProducts()
        {
            productItemRecommendations();
        }

        List<StationaryModel> Item = new List<StationaryModel>();

        public void productItemRecommendations()
        {
            StationaryModel Item1 = new StationaryModel();
            Item1.productName = "Potato Pug";
            Item1.productType = "Keychain";
            Item1.material = "3 Ply Monaco Yarn";
            Item1.description = "Crochet keychain";
            Item1.color = "Brown";

            StationaryModel Item2 = new StationaryModel()
            {
                productName = "Hello Kitty BallPoint Pen",
                productType = "Black Point Pen",
                material = "Pen",
                description = "It is a 5 point milimeter pen that is smudge free!",
                color = "Pink"
            };

            StationaryModel Item3 = new StationaryModel()
            {
                productName = "Oil Paint Sunshine Memo Pad",
                productType = "Memo Pad",
                material = "Paper",
                description = "Go ahead and look through it, perfect for both reminders and for journaling!",
                color = "Orange"
            };

            StationaryModel Item4 = new StationaryModel()
            {
                productName = "A5 Simplistic Muji Notebook",
                productType = "Notebook",
                material = "Paper",
                description = "For both reminders and for journaling!",
                color = "Red"
            };

            StationaryModel Item5 = new StationaryModel()
            {
                productName = "Blue Sanrio Cinnamon Pen",
                productType = "Black Point Pen",
                material = "Pen",
                description = "Go ahead and look through it, perfect for both reminders and for journaling!",
                color = "Blue"
            };

            StationaryModel Item6 = new StationaryModel()
            {
                productName = "Coffee Sticky Notes",
                productType = "Sticky Notes",
                material = "Paper",
                description = "A coffee like sticky notes for daily reminders.",
                color = "Brown"
            };

            StationaryModel Item7 = new StationaryModel()
            {
                productName = "Fabercastle 0.5 Black Ballpen",
                productType = "Black Point Pen",
                material = "Pen",
                description = "Thin and smudge proof pen.",
                color = "Black"
            };

            Item.Add(Item1);
            Item.Add(Item2);
            Item.Add(Item3);
            Item.Add(Item4);
            Item.Add(Item5);
            Item.Add(Item6);
            Item.Add(Item7);

            Item = RCMP();
        }

        public List<StationaryModel> RCMP()
        {
            return Item;
        }
    }
    }

