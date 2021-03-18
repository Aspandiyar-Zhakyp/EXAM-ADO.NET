using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Models
{
    public class Direction : Entity
    {
        public Doctors Doctor { get; set; }
        public Schedules Schedule { get; set; }
    }
}
