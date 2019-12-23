using ALevelBlogProject.Models;
using AutoMapper;
using BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALevelBlogProject.Mapping
{
	internal static class MapperBLtoVIew<BLItem, ViewItem> where BLItem : BLEtity where ViewItem : Etity
	{
		private static IMapper _blMapper = new MapperConfiguration(
			conf =>
			{
				conf.CreateMap<BLItem, ViewItem>();
				conf.CreateMap<ViewItem, BLItem>();
			}).CreateMapper();
		internal static ViewItem FromBlToView(BLItem item)
		{
			return _blMapper.Map<BLItem, ViewItem>(item);
		}
		internal static BLItem FromViewToBl(ViewItem item)
		{
			return _blMapper.Map<ViewItem, BLItem>(item);
		}
	}
}