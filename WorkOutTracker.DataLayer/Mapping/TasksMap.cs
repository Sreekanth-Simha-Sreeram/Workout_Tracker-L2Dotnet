using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using WorkOutTracker.Entities;

namespace EMart.BusinessLayer
{
    public class WorkOutCollectionMap : ClassMap<WorkOutCollection>
    {
        public WorkOutCollectionMap()
        {
        //     public virtual int WorkOutID { get; set; }
        //public virtual string WorkOutTitle { get; set; }
        //public virtual string Note { get; set; }
        //public virtual float CaloriesBurnPerMin { get; set; }
        //public virtual int CategoryID { get; set; }


            Id(x => x.WorkOutID);
            Map(x => x.WorkOutTitle);
            Map(x => x.Note);
            Map(x => x.CaloriesBurnPerMin);
            Map(x => x.CategoryID);
            Table("workOutCollection");

        }
    }


}
