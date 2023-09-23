using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Japhet Ruiz", StudentId = "201991", StudentAge = "20", Address = "Quezon" },
            new StudentInfoModel { Name = "Victor Magtanggol", StudentId = "265478", StudentAge = "22", Address = "Manila" },
            new StudentInfoModel { Name = "Ivone Adarna", StudentId = "201456", StudentAge = "31", Address = "Pasig" },
            new StudentInfoModel { Name = "Camus Taang", StudentId = "199120", StudentAge = "26", Address = "Cainta" }
        };

        return View(studentInfoArray);
    }
}
