using DatabaseWrapper;
using DatabaseWrapper.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers;

[Route("/api/[controller]")]
public class UsersController : Controller
{
	private readonly Repository _repository;
	public UsersController(Repository repository)
	{
		_repository = repository;
	}
	[HttpGet("{id}")]
	public IActionResult GetUser(int id)
	{
		var foundUser = _repository.Find<AppUser>(id);
		if (foundUser == null)
		{
			foundUser = new AppUser { Id = -1 };
		}
		return new ObjectResult(foundUser);
	}
}
