using MultiplePayments.Facade.Poc.Enum;
using MultiplePayments.Facade.Poc.Facade;
using MultiplePayments.Facade.Poc.Model;
using System.Linq;

namespace MultiplePayments.Facade.Poc.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentFacade _paymentFacade;

        public PaymentService(IPaymentFacade paymentFacade)
        {
            _paymentFacade = paymentFacade;
        }

        public void MakePaymentWithCreditCard(PaymentDetail paymentDetail)
        {
            // Fake orchestrates the payment gateway
            var gatewayPayment = paymentDetail.Orders.First().Customer.GatewayPayment;

            switch (gatewayPayment)
            {
                case GatewayPayment.PayPal:
                    _paymentFacade.MakePaymentPayPal(paymentDetail);
                    break;

                case GatewayPayment.PagSeguro:
                    _paymentFacade.MakePaymentPagSeguro(paymentDetail);
                    break;

                case GatewayPayment.MercadoPago:
                    _paymentFacade.MakePaymentMercadoPago(paymentDetail);
                    break;

                case GatewayPayment.EBANX:
                    _paymentFacade.MakePaymentEBANX(paymentDetail);
                    break;
            }
        }
    }
}
