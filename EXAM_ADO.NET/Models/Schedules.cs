using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Models
{
    public class Schedules : Entity
    {
        public DateTime Begins { get; set; }  
        public DateTime Ending { get; set; }
        public ICollection<Direction> Directions { get; set; }
    }
}
