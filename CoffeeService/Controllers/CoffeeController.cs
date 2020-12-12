using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CoffeeController : ControllerBase
{
    private readonly CoffeeService _coffeeService;
    public CoffeeController(CoffeeService coffeeService)
    {
        _coffeeService = coffeeService;
    }

    [HttpGet]
    public async Task<List<Coffee>> GetAll()
    {
        return await _coffeeService.GetAll();
    }
}