using Microsoft.AspNetCore.Mvc;
using AplicacaoMVCLinq.Models;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(10987, "Alice", "alice@example.com", "1234-5678", new DateOnly(2000, 6, 1));
            Cliente c2 = new Cliente(23456, "Rocky", "mayersrakim@example.com", "4321-5687", new DateOnly(1988, 10, 3));
            Cliente c3 = new Cliente(34567, "Drake", "champagnepapi@example.com", "4162-9952", new DateOnly(2000, 6, 1));
            Cliente c4 = new Cliente(45678, "Kendrick", "kdotREAL@example.com", "4162-9952", new DateOnly(2004, 3, 8));
            Cliente c5 = new Cliente(54321, "J.G Quintel", "mordecaiOOH@example.com", "4162-9952", new DateOnly(2010, 7, 28));

            List<Cliente> listaClientes = new List<Cliente>();


            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);

            return View(listaClientes);
        }
    }
}
