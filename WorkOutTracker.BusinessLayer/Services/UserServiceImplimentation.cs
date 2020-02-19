using System;
using System.Collections.Generic;
using System.Text;
using WorkOutTracker.BusinessLayer.Interfaces;
using WorkOutTracker.Entities;

namespace WorkOutTracker.BusinessLayer.Services
{
    class UserServiceImplimentation : IUserServices
    {

        public bool AddWorkOutCollection(WorkOutCollection workOut)
        {
            return true;
        }

        public WorkOutCollection EditWorkOutCollection(long workOutId)
        {
            throw new NotImplementedException();
        }

        public List<WorkOutCollection> ViewWorkOutCollections(int userId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteWorkOutCollection(long workOutId)
        {
            return true;
        }



        public bool AddWorkOutCategory(WorkOutCategory workOut)
        {
            return true;
        }

        public WorkOutCategory EditWorkOutCategory(long categoryId)
        {
            WorkOutCategory category = new WorkOutCategory();
            return category;
        }

        public List<WorkOutCategory> ViewWorkOutCategory(int userId)
        {
            throw new NotImplementedException();
        }
         
        public bool DeleteWorkOutCategory(long categoryId)
        {
            return true;
        }

       


        public void EndWorkOut(DateTime EndTime, DateTime EndDate, int userId)
        {
            throw new NotImplementedException();
        }

        public void StartWorkOut(DateTime StartTime, DateTime StartDate, int userId)
        {
            throw new NotImplementedException();
        }


        public void CreateReportOnWorkOut(WorkOutActive active, int userID)
        {

        }

    }
}
