using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Lecturer
    {
        [Key]
        public int LecturerId { get; set; }

        [MaxLength(255)]
        public string FIO { get; set; }

        public int CurrentLessonId { get; set; }
        public Lesson CurrentLesson { get; set; }

        public List<LecturerSubjects> LecturerSubjects { get; set; } //многие ко многим с предметами, указать кол-во часов
    }
}
