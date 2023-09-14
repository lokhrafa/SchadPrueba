using Microsoft.EntityFrameworkCore;
using SchadPrueba.Models;

public  class Context: DbContext
{

    public Context(DbContextOptions<Context> option) : base(option)
    {

    }

    public DbSet<Customers> Customers { get; set; }

    public DbSet<CustomerTypes> CustomerTypes { get; set; }

    public DbSet<Invoice> Invoice { get; set; }

    public DbSet<InvoiceDetail> InvoiceDetail { get; set; }


 



}