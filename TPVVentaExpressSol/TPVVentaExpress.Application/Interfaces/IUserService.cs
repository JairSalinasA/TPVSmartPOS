// TPVVentaExpress.Application/Interfaces/IUserService.cs
using System.Collections.Generic;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Application.Interfaces
{
    public interface IUserService
    {
        //Operaciones Para Usuarios
        User GetById(int id);
        User GetByUsername(string username);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        IEnumerable<User> GetAll();
        //operaciones para login 
        bool ValidateUser(string username, string password);
        void RegisterUser(User user);  
    }
}
