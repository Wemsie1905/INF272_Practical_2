using INF272_Practical_2.Models;
using System;
using System.Collections.Generic;

using System.Web.Mvc;

namespace INF272_Practical_2.Controllers
{
	public class PeopleController
	{

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel { FirstName = "John", LastName = "Doe", Email="john.doe@email.com", Age = 21, IsAlive = true, myLink = "~/HTML/John.html" },
                new PersonModel { FirstName = "Jane", LastName = "Smith", Email="jane.smith@email.com", Age = 22, IsAlive = true, myLink = "~/HTML/Jane.html" },
                new PersonModel { FirstName = "Tom", LastName = "Brown", Email="tom.brown@email.com", Age = 23, IsAlive = true, myLink = "~/HTML/Tom.html" },
                new PersonModel { FirstName = "Alice", LastName = "White", Email="alice.white@email.com", Age = 24, IsAlive = true, myLink = "~/HTML/Alice.html" },
                new PersonModel { FirstName = "Mike", LastName = "Davis", Email="mike.davis@email.com", Age = 25, IsAlive = true, myLink = "~/HTML/Mike.html" }
            };

            return View("ListPeople", people);
        }

       
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private ActionResult View(string v, List<PersonModel> people)
        {
            throw new NotImplementedException();
        }
    }
}