using Lorekeeper.Storage;
using Microsoft.AspNetCore.Mvc;

namespace Lorekeeper.Controllers;
[ApiController]
[Route("[controller]")]
public class CharacterController : ControllerBase
{
	private CharacterContext characterContext;

	public CharacterController(CharacterContext characterContext)
	{
		this.characterContext = characterContext;
	}

	[HttpGet(Name = "GetCharacter")]
	public Character Get(Guid Id)
	{
		var character = new Character()
		{
			Id = Id,
			Name = "Thomas the Man with a Plan",
		};

		return character;
	}

	[HttpPost(Name = "PostCharacter")]
	public async Task Post(Guid? Id, String Name)
	{
		
		var character = new Character()
		{
			Id = (Id ??= Guid.NewGuid()),
			Name = Name,
		};

		characterContext.Add(character);
		await characterContext.SaveChangesAsync();
	}
}
