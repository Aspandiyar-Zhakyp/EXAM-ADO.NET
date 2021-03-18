using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_ADO.NET.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
