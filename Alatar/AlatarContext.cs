using Alatar.Models.Core;

namespace Alatar.Models
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class AlatarContext : DbContext
	{
		// Your context has been configured to use a 'Alatar' connection string from your application's 
		// configuration file (App.config or Web.config). By default, this connection string targets the 
		// 'Alatar.Models.Model1' database on your LocalDb instance. 
		// 
		// If you wish to target a different database and/or database provider, modify the 'Model1' 
		// connection string in the application configuration file.
		public AlatarContext()
			: base("name=Alatar")
		{
		}

		// Add a DbSet for each entity type that you want to include in your model. For more information 
		// on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

		public virtual DbSet<User> Users { get; set; }
	}
}