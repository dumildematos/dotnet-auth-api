using System;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_auth_api.Controllers
{
	[ApiController]
	[Route("")]
	public class AuthController: Controller
	{
		[HttpGet]
		public IActionResult Hello()
		{
			return Ok("Sucess!");
		}
	}
}

