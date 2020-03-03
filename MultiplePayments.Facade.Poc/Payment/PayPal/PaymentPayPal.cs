using MultiplePayments.Facade.Poc.Model;
using System;

namespace MultiplePayments.Facade.Poc.Payment.PayPal
{
    public class PaymentPayPal : IPaymentPayPal
    {
        public void CommitTransaction(PaymentDetail paymentDetail)
        {
            // TODO: Implements commit
        }

        public string GetToken()
        {
            return Guid.NewGuid().ToString();
        }

        public bool MakePayment(PaymentDetail paymentDetail, string token)
        {
            // TODO: Implements 

            return true;
        }
    }
}
