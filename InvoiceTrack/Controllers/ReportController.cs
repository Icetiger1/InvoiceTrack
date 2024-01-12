using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Действие для создания отчета
        public ActionResult GenerateReport()
        {
            // Логика генерации отчета
            // ...

            return View();
        }
    }
}
