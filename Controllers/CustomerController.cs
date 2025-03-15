using FullstackAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullstackAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    // GET: api/<CustomerController>
    [HttpGet]
	public async Task<ActionResult<IEnumerable<string>>> GetAllCustomers()
	{
		var products = await _customerRepository.GetAllAsync();

		if (products == null)
		{
			return NotFound("There are no products listed.");
		}
		return Ok(products);
	}

	// GET api/<CustomerController>/5
	[HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<CustomerController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<CustomerController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CustomerController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
