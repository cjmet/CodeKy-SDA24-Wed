

namespace Mud.Data
{
    public interface IProduct
    {
        public Int32 Id { get; set; }
        public Boolean isSelected { get; set; }

        public String Brand { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public Decimal Price { get; set; }
        public Int32 Quantity { get; set; }
    }

}
