using BL.Abstract;
using BL.BLModels;
using DAL.Entities;
using DAL.Repository;

namespace BL.Services
{
	public class BLArticleService : GenericCRUDServices<ArticleBL, BlogArticle>
	{
		public BLArticleService() : base(new ArticleRepository())
		{
		}
		
	}	
}
