using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Subject
    {
        [ForeignKey("Lesson")]
        public int SubjectId { get; set; }
        public string Name { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual IEnumerable<LecturerSubjects> LecturerSubjects { get; set; }
    }
}
