using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VanjaPet.Models;

namespace VanjaPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {   
        //instancias do tipo Cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira","861.025.750-91","arthur@sp.senai.br","Madruga");
        Cliente cliente2 = new Cliente(02, "William B. Ferreir","420.264.460-32","william@sp.senai.br","Bug");
        Cliente cliente3 = new Cliente(03, "Ada C. Ferrei","965.227.880-71","ada@sp.senai.br","Byron");
        Cliente cliente4 = new Cliente(04, "Linus D. Ferre","560.987.390-80","linus@sp.senai.br","Pinguin");
        Cliente cliente5 = new Cliente(05, "Grace E. Ferr","825.821.540-08","grace@sp.senai.br","Loboc");

        //Lista de clientes e atribui clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        //instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "Java F.","28.022.295/0001-16","Java@sp.senai.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "C# G.","24.711.433/0001-13","C#@sp.senai.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Dio H.","73.319.418/0001-30","Dio@sp.senai.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Alura I.","40.609.213/0001-30","Alura@sp.senai.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Udemy J.","63.657.495/0001-46","Udemy@sp.senai.br");

        //Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
