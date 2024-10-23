using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Data
{
    public class DogFood : Product, IProduct
    {
        public double WeightPounds { get; set; }
        public bool PuppyFood { get; set; }

        public override IProduct NewProduct() { return new DogFood(); }
        public override IProduct? NewProduct(string jsonText) // can be null
        {
            if (jsonText == null)
            {
                return null;
            }
            IProduct? newcopy = JsonSerializer.Deserialize<DogFood>(jsonText);
            return newcopy;
        }
        public override void GetFromConsole()
        {
            base.GetFromConsole();
            double weight;
            do
            {
                Console.WriteLine("Enter the weight of the DogFood:");
                weight = double.TryParse(Console.ReadLine()!, out weight) ? weight : -1;
            } while (weight < 0);
            WeightPounds = weight;

            bool kittenFood;
            string input;
            do
            {
                Console.WriteLine("Is this Puppy Food? (y/n)");
                input = Console.ReadLine()!.ToLower();
                input = input.Trim();
                kittenFood = input == "y" || input == "yes";
            } while (input != "y" && input != "yes" && input != "n" && input != "no");
            PuppyFood = kittenFood;
        }
        public override string ToString()
        {
            string _displayString = base.ToString();
            string weightString = $"{WeightPounds,5:N2}";
            weightString = StringTruncate(weightString, 5);
            if (WeightPounds > 9999) weightString = "#####";
            _displayString += $" - Wt: {weightString} - ";
            _displayString += $" Puppy: {PuppyFood,5}";

            return _displayString;
        }
        public override string GetJson()
        {
            string jsonString = JsonSerializer.Serialize(this);
            return jsonString;
        }

    }
}
