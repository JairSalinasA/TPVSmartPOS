using System.Collections.Generic;
using TPVVentaExpress.Application.Interfaces;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Operaciones para Usuarios

        public User GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User GetByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }

        public void Add(User user)
        {
            _userRepository.Add(user);
        }

        public void Update(User user)
        {
            _userRepository.Update(user);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        } 

        // Operaciones para el Login
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }


        public bool ValidateUser(string username, string password)
        {
            var user = _userRepository.GetByUsername(username);
            return user != null && user.Password == password;
        }

        public void RegisterUser(User user)
        {
            _userRepository.Add(user);
        }

        public User GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
