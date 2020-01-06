using AutoMapper;
using BL;
using BL.Mapping;
using BL.Services;
using LightInject;
using LightInject.Mvc;
using LightInject.WebApi;
using System.Collections.Generic;
using System.Reflection;
using System.Web.Mvc;

namespace ALevelBlogProject.App_Start
{
	public static class LightInjectConfig
	{
		public static void Configuration()
		{
			var container = new ServiceContainer();
			container.RegisterControllers(Assembly.GetExecutingAssembly());

			container.EnablePerWebRequestScope();



			container = BLLightInjectCongiguration.Congiguration(container);

			container.Register<IArticleService, BLArticleService>();
			var config = new MapperConfiguration(cfg => cfg.AddProfiles(
					new List<Profile>() { new WebAutomapperProfile(), new Mapping() }));

			container.Register(c => config.CreateMapper());
			container.EnableMvc();
		}
	}
}