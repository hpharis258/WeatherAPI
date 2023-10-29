using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly LocationContext dbContext;
        //
        public LocationController(LocationContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Get api/Locations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            if (this.dbContext.Locations == null)
            {
                return NotFound();
            }
            return await dbContext.Locations.ToListAsync();
        }

        // Get api/Location/id
        [HttpGet("{id}")]
            public async Task<ActionResult<Location>> GetLocation(int id)
            {
                if(this.dbContext.Locations == null)
                { 
                    return NotFound(); 
                }
                var location = await dbContext.Locations.FindAsync(id);
                //
                if(location == null)
                {
                    return NotFound();
                }
                return location;
            }
        // POST: api/Movies
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            dbContext.Locations.Add(location);
            await dbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetLocation), new {id =  location.Id}, location);

        }
    }
    

}
