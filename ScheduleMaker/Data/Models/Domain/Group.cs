using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        public string Facilty { get; set; }  //факультет e.g. КСФ
        [MaxLength(255)]
        public string Specialication { get; set; }  //eg транспортные технологии
        public Course Course { get; set; }  //принадлежность курсу

        public int CurrentLessonId { get; set; }
        public Lesson CurrentLesson { get; set; }

    }
}
