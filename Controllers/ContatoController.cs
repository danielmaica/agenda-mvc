using Microsoft.AspNetCore.Mvc;
using projeto_mvc.Context;
using projeto_mvc.Models;


namespace projeto_mvc.Controllers;

public class ContatoController : Controller
{
    private readonly AgendaContext _context;
    public ContatoController(AgendaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var contatos = _context.Contatos.ToList();
        return View(contatos);
    }

    public IActionResult Criar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Criar(Contato contato)
    {
        if (ModelState.IsValid)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(contato);
    }

    public IActionResult Editar(string id)
    {
        var contato = _context.Contatos.Find(id);
        if (contato == null)
        {
            return NotFound();
        }
        return View(contato);
    }

    [HttpPost]
    public IActionResult Editar(Contato contato)
    {
        if (ModelState.IsValid)
        {
            _context.Contatos.Update(contato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return Index();
    }

    public IActionResult Detalhes(string id)
    {
        var contato = _context.Contatos.Find(id);
        if (contato == null)
        {
            return NotFound();
        }
        return View(contato);
    }

    public IActionResult Excluir(string id)
    {
        var contato = _context.Contatos.Find(id);
        if (contato == null)
        {
            return NotFound();
        }
        return View(contato);
    }

    [HttpPost]
    public IActionResult Excluir(Contato contato)
    {
        if (ModelState.IsValid)
        {
            _context.Contatos.Remove(contato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return Index();
    }
}
