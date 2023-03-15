using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Repositories;
using Infrastructure.Interfaces;


namespace Infrastructure.Services
{

    public class UsuarioService : IUsuarioService 
    {
        private readonly IUsuarioRepositories _repos;
        public UsuarioService(IUsuarioRepositories repos)
        {
            _repos = repos;
        }

        public void InsertUsuario(Usuario user)
        {
            if (user != null)
            {
                _repos.InsertAsync(user).Wait();  

            }

        }

        public async Task<List<Usuario>> ListUsuario()
        {
            
           var listUser = _repos.GetAllAsync().Result.ToList(); 
            return listUser;

        }

    }
}
