using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;  //sometimes needed
using mvcmin.Models; //included so I can use
                     //the variables in Models

namespace mvcmin.Controllers;

//This style of programming is called MVC.
//Model-View-Controller
//It works well in web app situations (and others).
//You are in the 'C' part of MVC, a controller.
//The controller becomes part of the web site URL.
//In this case, the URL wil be:
// http://www.mywebsitename.com/home
//The 'home' on the end is the name of the controller.


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
   //in a folder called Views.
   //All controller methods must be public
   //to be useable in the web app.
   //To use the View() process, all
   //controller methods must be of type:
   //IActionResult.
   //Other return types can be used as well,
   //but they can't really call a View() method.
   //Other return types must return their own data
   //for display.
    public IActionResult Index()
    {
        //Index is a special controller method.
        //It allows us to use the URL of:
        //http://www.mywebsitename.com/
        //without needing the /home/ controller
        //name added, at least at first.

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
        //type Variables class. I could just
        //use var myvar instead.
        Variables myvar = new Variables();

        //Set the num1 property field to a value
        myvar.num1 = 6;

        //I can set a ViewData value and use
        //num1 in my view this way
        ViewData["number1"] = myvar.num1;

        //Or, I can pass the myvar object as
        //a whole and use it this way.
        //See the AddUp view for continuation.
        //return View(myvar);

        //So, we have been using the simple
        //return View(myvar)
        //But, you can use a conditional expression
        //to deal with errors
        //Change the 6 below to any other
        //number to see the resultant error
        return myvar.num1 == 6 ? View(myvar) : Problem("Value isn't 6.");
    }

    public IActionResult ArrayList()
    {
        var mylist = new Variables();

        //Easy way to fill an array
        mylist.number_array = Enumerable.Range(1, 10).ToList();

        return View(mylist);
    }

}