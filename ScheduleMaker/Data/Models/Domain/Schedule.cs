using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleMaker.Data.Models.Domain
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        public string ArtistId { get; set; }

        [ForeignKey("ArtistId")]
        public ApplicationUser Artist { get; set; } //Belong to the user

        public virtual IEnumerable<Lesson> Lessons { get; set; }
    }
}
