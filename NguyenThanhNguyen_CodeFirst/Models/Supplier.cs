namespace NguyenThanhNguyen_CodeFirst.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
