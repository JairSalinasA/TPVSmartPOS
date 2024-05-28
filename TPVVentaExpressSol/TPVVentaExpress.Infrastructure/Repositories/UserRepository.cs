using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;
using TPVVentaExpress.Infrastructure.Data;

namespace TPVVentaExpress.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.User.Find(id);
        }

        public User GetByUsername(string username)
        {
            return _context.User.FirstOrDefault(u => u.Username == username);
        }

        public void Add(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Entry(user).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.User.Find(id);
            if (user != null)
            {
                _context.User.Remove(user);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
            return _context.User.ToList();
        }

        public bool ValidateUser(string username, string password)
        {
            var user = GetByUsername(username);
            return user != null && user.Password == password;
        }

        public void RegisterUser(User user)
        {
            Add(user);
        }

        public User GetUserByUsername(string username)
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
