using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Alatar.Models.Core
{
	[Table("User", Schema = "Core")]
	public class User
	{
		[Key]
		[Column("UserId")]
		public int Id { get; set; }

		public string Name { get; set; }
	}
}