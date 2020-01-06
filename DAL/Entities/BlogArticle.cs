using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
	[TableName("BlogArticle")]
	public class BlogArticle
	{
		public int Id { get; set; }
		public string Img { get; set; }
		public string Title { get; set; }
		public string SubTitle { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		public bool IsActive { get; set; }
		public List<Comment> Comments { get; set; }
		public int AuthorId { get; set; }
	}
}
