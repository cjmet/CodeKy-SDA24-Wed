
namespace Data
{
    public static class TestProducts
    {
        public static List<IProduct> GetTestProducts()
        {
            List<IProduct> products = new List<IProduct>();
            products.Add(new CatFood() { Name = "Cat Chow", Description = "Standard Cat Food", Price = 10.99m, Quantity = 1, WeightPounds = 5.0, KittenFood = false });
            products.Add(new CatFood() { Name = "Kitten Chow", Description = "Higher Nutrition Kitten Food", Price = 10.99m, Quantity = 2, WeightPounds = 6.0, KittenFood = true });
            products.Add(new DogFood() { Name = "Dog Chow", Description = "Generic Dog Food", Price = 10.99m, Quantity = 3, WeightPounds = 7.0, PuppyFood = false });
            products.Add(new DogFood() { Name = "Puppy Chow", Description = "Special Milk and Bones Formula for Growning Puppies", Price = 10.99m, Quantity = 4, WeightPounds = 8.0, PuppyFood = true });
            products.Add(new DogFood() { Name = "Senior Chow Special Edition Gold", Description = "Special Formula for Older Dogs.  Help your Senior Go and Go and Go, Vroom, Vroom Vroom.  Fast, Agile, Gran Gran Woof Woof!", Price = 999.99m, Quantity = 123, WeightPounds = 1239.0, PuppyFood = false });
            products.Add(new DogFood() { Name = "Price Check", Description = "Price Check", Price = 1234.99m, Quantity = 1234, WeightPounds = 12345.0, PuppyFood = false });
            products.Add(new DogFood() { Name = "Price Check", Description = "Price Check", Price = 99910.99m, Quantity = 1234, WeightPounds = 12345.0, PuppyFood = false });
            products.Add(new DogFood() { Name = "Price Check", Description = "Price Check", Price = 999100.99m, Quantity = 1234, WeightPounds = 12345.0, PuppyFood = false });
            return products;
        }
    }
}
