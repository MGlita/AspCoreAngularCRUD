using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPCoreAngular.Models;

namespace ASPCoreAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressesController : ControllerBase
    {
        private readonly ModelContext _context;

        public UserAddressesController(ModelContext context)
        {
            _context = context;
        }

        // GET: api/UserAddresses
        [HttpGet]
        public IEnumerable<UserAddress> GetUserAddress()
        {
            return _context.UserAddress;
        }

        // GET: api/UserAddresses/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserAddress([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userAddress = await _context.UserAddress.FindAsync(id);

            if (userAddress == null)
            {
                return NotFound();
            }

            return Ok(userAddress);
        }

        // PUT: api/UserAddresses/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserAddress([FromRoute] int id, [FromBody] UserAddress userAddress)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != userAddress.UserId)
            {
                return BadRequest();
            }

            _context.Entry(userAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserAddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/UserAddresses
        [HttpPost]
        public async Task<IActionResult> PostUserAddress([FromBody] UserAddress userAddress)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.Values);
            }

            _context.UserAddress.Add(userAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUserAddress", new { id = userAddress.UserId }, userAddress);
        }

        // DELETE: api/UserAddresses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAddress([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userAddress = await _context.UserAddress.FindAsync(id);
            if (userAddress == null)
            {
                return NotFound();
            }

            _context.UserAddress.Remove(userAddress);
            await _context.SaveChangesAsync();

            return Ok(userAddress);
        }

        private bool UserAddressExists(int id)
        {
            return _context.UserAddress.Any(e => e.UserId == id);
        }
    }
}