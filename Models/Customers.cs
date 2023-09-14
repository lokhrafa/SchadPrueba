using System.ComponentModel.DataAnnotations;

namespace SchadPrueba.Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string CustName { get; set; }
        public string Adress { get; set; }

        public bool Status { get; set; }

        public int CustomerTypesId { get; set; }

        public CustomerTypes CustomerTypes { get; set; }
    }
}
