using System.ComponentModel.DataAnnotations;

namespace SchadPrueba.Models
{
    public class Invoice
    {

        public Invoice() { 
        
          Detalles = new List<InvoiceDetail>();
        }

        [Key]
        public int Id { get; set; }
        
        public int CustomersId { get; set; }
        public Customers Customers { get; set; }    

        public decimal TotalItbis { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Total { get; set; }

        public List<InvoiceDetail> Detalles { get; set; }


    }
}
