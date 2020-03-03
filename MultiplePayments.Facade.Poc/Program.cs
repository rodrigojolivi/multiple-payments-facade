using Microsoft.Extensions.DependencyInjection;
using MultiplePayments.Facade.Poc.Enum;
using MultiplePayments.Facade.Poc.Facade;
using MultiplePayments.Facade.Poc.Model;
using MultiplePayments.Facade.Poc.Payment.EBANX;
using MultiplePayments.Facade.Poc.Payment.MercadoPago;
using MultiplePayments.Facade.Poc.Payment.PagSeguro;
using MultiplePayments.Facade.Poc.Payment.PayPal;
using MultiplePayments.Facade.Poc.Service;
using System;
using System.Collections.Generic;

namespace MultiplePayments.Facade.Poc
{
    class Program
    {
        static void Main()
        {
            var collection = RegisterServices();
            var serviceProvider = collection.BuildServiceProvider();

            var paymentService = serviceProvider.GetService<IPaymentService>();

            var paymentDetail = PaymentDetail();

            paymentService.MakePaymentWithCreditCard(paymentDetail);
        }

        private static ServiceCollection RegisterServices()
        {
            var collection = new ServiceCollection();

            collection.AddScoped<IPaymentService, PaymentService>();
            collection.AddScoped<IPaymentFacade, PaymentFacade>();
            collection.AddScoped<IPaymentPayPal, PaymentPayPal>();
            collection.AddScoped<IPaymentPagSeguro, PaymentPagSeguro>();
            collection.AddScoped<IPaymentMercadoPago, PaymentMercadoPago>();
            collection.AddScoped<IPaymentEBANX, PaymentEBANX>();

            return collection;
        }

        private static PaymentDetail PaymentDetail()
        {
            return new PaymentDetail
            {
                IdPaymentDetail = Guid.NewGuid(),
                CreditCardNumber = "5415215523658598",
                Date = DateTime.Now,
                Document = "98765498",
                TotalPrice = 37.50M,

                Orders = new List<Order>
                {
                    new Order
                    {
                        IdOrder = Guid.NewGuid(),
                        Document = "11155",
                        ProductName = "TShirt L",
                        Quantity = 1,
                        UnitPrice = 25.00M,

                        Customer = new Customer
                        {
                            IdCustomer = new Guid("{C7448AAB-F34D-4BDC-84C6-0164C62DD90F}"),
                            Email = "customer@gmail.com",
                            Name = "John",
                            GatewayPayment = GatewayPayment.EBANX,
                        },
                    },
                    new Order
                    {
                        IdOrder = Guid.NewGuid(),
                        Document = "55144",
                        ProductName = "Short S",
                        Quantity = 1,
                        UnitPrice = 12.50M,

                        Customer = new Customer
                        {
                            IdCustomer = new Guid("{C7448AAB-F34D-4BDC-84C6-0164C62DD90F}"),
                            Email = "customer@gmail.com",
                            Name = "John",
                            GatewayPayment = GatewayPayment.EBANX,
                        },
                    },
                },
            };
        }
    }
}
