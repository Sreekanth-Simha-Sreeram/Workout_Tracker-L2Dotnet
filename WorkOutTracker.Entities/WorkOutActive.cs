using System;
using System.Collections.Generic;
using System.Text;

namespace WorkOutTracker.Entities
{
   public class WorkOutActive
    {
        public virtual int WorkOutID { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; } 
        public virtual DateTime EndDate { get; set; }
        public virtual string Comment { get; set; }
        public virtual bool Status { get; set; }

    }
}
