using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public int CohortId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        public List<Exercise> AssignedExercises { get; set; } = new List<Exercise>();
    }
}
