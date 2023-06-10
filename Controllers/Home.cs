using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace addup.Controllers;

//File name of controller and name
//of class must match
//Folder name for view methods
//of this controller in View folder
//must also match

public class Home : Controller
{
   
   //This method name must match its own
   //View file name, and must be in a folder
   //that matches the controller name,
   //in a folder called Views
    public IActionResult Index()
    {
        return View();
    }

    //The parameter variables are filled on the 
    //URL line with the following:
    //sitename.com/home/welcome?name=john&numtimes=4
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}