using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFBugReproDateTimePKFK.Models
{
	public class MyClass
	{
		public int Id { get; set; }

		public virtual ICollection<Version> Versions { get; set; }

		public virtual Version CurrentVersion { get; set; }
	}
}