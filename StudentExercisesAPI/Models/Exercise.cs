using System.ComponentModel.DataAnnotations;

namespace StudentExercisesAPI.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public string Language { get; set; }
    }
}