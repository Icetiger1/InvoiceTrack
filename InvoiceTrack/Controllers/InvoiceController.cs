using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Действие для создания счета-фактуры
        public ActionResult CreateInvoice()
        {
            // Логика создания счета-фактуры
            // ...

            return View();
        }

        // Действие для отправки счета-фактуры
        public ActionResult SendInvoice(int invoiceId)
        {
            // Логика отправки счета-фактуры клиенту
            // ...

            return View();
        }

        // Действие для отметки оплаченного счета-фактуры
        public ActionResult MarkPaid(int invoiceId)
        {
            // Логика отметки счета-фактуры как оплаченного
            // ...

            return View();
        }
    }
}
