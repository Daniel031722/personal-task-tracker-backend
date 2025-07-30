using Microsoft.AspNetCore.Mvc;
using personal_task_tracker_backend.Models;

namespace personal_task_tracker_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : ControllerBase
    {
        // Updated mock data
        private static readonly List<Member> memberList = new List<Member>
        {
            new Member { Id = 1, FirstName = "Daniel", LastName = "Pinto", College = "RIT" },
            new Member { Id = 2, FirstName = "Khushi", LastName = "Chitari", College = "RIT" },
            new Member { Id = 3, FirstName = "Rohit", LastName = "Vishwakarma", College = "GEC" },
            new Member { Id = 4, FirstName = "Pallavi", LastName = "Sutar", College = "PCCE" }
        };

        // GET: /Members
        [HttpGet]
        public ActionResult<IEnumerable<Member>> GetMembers()
        {
            return Ok(memberList);
        }

        // GET: /Members/2
        [HttpGet("{id}")]
        public ActionResult<Member> GetMemberById(int id)
        {
            var member = memberList.FirstOrDefault(m => m.Id == id);
            if (member == null)
                return NotFound();

            return Ok(member);
        }
    }
}
