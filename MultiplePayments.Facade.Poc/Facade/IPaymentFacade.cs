using MultiplePayments.Facade.Poc.Model;

namespace MultiplePayments.Facade.Poc.Facade
{
    public interface IPaymentFacade
    {
        void MakePaymentPayPal(PaymentDetail paymentDetail);
        void MakePaymentPagSeguro(PaymentDetail paymentDetail);
        void MakePaymentMercadoPago(PaymentDetail paymentDetail);
        void MakePaymentEBANX(PaymentDetail paymentDetail);
    }
}
