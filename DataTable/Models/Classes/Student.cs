using System.ComponentModel.DataAnnotations;

namespace DataTable.Models.Classes
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? StudentName  { get; set; }
        [Required]
        public string? StudentGender { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? FatherName { get; set; }
        [Required]
        public string? MotherName { get; set; }
        [Required]
        public string? Nationality  { get; set; }
    }
}
