using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALevelBlogProject.Models
{
	public class ArticleView
	{
		[HiddenInput(DisplayValue = false)]
		public int Id { get; set; }
		[Required(ErrorMessage = "Should be filled")]
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Body { get; set; }
		public string Image { get; set; }
		public int AuthorId { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
	   ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }
		public bool IsActive { get; set; }
		//public List<CommentBL> Comments { get; set; }
	}
}