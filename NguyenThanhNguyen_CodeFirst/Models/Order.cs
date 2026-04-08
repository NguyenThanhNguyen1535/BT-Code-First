namespace NguyenThanhNguyen_CodeFirst.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
