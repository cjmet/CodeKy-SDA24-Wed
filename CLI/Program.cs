using AngelHornetLibrary;
using AngelHornetLibrary.CLI;
using Data;
using static Data.TestProducts;
using static CLI.Logo;

namespace CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AngelHornet.Logo());
            Console.WriteLine("Press Any Key to Continue...");
            Console.ReadKey();

            List<IProduct> _products = GetTestProducts();
            IProduct product;

            var mainMenu = new CliMenu();
            mainMenu.MenuItemWidth = 20;
            mainMenu.AddOnEntry(() =>
            {
                Console.Clear();
                Console.WriteLine(GetLogo10());
                Console.WriteLine("Welcome to our Petshop!");
            });
            mainMenu.AddDefault(mainMenu.GetEntryAction() ?? throw new Exception());
            mainMenu.AddOnExit(() => { Console.WriteLine("Goodbye!"); });
            mainMenu.AddItem("List Products", () =>
            {
                Console.WriteLine("List Products");
                foreach (IProduct p in _products)
                {
                    Console.WriteLine(p.ToString());
                }
            });
            mainMenu.AddItem("Add a Cat Food", () =>
            {
                Console.WriteLine("Add a Cat Food");
                product = new CatFood();
                product.GetFromConsole();
                _products.Add(product);
            });
            mainMenu.AddItem("Add a Dog Food", () =>
            {
                Console.WriteLine("Add a Dog Food");
                product = new DogFood();
                product.GetFromConsole();
                _products.Add(product);
            });
            mainMenu.AddItem("Exit", () => { mainMenu.Exit(); });

            mainMenu.Loop();
        }
    }
}
