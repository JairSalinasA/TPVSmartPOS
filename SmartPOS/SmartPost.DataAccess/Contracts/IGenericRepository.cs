using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPost.DataAccess.Contracts
{
    public interface IGenericRepository<Entity>where Entity:class
    {
        int Insert(Entity entity);
        int Update(Entity entity);
        void Delete(int id);
        Entity GetById(int id);
        IEnumerable<Entity> GetAll();
    }
}
