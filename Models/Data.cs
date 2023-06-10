using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //necessary


//You are in the 'M' part of MVC.
//These are your data models.  There can be
//multiple data models in the folder called Models.
//Each class should handle only one data model.

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

        //create an empty array of integers
        //the ? allows us to mark this as nullable.
        //Otherwise, we would have to initialize the 
        //array here.
        public List<int>? number_array { get; set; }
    }

    //I could create other Data Model classes.
    //I could create other classes like Data in
    //the Models folder.

    //A data class for use with an INPUT box
    public class Subscribe
    {
        [Required]
        public string? Email { get; set; }
    }

    
}