using System.Text.Json;

namespace Data
{
    public class CatFood : Product, IProduct
    {
        public double WeightPounds { get; set; }
        public bool KittenFood { get; set; }

        public override IProduct NewProduct() { return new CatFood(); }
        public override IProduct? NewProduct(string jsonText) // can be null
        {
            if (jsonText == null)
            {
                return null;
            }
            IProduct? newcopy = JsonSerializer.Deserialize<CatFood>(jsonText);
            return newcopy;
        }
        public override void GetFromConsole()
        {
            base.GetFromConsole();
            double weight;
            do
            {
                Console.WriteLine("Enter the weight of the CatFood:");
                weight = double.TryParse(Console.ReadLine()!, out weight) ? weight : -1;
            } while (weight < 0);
            WeightPounds = weight;

            bool kittenFood;
            string input;
            do
            {
                Console.WriteLine("Is this Kitten Food? (y/n)");
                input = Console.ReadLine()!.ToLower();
                input = input.Trim();
                kittenFood = input == "y" || input == "yes";
            } while (input != "y" && input != "yes" && input != "n" && input != "no");
            KittenFood = kittenFood;
        }
        public override string ToString()
        {
            string _displayString = base.ToString();
            string weightString = $"{WeightPounds,5:N2}";
            weightString = StringTruncate(weightString, 5);
            if (WeightPounds > 9999) weightString = "9,999";
            _displayString += $" - Wt: {weightString} - ";
            _displayString += $"Kitten: {KittenFood,5}";

            return _displayString;
        }
        public override string GetJson()
        {
            string jsonString = JsonSerializer.Serialize(this);
            return jsonString;
        }

    }
}
