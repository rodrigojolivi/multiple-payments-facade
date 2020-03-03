using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Payment.MercadoPago
{
    public interface IPaymentMercadoPago
    {
        void CommitTransaction(PaymentDetail paymentDetail);
    }
}
