using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(
            string barcod, 
            string boletoNumber, 
            DateTime paidDate, 
            DateTime expireDate, 
            DateTime total, 
            DateTime totalPaid, 
            string payer, 
            Document document, 
            Address address, 
            Email email) : base(
                paidDate, 
                expireDate, 
                total, 
                totalPaid, 
                payer, 
                document, 
                address, 
                email)
        {
            Barcod = barcod;
            BoletoNumber = boletoNumber;
        }

        public string Barcod { get; private set; }

        public string BoletoNumber { get; private set; }



    }

   
}