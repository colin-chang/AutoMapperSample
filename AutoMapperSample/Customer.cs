using System.Collections.Generic;

namespace AutoMapperSample
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string TradeNo { get; set; }
        public int TotalFee { get; set; }
    }

    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<OrderDto> OrderDtos { get; set; }
    }

    public class OrderDto
    {
        public int Id { get; set; }
        public string TradeNo { get; set; }
        public int TotalFee { get; set; }
    }
}