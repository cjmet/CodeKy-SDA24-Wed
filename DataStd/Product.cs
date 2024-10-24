
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace Data

{
    abstract public class Product : IProduct
    {
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
        public string Description { get; set; } = "";
        public int Quantity { get; set; }


        abstract public IProduct NewProduct();
        abstract public IProduct? NewProduct(String jsonText);

        virtual public void GetFromConsole()
        {
            string name;
            do
            {
                Console.WriteLine("Enter the name of the Product:");
                name = Console.ReadLine()!;
            } while (name.Trim() == "");
            Name = name;

            string desc;
            do
            {
                Console.WriteLine("Enter the description of the Product");
                desc = Console.ReadLine()!;
            } while (desc.Trim() == "");
            Description = desc;

            decimal price;
            do
            {
                Console.WriteLine("Enter the price of the Product");
                price = decimal.TryParse(Console.ReadLine()!, out price) ? price : -1;
            } while (price < 0);
            Price = price;

            int quantity;
            do
            {
                Console.WriteLine("Enter the quantity of the Product");
                quantity = int.TryParse(Console.ReadLine()!, out quantity) ? quantity : -1;
            } while (quantity < 0);
            Quantity = quantity;
        }
        override public string ToString()
        {
            string _displayString = "";

            _displayString += $"{StringTruncate(Name,20),-20} - ";
            _displayString += $"{StringTruncate(Description, 40),-40} - ";
            string priceString = $"{Price,7:C}";
            if (Price >= 1000) priceString = $"{Price,7:C0}";
            if (Price >= 100000) priceString = "$$$,$$$";
            _displayString += $"{priceString} - ";
            string quantityString = $"{Quantity,2}";
            if (Quantity > 99) quantityString = "##";
            _displayString += $"Qty: {quantityString} - ";
            return _displayString;
        }
        virtual public string GetJson()
        {
            string jsonString = JsonSerializer.Serialize(this);
            return jsonString;
        }

        protected string StringTruncate(string s, int index)
        {
            if (s.Length > index)
            {
                return s.Remove(index);
            }
            else
            {
                return s;
            }
        }


    }
}
