using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleRestv2.Context;
using SimpleRestv2.Models;

namespace SimpleRestv2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CyberarkController : ControllerBase
    {
        private readonly CyberarkDbContext _context;

        public CyberarkController(CyberarkDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cyberark>>> GetTasks()
        {
            return await _context.Cyberarks.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Cyberark>> CreateTask(Cyberark cyberark)
        {
            _context.Cyberarks.Add(cyberark);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTasks), new { id = cyberark.Id }, cyberark);
        }

        // Implement other CRUD operations (PUT, DELETE) similarly
    }
}
