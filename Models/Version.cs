using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFBugReproDateTimePKFK.Models
{
	public class Version
	{
		public int Id { get; set; }

		public DateTime From { get; set; }

		public virtual MyClass VersionOf { get; set; }
	}
}