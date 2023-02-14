using System;
using System.ComponentModel.DataAnnotations;
namespace Mission06_Movies.Models
{
	public class MovieResponse
	{ 
		// This model contains the MovieResponse object class with all of its attributes
		// Validation is provide in the model as well as everything except Edited, LentTo, and Notes is required
		// The Notes field is also limited to 25 characters
		[Key]
		[Required]
		public int MovieID { get; set; }
		[Required]
		public string Category { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public int Year { get; set; }
		[Required]
		public string Director { set; get; }
		[Required]
		public string Rating { set; get; }
		public bool Edited { set; get; }
		public string LentTo { set; get; }
		[StringLength(25)]
		public string Notes { set; get; }
	}
}

