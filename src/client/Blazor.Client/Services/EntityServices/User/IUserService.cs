using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazor.Client.Models;
using blazor.Dto;

namespace blazor.Client.Services.EntityServices.User
{
    public interface IUserService
    {
        public Task<IList<UserModel>> GetAll();

        public Task<UserModel> Get(string id);

        public Task Add(UserModel model);

        Task Update(UserModel model);

        Task Delete(string id);

        Task<IEnumerable<string>> GetAllAuthorities(); 
    }
}
