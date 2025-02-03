

namespace Data
{
    public interface IProductRepository
    {
        public bool VerboseSQL { get; set; }
        public string DbPathName { get; }
        public void ResetDatabase();

        // Make sure you set the Id property of the product before calling these methods
        // Id=0 for adding, Id>0 for updating
        public IProduct? AddProduct(IProduct product);
        public IProduct? GetProduct(int id);
        public IProduct? UpdateProduct(IProduct product);
        public Boolean DeleteProduct(int Id);
        public List<IProduct> GetAllProducts();
    }

}
