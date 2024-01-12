using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Действие для добавления клиента
        public ActionResult AddClient()
        {
            // Логика добавления клиента в базу данных
            // ...

            return View();
        }

        // Действие для редактирования клиента
        public ActionResult EditClient(int clientId)
        {
            // Логика редактирования клиента в базе данных
            // ...

            return View();
        }

        // Действие для удаления клиента
        public ActionResult DeleteClient(int clientId)
        {
            // Логика удаления клиента из базы данных
            // ...

            return View();
        }
    }
}
