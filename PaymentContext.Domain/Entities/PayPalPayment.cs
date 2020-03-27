using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{     
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string transactionCode,
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
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; set; }
    }
}