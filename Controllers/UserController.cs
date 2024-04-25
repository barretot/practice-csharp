using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Communication.Request;
using MyFirstApi.Communication.Response;

namespace MyFirstApi.Controllers;
[Route("api/[controller]")]
[ApiController] // Identificação de que a classe é um controller

public class UserController : ControllerBase // Herdando 
{
    [HttpGet]
    [Route("infos/{cpf}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetUser([FromHeader]int id, [FromQuery]string nickname, string cpf)
    {
        var response = new User
        {
            Id = 1,
            Age = 22,
            Name = "Ruan"
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUser), StatusCodes.Status201Created)]
    public IActionResult CreateUser([FromBody] RequestRegisterUser request)
    {
        var response = new ResponseRegisterUser
        {
            Name = request.Name,
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser(
        [FromRoute] Guid id,
        [FromBody] RequestUpdateUserProfile request)
    {
        return NoContent();
    }
}
