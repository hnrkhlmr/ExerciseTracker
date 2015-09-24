using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ExerciseTracker.Models
{
    public class Set
    {
        public Guid Id { get; set; }
        [Required]        
        public int Reps { get; set; }
        [Required]
        public decimal Weight { get; set; }
        [StringLength(100)]
        public string Comment { get; set; }
    }
}
