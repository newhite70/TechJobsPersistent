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
        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public int LocationId { get; set; }

        public Job Job { get; set; }

        public List<SelectListItem> Employers { get; set; }



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

            Job = theJob;
        }

        public AddJobSkillViewModel()
        {
        }

    }
}



public class AddJobSkillViewModel
{
    [Required(ErrorMessage = "Job is required")]
    public int JobId { get; set; }

    [Required(ErrorMessage = "Skill is required")]
    public int SkillId { get; set; }

    public Job Job { get; set; }

    public List<SelectListItem> Skills { get; set; }

    public AddJobSkillViewModel(Job theJob, List<Skill> possibleSkills)
    {
        Skills = new List<SelectListItem>();

        foreach (var skill in possibleSkills)
        {
            Skills.Add(new SelectListItem
            {
                Value = skill.Id.ToString(),
                Text = skill.Name
            });
        }

        Job = theJob;
    }

    public AddJobSkillViewModel()
    {
    }
}
