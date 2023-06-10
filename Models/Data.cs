using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //necessary

namespace mvcmin.Models
{
    //What I am showing here is the use of 
    //public class properties to hold variables
    //for use in the MVC app.
    //NOTE: Connections to databases are NOT, 
    //I repeat, NOT required for MVC apps to work.
    //But, app data does have rules to follow for
    //data safety.  This is one.

    //Create a class to hold properties (variables).
    public class Variables
    {
        //Create a public property(variable)
        //and assign it an auto-generated
        //getter and setter.
        //The next step occurs in the Controller
        public int num1 { get; set;}
    }

    
}