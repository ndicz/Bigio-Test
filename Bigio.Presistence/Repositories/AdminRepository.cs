using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bigio.Persistence.RepositoryContext;
using Bigio.Presistence.Base;
using BigioDomain.Entities;
using BigioDomain.Repositories;

namespace Bigio.Presistence.Repositories
{
    public class AdminRepository : RepositoryBase<Admin>, IAdminRepository

    {
        public AdminRepository(AdoDbContext adoContext) : base(adoContext)
        {
        }

        public Task<IEnumerable<Admin>> FindAllAdminAsync()
        {
            throw new NotImplementedException();
        }

        public Admin FindAdminById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Edit(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void Remove(Admin admin)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> FindAllAdmin()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Admin> FindLastAdminId()
        {
            throw new NotImplementedException();
        }
    }
}
