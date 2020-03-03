using System;

namespace MultiplePayments.Facade.Poc.Model
{
    public class Order
    {
        public Guid IdOrder { get; set; }
        public string Document { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public Customer Customer { get; set; }
    }
}
