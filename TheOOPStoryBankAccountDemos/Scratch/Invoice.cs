using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    class Invoice
    {
        const decimal VATRATE = 20;

        //Constructor
        //public Invoice(
        //    string invoiceNumber, 
        //    DateTime invoiceDate, 
        //    decimal grossAmount, 
        //    string customerName, 
        //    string description, 
        //    DateTime paymentDueDate)
        //{
        //    this.InvoiceNumber = invoiceNumber;
        //    this.InvoiceDate = invoiceDate;
        //    //InvoiceDate = DateTime.Today; //Set invoice date to default value
        //    this.GrossAmount = grossAmount;
        //    this.CustomerName = customerName;
        //    this.Description = description;
        //    this.PaymentDueDate = paymentDueDate;
        //    //PaymentDueDate = InvoiceDate.AddDays(28); //Set payment due date to 28 days from  invoice date
        //}

        ////Using constructor where the Date fields are optional:
        //public Invoice(
        //    string invoiceNumber, 
        //    DateTime invoiceDate = DateTime.Today, 
        //    decimal grossAmount, 
        //    string customerName, 
        //    string description, 
        //    DateTime paymentDueDate = InvoiceDate.AddDays(28))
        //{
        //    this.InvoiceNumber = invoiceNumber;
        //    this.InvoiceDate = invoiceDate;
        //    this.GrossAmount = grossAmount;
        //    this.CustomerName = customerName;
        //    this.Description = description;
        //    this.PaymentDueDate = paymentDueDate;
        //}

        //Using constructor where the Date fields are defaulted to a constant:
        public Invoice(
            string invoiceNumber,
            decimal grossAmount,
            string customerName,
            string description,
            DateTime invoiceDate = default(DateTime),
            DateTime paymentDueDate = default(DateTime))
        { 
            InvoiceNumber = invoiceNumber;
            if (invoiceDate != default(DateTime))
                InvoiceDate = invoiceDate;
            GrossAmount = grossAmount;
            CustomerName = customerName;
            Description = description;
            if (paymentDueDate != default(DateTime))
                PaymentDueDate = paymentDueDate;

        }

        //Properties
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.Today;
        public decimal NetAmount {
            get {
                return GrossAmount * (1 - (VATRATE / 100));
            }
        }
        public decimal VATAmount {
            get {
                return GrossAmount * (VATRATE / 100);
            }
        }
        public decimal GrossAmount { get; set; }
        public string CustomerName { get; set; }
        public string Description { get; set; }
        public DateTime PaymentDueDate { get; set; } = DateTime.Today.AddDays(28);
    }
}
