using System;
using System.Collections.Generic;
using System.Text;
using WorkOutTracker.Entities;

namespace WorkOutTracker.BusinessLayer.Interfaces
{
   public  interface IUserServices
    {
        bool AddWorkOutCollection(WorkOutCollection workOut);
        bool DeleteWorkOutCollection(long workOutId);
        WorkOutCollection EditWorkOutCollection(long workOutId);
        List<WorkOutCollection> ViewWorkOutCollections(int userId);


        bool AddWorkOutCategory(WorkOutCategory workOut);
        bool DeleteWorkOutCategory(long categoryId);
        WorkOutCategory EditWorkOutCategory(long categoryId);
        List<WorkOutCategory> ViewWorkOutCategory(int userId);

        void StartWorkOut(DateTime StartTime, DateTime StartDate, int userId);
        void EndWorkOut(DateTime EndTime, DateTime EndDate, int userId);

        void CreateReportOnWorkOut(WorkOutActive active, int userID);

    }
}
