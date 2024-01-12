using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // Действие для регистрации пользователя
        public ActionResult Register()
        {
            // Логика регистрации пользователя


            return View();
        }

        // Действие для входа в систему
        public ActionResult Login()
        {
            // Логика аутентификации и авторизации пользователя


            return View();
        }
    }
}
