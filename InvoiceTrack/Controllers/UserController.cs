using InvoiceTrack.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceTrack.Controllers
{
    public class UserController : GenericController<User>
    {
        public UserController() : base(_dataSource) { }

        // Действие для регистрации пользователя
        public async Task<IActionResult> Register()
        {
            // Логика регистрации пользователя


            return View();
        }

        // Действие для входа в систему
        public async Task<IActionResult> Login()
        {
            // Логика аутентификации и авторизации пользователя


            return View();
        }
    }
}
