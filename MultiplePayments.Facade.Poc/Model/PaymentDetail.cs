using System;
using System.Collections.Generic;

namespace MultiplePayments.Facade.Poc.Model
{
    public class PaymentDetail
    {
        public Guid IdPaymentDetail { get; set; }
        public DateTime Date { get; set; }
        public string Document { get; set; }
        public string CreditCardNumber { get; set; }
        public decimal TotalPrice { get; set; }

        public List<Order> Orders { get; set; }
    }
}
