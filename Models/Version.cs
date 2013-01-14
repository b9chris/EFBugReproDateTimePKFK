using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFBugReproDateTimePKFK.Models
{
	public class Version
	{
		[Key]
		public DateTime From { get; set; }

		public virtual MyClass VersionOf { get; set; }
	}
}