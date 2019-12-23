using AutoMapper;
using BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;

namespace BL.Mapping
{
	internal static class Mapping<BLItem, DALItem> where BLItem : BLEtity where DALItem : DALEntity
	{
		private static IMapper _blMapper = new MapperConfiguration(
			conf =>
			{
				conf.CreateMap<BLItem, DALItem>();
				conf.CreateMap<DALItem, BLItem>();
			}).CreateMapper();
		internal static DALItem FromBlToDal(BLItem item)
		{
			return _blMapper.Map<BLItem, DALItem>(item);
		}
		internal static BLItem FromDalToBl(DALItem item)
		{
			return _blMapper.Map<DALItem, BLItem>(item);
		}
	}
}
