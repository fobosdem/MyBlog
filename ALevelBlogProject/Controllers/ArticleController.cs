using AutoMapper;
using BL.BLModels;
using BL.Services;
using ALevelBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LightInject;
using LightInject.Mvc;

namespace ALevelBlogProject.Controllers
{
	public class ArticleController : Controller
	{
		private readonly IArticleService _articleService;
		private readonly IMapper _mapper;
		public ArticleController(IArticleService articleService, IMapper mapper)
		{
			_articleService = articleService;
			_mapper = mapper;
		}

		// GET: Article
		public ActionResult Index()
		{
			var listBLArticle = _articleService.GetAll();
			var articles = _mapper.Map<IEnumerable<ArticleView>>(listBLArticle);
			return View(articles);
		}

		// GET: Article/Details/5

		public ActionResult Details(int id)
		{
			var articleBL = _articleService.FindById(id);
			var article = _mapper.Map<ArticleView>(articleBL);
			return View(article);
		}

		// GET: Article/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Article/Create
		[HttpPost]
		public ActionResult Create(ArticleView article)
		{
			if (ModelState.IsValid)
			{
				var newBLArticle = _mapper.Map<ArticleBL>(article);
				_articleService.Create(newBLArticle);
				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.Message = "Not Valid";
				return View(article);
			}
		}

		// GET: Article/Edit/5
		public ActionResult Edit(int id)
		{
			var edditArt = _mapper.Map<ArticleView>(_articleService.FindById(id));
			return View(edditArt);
		}

		// POST: Article/Edit/5
		[HttpPost]
		public ActionResult Edit(ArticleView article)
		{
			if (ModelState.IsValid)
			{
				var newBLArticle = _mapper.Map<ArticleBL>(article);
				_articleService.Update(newBLArticle);
				return RedirectToAction("Index");
			}
			else
			{
				ViewBag.Message = "Not Valid";
				return View(article);
			}
		}

		// GET: Article/Delete/5
		public ActionResult Delete(int id)
		{
			_articleService.Delete(id);
			return RedirectToAction("Index");
		}

		//// POST: Article/Delete/5
		//[HttpPost]
		//public ActionResult Delete(int id, FormCollection collection)
		//{
		//	try
		//	{
		//		// TODO: Add delete logic here

		//		return RedirectToAction("Index");
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}
	}
}
