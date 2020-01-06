using AutoMapper;
using BL.BLModels;
using BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
	public class ValuesController : ApiController
	{
		private readonly IArticleService _articleService;
		private readonly IMapper _mapper;
		public ValuesController(IArticleService articleService, IMapper mapper)
		{
			_articleService = articleService;
			_mapper = mapper;
		}
		// GET api/values
		[HttpGet]
		public IEnumerable<ArticleView> Get()
		{
			var listBLArticle = _articleService.GetAll();
			var articles = _mapper.Map<IEnumerable<ArticleView>>(listBLArticle);

			return articles;
		}

		// GET api/values/5
		public ArticleView Get(int id)
		{
			var articleBL = _articleService.FindById(id);
			var article = _mapper.Map<ArticleView>(articleBL);
			return article;
		}

		// POST api/values
		
		public void Post([FromBody]ArticleView value)
		{
			var newBLArticle = _mapper.Map<ArticleBL>(value);
			_articleService.Create(newBLArticle);

		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
			var newBLArticle = _mapper.Map<ArticleBL>(value);
			_articleService.Update(newBLArticle);
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
			_articleService.Delete(id);
		}
	}
}
