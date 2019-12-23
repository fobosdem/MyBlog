using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;

namespace DAL.Entities
{
	[TableName("Author")]
	public class Author : DALEntity
	{
		public override int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NikName { get; set; }
		public string Avatar { get; set; }
		public List<Comment> Comments { get; set; }
		public List<BlogArticle> Articles { get; set; }
	}
}
