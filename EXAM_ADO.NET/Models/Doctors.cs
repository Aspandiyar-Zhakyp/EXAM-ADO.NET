using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Models
{
    public class Doctors : Entity
    {
        public string Name { get; set; }
        public string TypeOfWork { get; set; }
        public ICollection<Direction> Directions { get; set; }
    }
}
