using System.ComponentModel.DataAnnotations;

namespace SchadPrueba.Models
{
    public class InvoiceDetail
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceId { get; set; }

        public Invoice Invoice { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal TotalItbis { get; set; }

        public decimal SubTotal { get; set;}

        public decimal Total { get; set; }

  
    }
}
