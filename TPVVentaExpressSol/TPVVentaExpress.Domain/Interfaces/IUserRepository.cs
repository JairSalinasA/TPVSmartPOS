// TPVVentaExpress.Domain/Interfaces/IUserRepository.cs
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Domain.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        void AddUser(User user);
    }
}
