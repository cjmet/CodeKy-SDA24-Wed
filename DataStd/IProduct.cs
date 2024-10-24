namespace Data
{
    public interface IProduct
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        abstract public IProduct? NewProduct();
        abstract public IProduct? NewProduct(string jsonText);
        public void GetFromConsole();
        public string ToString();
        public string GetJson();

    }
}
