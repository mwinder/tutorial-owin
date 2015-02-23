using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public interface IBugsRepository
    {
        IEnumerable<Bug> GetBugs();
    }

    public class BugsRepository : IBugsRepository
    {
        List<Bug> bugs = new List<Bug> { 
            new Bug() { id = 1, title = "Bug 1", state = "backlog" },
            new Bug() { id = 2, title = "Bug 2", state = "working" },
        };

        public IEnumerable<Bug> GetBugs()
        {
            return bugs;
        }
    }
}
