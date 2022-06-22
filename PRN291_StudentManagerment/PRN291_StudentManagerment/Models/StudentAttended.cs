﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PRN291_StudentManagerment.Models
{
    public partial class StudentAttended
    {
        public int StudentAttendedId { get; set; }
        public int? ScheduleId { get; set; }
        public int? StudentId { get; set; }
        public DateTime? StudentAttendedDate { get; set; }
        public bool? StudentStatus { get; set; }

        public virtual Schedule Schedule { get; set; }
        public virtual Student Student { get; set; }
    }
}
