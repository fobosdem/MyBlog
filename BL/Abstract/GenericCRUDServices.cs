using BL.Mapping;
using DAL.Interface;
using DAL.Repository;
using BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL.Abstract
{
	public abstract class GenericCRUDServices<BLModel, DALModel> where BLModel : BLEtity where DALModel: DALEntity
	{
        public  GenericRepository<DALModel> repository;

        public GenericCRUDServices(GenericRepository<DALModel> rep)
        {
            repository = rep;
        }

        public int Create (BLModel item)
        {
            return repository.Create(Mapping<BLModel, DALModel>.FromBlToDal(item));
        }
        public BLModel GetById(int id)
        {
            return Mapping<BLModel, DALModel>.FromDalToBl(repository.FindById(id));
        }
    }
}
