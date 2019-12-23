using AutoMapper;
using BL.BLModels;
using BL.Services;
using ALevelBlogProject.Mapping;
using ALevelBlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALevelBlogProject.Controllers
{
	public class ArticleController : Controller
	{
		// GET: Article
		public ActionResult Index()
		{
			return View();
		}

		// GET: Article/Details/5
		[HttpGet]
		public ActionResult Details(int id=1)
		{
			var art = new BLArticleService();
			ArticleView art1 = MapperBLtoVIew<ArticleBL, ArticleView>.FromBlToView(art.GetById(id));
			return View(art1);
		}

		// GET: Article/Create
		public ActionResult Create(ArticleView article)
		{
			ArticleView newArticle = new ArticleView()
			{
				Title = "Hello",
				Body = "dfasdfasdfasdfasdf",
				Date = DateTime.UtcNow,
				AuthorId = 2
			};


			var art = new BLArticleService();
			int id = art.Create(MapperBLtoVIew<ArticleBL, ArticleView>.FromViewToBl(newArticle));

			return Redirect("Home/Index");
		}

		// POST: Article/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Article/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Article/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Article/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Article/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
	}
}
