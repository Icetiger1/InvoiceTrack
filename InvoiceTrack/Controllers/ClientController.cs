using InvoiceTrack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTrack.Controllers
{
    public class ClientController : GenericController<Client>
    {
        public ClientController() : base(_dataSource) { }

    }
}
