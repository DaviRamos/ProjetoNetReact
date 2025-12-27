using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeopleController(AppDbContext context) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Person>>> GetPeople()
    {
        try
        {
            return await context.People.ToListAsync();
        }
        catch (System.Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get people");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Person>> GetPerson(int id)
    {
        try
        {
            var person = await context.People.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }
            return person;
        }
        catch (System.Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get person");
        }
    }

    [HttpPost]
    public async Task<ActionResult<Person>> AddPerson(Person person)
    {
        try
        {
            context.People.Add(person);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPeople), new { id = person.Id }, person);
        }
        catch (System.Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to add person");
        }

    }

    [HttpPut]
    public async Task<ActionResult<Person>> UpdatePerson(int id, [FromBody] Person person)
    {
        try
        {
            var existingPerson = await context.People.FindAsync(id);
            if (existingPerson == null)
            {
                return NotFound();
            }
            existingPerson.FirstName = person.FirstName;
            existingPerson.LastName = person.LastName;
            await context.SaveChangesAsync();
            return person;
        }
        catch (System.Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to update person");
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<Person>> DeletePerson(int id, [FromBody] Person person)
    {
        try
        {
            var existingPerson = await context.People.FindAsync(id);
            if (existingPerson == null)
            {
                return NotFound();
            }
            context.People.Remove(existingPerson);
            await context.SaveChangesAsync();
            return existingPerson;
        }
        catch (System.Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "Failed to delete person");
        }
    }
}
