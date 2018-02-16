using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }

        public Classroom Classroom { get; set; }
        
        public virtual IEnumerable<Lecturer> Lecturer { get; set; }

        public int ScheduleId { get; set; }
        public  Schedule Schedule { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual IEnumerable<Group> Groups { get; set; }
        public int GroupNumber { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public Course Course { get; set; }

        
    }

    public enum Course : byte
    {
        first = 1,
        second,
        third,
        fourth,
        fifth
    }

}
