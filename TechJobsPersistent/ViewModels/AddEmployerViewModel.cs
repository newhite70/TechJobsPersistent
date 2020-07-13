using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }

        //public Employer ToEmployer() => new Employer(Name, Location);

        //public Job Job { get; set; }

        //public List<SelectListItem> Employers { get; set; }


        /*
        public AddEmployerViewModel(Job theJob, List<Employer> possibleEmployers)
        {
            Employers = new List<SelectListItem>();

            foreach (var Employer in possibleEmployers)
            {
                Employers.Add(new SelectListItem
                {
                    Value = Employer.Id.ToString(),
                    Text = Employer.Name
                });
            }

            //Job = theJob;
        }
       

        public AddEmployerViewModel()
        {
        }
        */
    }
}
