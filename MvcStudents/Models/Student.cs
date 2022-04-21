using System.ComponentModel.DataAnnotations;

namespace MvcStudents.Models
{
    public class Student
    {
        public int Id { get; set; }

        [StringLength(300)]
        public string? Name { get; set; }

        [StringLength(1)]
        public string? Gender { get; set; }

        [Range(0, 200, ErrorMessage = "年龄在0-200之间")]
        public int Age { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthdayDate { get; set; }
        [StringLength(13)]
        public string? Phone { get; set; }

        [Range(30, 50)]
        public decimal Temperature { get; set; }
        
        public DateTime TodayDate { get; set; }
    }
}
