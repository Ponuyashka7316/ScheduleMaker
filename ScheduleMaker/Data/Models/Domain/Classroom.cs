using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        [MaxLength(255)]
        public string Type { get; set; }
        public virtual ClassroomDetail ClassroomDetails { get; set; }

    }

    public class ClassroomDetail
    {
        [ForeignKey("Classroom")]
        public int ClassroomDetailId { get; set; }
        [MaxLength(255)]
        public string Corpus { get; set; }
        [MaxLength(255)]
        public string Floor { get; set; }    //этаж
        [MaxLength(255)]
        public string Number { get; set; }    

        public virtual Classroom Classroom { get; set; }
    }
}
