using InvoiceTrack.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class InvoiceController : GenericController<Invoice>
    {
        public InvoiceController() : base(_dataSource) { }


        // Действие для создания счета-фактуры
        public async Task<IActionResult> CreateInvoice()
        {
            // Логика создания счета-фактуры
            // ...

            return View();
        }

        // Действие для отправки счета-фактуры
        public async Task<IActionResult> SendInvoice(int invoiceId)
        {
            // Логика отправки счета-фактуры клиенту
            // ...

            return View();
        }

        // Действие для отметки оплаченного счета-фактуры
        public async Task<IActionResult> MarkPaid(int invoiceId)
        {
            // Логика отметки счета-фактуры как оплаченного
            // ...

            return View();
        }
    }
}
