﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevelBlogProject.Models
{
	public class ArticleView : Etity
	{
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Body { get; set; }
		public string Image { get; set; }
		public int AuthorId { get; set; }
		public DateTime Date { get; set; }
		public bool IsActive { get; set; }
		//public List<CommentBL> Comments { get; set; }
	}
}