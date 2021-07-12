using BrandManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrandManagementSystem.DAL
{
    public interface ISnapshotDAL
    {
        snapShotEntity getSnapshotData();
    }
}
