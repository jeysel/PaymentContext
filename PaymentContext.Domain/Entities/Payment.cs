using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime paidDate, DateTime expireDate, DateTime total, DateTime totalPaid, string payer, Document document, Address address, Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            PaidDate = paidDate;
            ExpireDate = expireDate;
            Total = total;
            TotalPaid = totalPaid;
            Payer = payer;
            Document = document;
            Address = address;
            Email = email;
        }

        public string Number { get; private set; }

        public DateTime PaidDate { get; private set; }

        public DateTime ExpireDate { get; private set; }

        public DateTime Total { get; private set; }

        public DateTime TotalPaid { get; private set; }

        public string Payer { get; private set; }

        public Document Document { get; private set; }

        public Address Address { get; private set; }

        public Email Email { get; private set; }

        
    }

}