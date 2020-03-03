using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Payment.EBANX
{
    public interface IPaymentEBANX
    {
        void CommitTransaction(PaymentDetail paymentDetail);
    }
}
