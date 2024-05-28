// TPVVentaExpress.Domain/Interfaces/IUserRepository.cs
using System.Collections.Generic;
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Domain.Interfaces
{
    public interface IUserRepository
    {
        //Operaciones para Usuarios
        User GetById(int id);
        User GetByUsername(string username);
        void Add(User user);
        void Update(User user);
        void Delete(int id);
        IEnumerable<User> GetAll();

        //Operaciones para el Login 
        User GetUserByUsername(string username);
        void AddUser(User user);
    }
}
