[ApiController]
public class UserController : ControllerBase 
{ 
    [HttpGet("user/all")] 
    public ActionResult<IEnumerable<User>> GetAll()
    {
        return new []
        {
            new User { Name = "olá", Age = 32, isActive = true, Id = 0 }
        };
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool isActive { get; set; }
	public int Id { get; set; }
}

