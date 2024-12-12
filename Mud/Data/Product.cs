namespace Mud.Data
{
    public class Product : IProduct
    {

        //     new Product(1, "Primal Pet Foods", "Primal Powerhouse", "Raw-infused kibble packed with real meat, organs, and bones", 49.99m, 12),
        public Product(Int32 id = 0, String brand = "", String name = "", String description = "", Decimal price = 0, Int32 quantity = 0)
        {
            Id = id;
            Brand = brand;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Int32 Id { get; set; }
        public Boolean isSelected { get; set; } = false;
        public String Brand { get; set; } = "";
        public String Name { get; set; } = "";
        public String Description { get; set; } = "";
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }
    }
}