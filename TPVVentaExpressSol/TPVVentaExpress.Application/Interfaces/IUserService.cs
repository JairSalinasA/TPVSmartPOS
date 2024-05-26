// TPVVentaExpress.Application/Interfaces/IUserService.cs
using TPVVentaExpress.Domain.Entities;

namespace TPVVentaExpress.Application.Interfaces
{
    public interface IUserService
    {
        bool ValidateUser(string username, string password);
        void RegisterUser(User user);
    }
}
