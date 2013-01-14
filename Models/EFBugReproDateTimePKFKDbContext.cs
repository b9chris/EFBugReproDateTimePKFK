using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace EFBugReproDateTimePKFK.Models
{
	public class EFBugReproDateTimePKFKDbContext : DbContext
	{
		public DbSet<MyClass> MyClasses { get; set; }



		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}