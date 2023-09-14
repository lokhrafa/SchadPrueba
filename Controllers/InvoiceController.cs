using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchadPrueba.Models;
using SchadPrueba.Models.ViewModel;

namespace SchadPrueba.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly Context _context;

        public InvoiceController(Context context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
          var invoice = await _context.Invoice
            .Include(p => p.Customers)
            .ToListAsync();

            return View(invoice);


        }

        public async Task<ActionResult> Create()
        {
            ViewBag.Customers = await _context.Customers.ToListAsync();
          

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Invoice invoice, int cantidad, decimal precio)
        {
            var cli = await _context.Customers.FirstOrDefaultAsync(m => m.Id == invoice.CustomersId);

            if (cli != null)
                invoice.Customers = cli;

            invoice.Detalles.Add(new InvoiceDetail
            {
               Qty = 1,
               TotalItbis = invoice.TotalItbis,
               SubTotal = invoice.SubTotal,
               Total = invoice.Total
            });


            _context.Invoice.Add(invoice);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




    }
}
