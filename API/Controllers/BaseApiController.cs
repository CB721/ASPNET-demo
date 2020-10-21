using Microsoft.AspNetCore.Mvc;

namespace ASPNETAngularDemo.API.Controllers
{
    [ApiController]
    // request to api/users
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}