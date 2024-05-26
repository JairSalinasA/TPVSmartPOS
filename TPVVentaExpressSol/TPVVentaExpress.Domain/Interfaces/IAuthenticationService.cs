using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVVentaExpress.Application.Interfaces
{
    public interface IAuthenticationService
    {
        bool ValidateCredentials(string username, string password);
        string GenerateToken(string username, string role);
    }

    //public class AuthenticationService : IAuthenticationService
    //{
    //    // Implementa los métodos de la interfaz
    //}
}
