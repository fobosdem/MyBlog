using AutoMapper;
using BL.BLModels;
using BL.Generic;
using DAL.Entities;
using DAL.Repository;
using System.Collections.Generic;
using LightInject;

namespace BL.Services
{
	public interface IArticleService : IGenereicService<ArticleBL>
	{

	}


	public class BLArticleService : GenericService<ArticleBL, BlogArticle>, IArticleService
	{
		private readonly IMapper _mapper;



		public BLArticleService(IGenericRepository<BlogArticle> repository, IMapper mapper) : base(repository)
		{ 
			_mapper = mapper;
		}

		public override ArticleBL Map(BlogArticle model)
		{
			return _mapper.Map<ArticleBL>(model);
		}

		public override BlogArticle Map(ArticleBL model)
		{
			return _mapper.Map<BlogArticle>(model);
		}

		public override IEnumerable<ArticleBL> Map(IList<BlogArticle> entitiesList)
		{
			return _mapper.Map<IEnumerable<ArticleBL>>(entitiesList);
		}

		public override IEnumerable<BlogArticle> Map(IList<ArticleBL> entitiesList)
		{
			return _mapper.Map<IEnumerable<BlogArticle>>(entitiesList);
		}
	}
}
