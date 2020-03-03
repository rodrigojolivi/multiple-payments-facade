using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Payment.PagSeguro
{
    public interface IPaymentPagSeguro
    {
        void CommitTransaction(PaymentDetail paymentDetail);
    }
}
