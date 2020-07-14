using System;
using TechJobsPersistent.Models;
using System.Collections.Generic;

namespace TechJobsPersistent.ViewModels
{
    public class JobDetailViewModel
    {
        public int JobId { get; set; }
        public string Name { get; set; }
        public string EmployerName { get; set; }
        public string SkillText { get; set; }
        public string Location { get; set; }

        public JobDetailViewModel(Job newJob, List<JobSkill> jobSkills)
        {
            JobId = newJob.Id;
            Name = newJob.Name;
            EmployerName = newJob.Employer.Name;
            Location = newJob.Employer.Location;
            SkillText = "";

            for (int i = 0; i < jobSkills.Count; i++)
            {
                SkillText += jobSkills[i].Skill.Name;
                if (i < jobSkills.Count - 1)
                {
                    SkillText += ", ";
                }
            }
        }
    }
}
