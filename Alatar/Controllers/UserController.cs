using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Alatar.Models;
using Alatar.Models.Core;

namespace Alatar.Controllers
{
	public class UserController : ApiController
	{

		[HttpGet]
		public User GetUser(int id)
		{
			using (var db = new AlatarContext())
			{
				var response = db.Users.Find(id);
				return response;
			}
		}
	}
}