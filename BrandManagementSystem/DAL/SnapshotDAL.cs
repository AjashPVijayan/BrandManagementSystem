using BrandManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandManagementSystem.DAL
{
    public class SnapshotDAL : ISnapshotDAL
    {
       
        public snapShotEntity getSnapshotData()
        {
            return ReturnTemData();
        }

        private snapShotEntity ReturnTemData()
        {
            snapShotEntity tempData = new snapShotEntity();
            tempData.date = DateTime.Now.Date.ToShortDateString();
            tempData.temperatureC = 27;
            tempData.temperatureF = 42;
            tempData.summary = "Summary Details";
            return tempData;

        }
    }
}
