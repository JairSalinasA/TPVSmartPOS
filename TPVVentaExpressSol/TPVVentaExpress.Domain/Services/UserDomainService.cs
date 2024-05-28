using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Domain.Services
{ 
    public class UserDomainService
    {
        private readonly IUserRepository _userRepository;

        public UserDomainService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void CreateUser(User user)
        {
            // Lógica de negocio para crear un usuario
            _userRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            // Lógica de negocio para actualizar un usuario
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            // Lógica de negocio para eliminar un usuario
            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
    }
}
