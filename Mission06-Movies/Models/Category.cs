using System;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Movies.Models
{
	public class Category
	{
		// Category class with category id and category name
		[Key]
		[Required]
		public int CategoryID { get; set; }
		public string CategoryName { get; set; }

	}
}

