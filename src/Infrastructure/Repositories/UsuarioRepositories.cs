using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UsuarioRepositories : IRepository<Usuario>, IUsuarioRepositories
    {
        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> usuarios()
        {
            return new List<Usuario>();
        }
    }
}
