using System;
using System.Collections.Generic;

#nullable disable

namespace PRN291_StudentManagerment.Models
{
    public partial class Lecturer
    {
        public Lecturer()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int LecturerId { get; set; }
        public string LecturerName { get; set; }
        public string LecturerEmail { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
