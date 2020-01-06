using DAL.Repository;
using BL.BLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace BL.Generic
{
	public interface IGenereicService<BLModel> where BLModel : class

	{
		BLModel FindById(int id);
		IEnumerable<BLModel> GetAll();
		void Create(BLModel newArticle);
		void Delete(int id);
		void Update(BLModel article);
	}

	public abstract class GenericService<BLModel, DModel> : IGenereicService<BLModel>
		where BLModel : class
		where DModel : class
	{
		private readonly IGenericRepository<DModel> _repositroy;
		public GenericService(IGenericRepository<DModel> repository)
		{
			_repositroy = repository;
		}

		public virtual BLModel FindById(int id)
		{
			var entity = _repositroy.FindById(id);
			return Map(entity);
		}

		public IEnumerable<BLModel> GetAll()
		{
			var listEntity = _repositroy.Get();
			return Map(listEntity);
		}

		public void Create(BLModel newArticle)
		{
			DModel nArticle = Map(newArticle);
			_repositroy.Create(nArticle);
		}
		public void Delete(int id)
		{

			DModel dArticle = _repositroy.FindById(id);
			_repositroy.Remove(dArticle);
		}
		public void Update(BLModel article)
		{
			DModel nArticle = Map(article);
			_repositroy.Update(nArticle);
		}

		/// <summary>
		/// convert Dal model to Bl molder
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public abstract BLModel Map(DModel entity);
		public abstract DModel Map(BLModel blmodel);

		public abstract IEnumerable<BLModel> Map(IList<DModel> entity);
		public abstract IEnumerable<DModel> Map(IList<BLModel> entity);

	}
}
