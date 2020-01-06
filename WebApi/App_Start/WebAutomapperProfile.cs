using WebApi.Models;
using AutoMapper;
using BL.BLModels;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.App_Start
{
	public class WebAutomapperProfile : Profile
	{
		public WebAutomapperProfile()
		{
			CreateMap<ArticleView, ArticleBL>().ReverseMap();
			CreateMap<IList<ArticleView>, IList<ArticleBL>>().ReverseMap();
		}
	}
}