using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Stud.Model;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic; 

// namespace Student.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult postregister(int Id, string Name,string Course,double Fees)
    {   
        List<Student2> stlist= new List<Student2>();
        stlist.Add(new Student2(Id,Name,Course,Fees));
        var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Student2>>(stlist,options);
            string fileName=@"E:\Anshul\Practice\Anshul.json";
            //Serialize all Flowers into json file

            System.IO.File.WriteAllText(fileName,produtsJson);

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }



}
