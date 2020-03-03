using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Payment.PayPal
{
    public interface IPaymentPayPal
    {
        string GetToken();
        bool MakePayment(PaymentDetail paymentDetail, string token);
        void CommitTransaction(PaymentDetail paymentDetail);
    }
}
