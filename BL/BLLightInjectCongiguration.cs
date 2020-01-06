using NPoco;
using System;
using LightInject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace BL
{
	public class BLLightInjectCongiguration
	{
        public static ServiceContainer Congiguration(ServiceContainer container)
        {
            container.Register<IDatabase>(factory => new Database("DBBLOG"));
            container.Register(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return container;
        }
    }
}
