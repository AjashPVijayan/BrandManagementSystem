using BrandManagementSystem.Models;
using BrandManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BrandManagementSystem.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SnapshotController : ControllerBase
    {
        ISnapshotServices _snapshotServices;
        public SnapshotController(ISnapshotServices snapshotServices)
        {
            _snapshotServices = snapshotServices;
        }
        // GET: api/<SnapshotController>
        [HttpGet]
        public snapShotEntity getSnapshotData()
        {
            snapShotEntity snapShotData = _snapshotServices.getSnapshotData();
            return snapShotData;
        }

        // GET api/<SnapshotController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SnapshotController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SnapshotController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SnapshotController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
