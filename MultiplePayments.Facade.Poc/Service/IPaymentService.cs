using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Service
{
    public interface IPaymentService
    {
        void MakePaymentWithCreditCard(PaymentDetail paymentDetail);
    }
}
