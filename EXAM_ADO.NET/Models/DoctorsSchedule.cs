using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Models
{
    public class DoctorsSchedule : Entity
    {
        public Guid DoctorsId { get; set; }
        public virtual Doctors Doctors { get; set; }
        public Guid SchedulesId { get; set; }
        public virtual Schedules Schedules { get; set; }
    }
}
