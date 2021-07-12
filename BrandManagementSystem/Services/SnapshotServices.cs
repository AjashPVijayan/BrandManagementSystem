using BrandManagementSystem.DAL;
using BrandManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandManagementSystem.Services
{
    public class SnapshotServices : ISnapshotServices
    {
        ISnapshotDAL _napshotDAL;
        public SnapshotServices(ISnapshotDAL napshotDAL)
        {
            _napshotDAL = napshotDAL;
        }
        public snapShotEntity getSnapshotData()
        {
            snapShotEntity snapShotData = _napshotDAL.getSnapshotData();
            return snapShotData;
        }
    }
}
