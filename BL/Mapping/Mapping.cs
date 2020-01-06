using AutoMapper;
using BL.BLModels;
using DAL.Entities;
using System.Collections.Generic;

namespace BL.Mapping
{
	public class Mapping : Profile
	{
		public Mapping()
		{
			CreateMap<ArticleBL, BlogArticle>().ReverseMap();
			CreateMap<CommentBL, Comment>().ReverseMap();
		}
	}
}
