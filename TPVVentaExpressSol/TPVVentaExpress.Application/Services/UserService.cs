// TPVVentaExpress.Application/Services/UserService.cs
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

        public bool ValidateUser(string username, string password)
        {
            var user = _userRepository.GetUserByUsername(username);
            return user != null && user.Password == password;
        }

        public void RegisterUser(User user)
        {
            _userRepository.AddUser(user);
        }
    }
}
