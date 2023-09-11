using Avotion.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Avotion.Server.Controllers;
[ApiController]
[Route("[controller]")]
public class TempController : ControllerBase
{

	[HttpGet]
	public string Get()
	{
		return "Avotion is client-only for now.";
	}
}
