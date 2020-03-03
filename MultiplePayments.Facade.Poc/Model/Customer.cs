using MultiplePayments.Facade.Poc.Enum;
using System;

namespace MultiplePayments.Facade.Poc.Model
{
    public class Customer
    {
        public Guid IdCustomer { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public GatewayPayment GatewayPayment { get; set; }
    }
}
