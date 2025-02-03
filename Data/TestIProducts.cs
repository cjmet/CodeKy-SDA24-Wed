using System.Diagnostics;

namespace Data
{

    public static class TestIProducts
    {
        public static readonly List<IProduct> Products = new List<IProduct>
        {
            new Product(1, "Primal Pet Foods", "Primal Powerhouse", "Raw-infused kibble packed with real meat, organs, and bones", 0.01m, 9999),
            new Product(2, "Oceanic Nutrition", "Ocean's Bounty", "Holistic dog food with wild-caught salmon, marine algae, and omega-3s", 44.99m, -1),
            new Product(3, "Champion Chow", "Beef & Barley Medley", "Hearty blend with essential nutrients", 29.99m, 20),
            new Product(4, "Paws & Play", "Puppy Powerhouse", "Specially formulated for brain development", 42.99m, 10),
            new Product(5, "Golden Years", "Senior Serenity", "Gentle, easy-to-digest senior dog food", 9999.99m, 0),
            new Product(6, "Lean Machine", "Weight Management Formula", "Low-calorie, high-protein for healthy weight", 34.99m, 18),
            new Product(7, "Hypoallergenic Haven", "Hypoallergenic Venison and Pea", "Grain-free option for sensitive skin", 39.99m, 0),
            new Product(8, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new Product(9, "Nourishing Stew", "Beef and Sweet Potato Stew with Bone Broth", "Moist, flavorful stew for a delicious meal", 36.99m, 12),
            new Product(10, "Superfood Symphony", "Chicken and Vegetable Medley with Superfoods", "Balanced meal with superfoods", 38.99m, 15),
            new Product(11, "Limited Ingredient Duck and Apple", "Limited Ingredient Diet", "Simple, hypoallergenic formula", 42.99m, 0),
            new Product(12, "Bone Broth Elixir", "Beef and Bone Broth Elixir", "Concentrated bone broth supplement", 29.99m, 8),
            new Product(13, "Coconut Cravings", "Grain-Free Salmon and Sweet Potato with Coconut Oil", "Flavorful, grain-free option", 37.99m, -1),
            new Product(14, "Puppy Prime", "Puppy Starter Formula with Colostrum", "Gentle, easily digestible formula", 44.99m, 10),
            new Product(15, "Oatmeal Oasis", "Sensitive Skin Salmon with Oatmeal", "Grain-free formula for sensitive skin", 39.99m, 15),
            new Product(16, "Chia Seed Crunch", "Beef and Oatmeal Medley with Chia Seeds", "Balanced meal with chia seeds", 38.99m, 12),
            new Product(17, "Green Tea Boost", "Weight Management Chicken and Rice with Green Tea Extract", "Low-calorie, high-protein option", 36.99m, 15),
            new Product(18, "Turmeric Tonic", "Senior Beef and Rice with Turmeric", "Gentle, easy-to-digest senior dog food", 34.99m, 12),
            new Product(19, "Pumpkin Patch", "Hypoallergenic Lamb and Rice with Pumpkin", "Grain-free option for sensitive skin", 39.99m, 15),
            new Product(20, "Omega-3 Chews", "Omega-3 Rich Fish Oil Soft Chews", "Convenient way to supplement your dog's diet", 26.99m, 10),
            new Product(21, "Cranberry Craze", "Beef and Vegetable Stew with Quinoa and Cranberries", "Hearty stew with added antioxidants", 39.99m, 12),
            new Product(22, "Leafy Greens Medley", "Chicken and Rice Medley with Kale and Spinach", "Nutrient-dense and fiber-rich option", 38.99m, 15),
            new Product(23, "Rabbit and Sweet Potato", "Limited Ingredient Rabbit and Sweet Potato", "Simple, hypoallergenic formula", 42.99m, 10),
            new Product(24, "Probiotic Power", "Beef and Bone Broth Cubes with Probiotics", "Convenient way to add bone broth and probiotics", 29.99m, 8),
            new Product(25, "Spirulina Superfood", "Grain-Free Salmon and Sweet Potato with Spirulina", "Flavorful, grain-free option with spirulina", 37.99m, 12),
            new Product(26, "Feline Feast", "Ocean-Fresh Salmon Flakes", "High-protein, grain-free for delicious meals", 34.99m, 18),
            new Product(27, "Purrfect Plate", "Chicken & Tuna Medley", "Flavorful blend packed with essential nutrients", 27.99m, 15),
            new Product(28, "Kitten Kaboodle", "Kitten Cravings", "Specially formulated for brain development", 39.99m, 8),
            new Product(29, "Senior Serenity", "Gentle Care", "Gentle, easy-to-digest senior cat food", 32.99m, 12),
            new Product(30, "Indoor Bliss", "Indoor Cat Formula", "Balanced diet specifically designed for indoor cats", 36.99m, 15),
            new Product(31, "Hypoallergenic Haven", "Hypoallergenic Chicken and Rice", "Grain-free option for sensitive skin", 39.99m, 15),
            new Product(32, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new Product(33, "Creamy Delight", "Chicken and Tuna Pate", "Creamy, flavorful pate", 34.99m, 12),
            new Product(34, "Seafood Sensation", "Salmon and Vegetable Medley", "Balanced meal with real salmon", 38.99m, 15),
            new Product(35, "Limited Ingredient Duck and Apple", "Limited Ingredient Diet", "Simple, hypoallergenic formula", 42.99m, 10),
            new Product(36, "Bone Broth Elixir", "Chicken and Tuna Broth", "Nourishing broth supplement", 29.99m, 8),
            new Product(37, "Coconut Cravings", "Grain-Free Salmon and Sweet Potato with Coconut Oil", "Flavorful, grain-free option", 37.99m, 12),
            new Product(38, "Kitten Starter Formula", "Kitten Starter Formula", "Gentle, easily digestible formula", 44.99m, 10),
            new Product(39, "Oatmeal Oasis", "Sensitive Skin Salmon with Oatmeal", "Grain-free formula for sensitive skin", 39.99m, 15),
            new Product(40, "Chia Seed Crunch", "Chicken and Oatmeal Medley with Chia Seeds", "Balanced meal with chia seeds", 38.99m, 12),
            new Product(41, "Green Tea Boost", "Weight Management Chicken and Rice with Green Tea Extract", "Low-calorie, high-protein option", 36.99m, 15),
            new Product(42, "Turmeric Tonic", "Senior Chicken and Rice with Turmeric", "Gentle, easy-to-digest senior cat food", 34.99m, 12),
            new Product(43, "Pumpkin Patch", "Hypoallergenic Lamb and Rice with Pumpkin", "Grain-free option for sensitive skin", 39.99m, 15),
            new Product(44, "Omega-3 Chews", "Omega-3 Rich Fish Oil Soft Chews", "Convenient way to supplement your cat's diet", 26.99m, 10),
            new Product(45, "Cranberry Craze", "Chicken and Vegetable Stew with Quinoa and Cranberries", "Hearty stew with added antioxidants", 39.99m, 12),
            new Product(46, "Leafy Greens Medley", "Turkey and Noodles Medley with Greens and Catnip", "Nutrient-dense and fiber-rich option", 38.99m, 15),
            new Product(47, "Indoor Bliss", "Indoor Cat Formula", "Balanced diet specifically designed for indoor cats", 36.99m, 15),
            new Product(48, "Hypoallergenic Haven", "Hypoallergenic Chicken and Rice", "Grain-free option for sensitive skin", 39.99m, 15),
            new Product(49, "Omega-3 Power Blend", "Omega-3 Rich Fish Oil", "Supplement to enhance skin health", 24.99m, 10),
            new Product(50, "Creamy Delight", "Chicken and Tuna Pate", "Creamy, flavorful pate", 34.99m, 12),
            // Add more products here...
        };

        public static List<IProduct> GetTestProducts()
        {
            Debug.WriteLine("GetTestProducts()");
            return Products;
        }
    }
}
