using BugTracker.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BugTracker.Controllers
{
    public class BugsController : ApiController
    {
        private readonly IBugsRepository bugsRepository = new BugsRepository();

        public IEnumerable<Bug> Get()
        {
            return bugsRepository.GetBugs();
        }

        [HttpPost]
        //[Route("api/bugs/backlog")]
        public Bug Backlog([FromBody] int id)
        {
            var bug = bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "backlog";
            return bug;
        }

        [HttpPost]
        //[Route("api/bugs/working")]
        public Bug Working([FromBody] int id)
        {
            var bug = bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "working";
            return bug;
        }

        [HttpPost]
        //[Route("api/bugs/done")]
        public Bug Done([FromBody] int id)
        {
            var bug = bugsRepository.GetBugs().First(b => b.id == id);
            bug.state = "done";
            return bug;
        }
    }
}