using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;

namespace DAL.Entities
{
	[TableName("Comment")]
	public class Comment : DALEntity
	{
		public override int Id { get; set; }
		public string Body { get; set; }
		public DateTime Date { get; set; }
		public int ArticleId { get; set; }
		public int AuthorId { get; set; }
	}
}
