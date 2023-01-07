using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Stud.Model;
namespace SManager.Model;

// namespace Student.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Register(){
        //fetch data from Model
        //send list of products to ViewData Collection
        
        List<Student2>  allProducts=StudentManager.GetAllStudent();
        ViewData["catalog"]=allProducts;
       
        return View();
    }


     public IActionResult Rpostregiste(){
        //fetch data from Model
        //send list of products to ViewData Collection
        Console.WriteLine("Post User credentials.... ");
        List<Student2>  allProducts=StudentManager.GetAllStudent();
        ViewData["catalog"]=allProducts;
        return View();
    }

}