using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class LocationController : BaseApiController
    {
        private readonly DataContext _context;

        public LocationController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Location>>> GetLocation()
        {
            return await _context.Locations.ToListAsync();
        }
    }
}