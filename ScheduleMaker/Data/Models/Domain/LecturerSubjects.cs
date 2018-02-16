using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class LecturerSubjects
    {
        [Key]
        public int LecturerSubjectsId { get; set; }
        [DefaultValue(0)]
        public int CountHours { get; set; }
        [DefaultValue(0)]
        public int Credits { get; set; }

        [MaxLength(255)]
        public string DetailedData { get; set; }

        public int? SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public int? LecturerId { get; set; }

        [ForeignKey("LecturerId")]
        public Lecturer Lecturer { get; set; }
    }
}
