namespace cafe.Models
{
    public class Order
    {
        public int NumberOrder {  get; set; }
        public string OrderContains { get; set; }
        public double TotalAmount {  get; set; }
        public string Status {  get; set; }
    }
}
