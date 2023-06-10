using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using mvcmin.Models; //included so I can use
                     //the variables in Models

namespace mvcmin.Controllers;

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
        //ViewData is a dictionary of all the 
        //DOM(?) variables
        //Words like Title, Message, NumTimes
        //are picked by programmer, not system.
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public IActionResult AddUp()
    {
        //I am doing it this way to be
        //patently obvious that myvar is of
        //type Variables class.
        Variables myvar = new Variables();

        //Set the num1 property field to a value
        myvar.num1 = 6;

        //I can set a ViewData value and use
        //num1 in my view this way
        ViewData["number1"] = myvar.num1;

        //Or, I can pass the myvar object as
        //a whole and use it this way.
        return View(myvar);
    }

}