using MultiplePayments.Facade.Poc.CustomException;
using MultiplePayments.Facade.Poc.Model;
using MultiplePayments.Facade.Poc.Payment.EBANX;
using MultiplePayments.Facade.Poc.Payment.MercadoPago;
using MultiplePayments.Facade.Poc.Payment.PagSeguro;
using MultiplePayments.Facade.Poc.Payment.PayPal;

namespace MultiplePayments.Facade.Poc.Facade
{
    public class PaymentFacade : IPaymentFacade
    {
        private readonly IPaymentPayPal _paymentPayPal;
        private readonly IPaymentPagSeguro _paymentPagSeguro;
        private readonly IPaymentMercadoPago _paymentMercadoPago;
        private readonly IPaymentEBANX _paymentEBANX;

        public PaymentFacade(
            IPaymentPayPal paymentPayPal,
            IPaymentPagSeguro paymentPagSeguro,
            IPaymentMercadoPago paymentMercadoPago,
            IPaymentEBANX paymentEBANX)
        {
            _paymentPayPal = paymentPayPal;
            _paymentPagSeguro = paymentPagSeguro;
            _paymentMercadoPago = paymentMercadoPago;
            _paymentEBANX = paymentEBANX;
        }

        public void MakePaymentPayPal(PaymentDetail paymentDetail)
        {
            var token = _paymentPayPal.GetToken();

            var payment = _paymentPayPal.MakePayment(paymentDetail, token);

            if (!payment)
            {
                throw new PaymentException("Invalid token");
            }

            _paymentPayPal.CommitTransaction(paymentDetail);
        }

        public void MakePaymentPagSeguro(PaymentDetail paymentDetail)
        {
            // Implements here

            _paymentPagSeguro.CommitTransaction(paymentDetail);
        }

        public void MakePaymentMercadoPago(PaymentDetail paymentDetail)
        {
            // Implements here

            _paymentMercadoPago.CommitTransaction(paymentDetail);
        }

        public void MakePaymentEBANX(PaymentDetail paymentDetail)
        {
            // Implements here

            _paymentEBANX.CommitTransaction(paymentDetail);
        }
    }
}

