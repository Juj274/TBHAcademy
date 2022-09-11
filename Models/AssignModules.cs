using System;
using System.ComponentModel.DataAnnotations;

namespace TBHAcademy.Models
{
    public class AssignModules
    {
        [Key]
        public int AssignedID { get; set; }
        [Required]
        public string TutorID { get; set; }
        [Required]
        public int ModuleID { get; set; }
        [Required]
        public DateTime DateAssigned { get; set; }

    }
}
