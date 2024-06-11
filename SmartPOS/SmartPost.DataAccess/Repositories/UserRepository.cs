using SmartPost.DataAccess.Contracts;
using SmartPost.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SmartPost.DataAccess.Repositories
{
    public class UserRepository : MasterRepository, IUserRepository
    {
        //Campos
        public string delete;
        public string getAll;
        public string getById;
        public string insert;
        public string update;


        //Constructores
        public UserRepository()
        {
            delete = "DELETE FROM Users WHERE UserID = @UserID";
            getAll = "SELECT * FROM Users";
            getById = "SELECT * FROM Users WHERE UserID = @UserID";
            insert = "INSERT INTO Users (FirstName, LastName, Email, Password, Phone, BirthDate, RegistrationDate, LastAccess, IsActive) " + "VALUES (@FirstName, @LastName, @Email, @Password, @Phone, @BirthDate, @RegistrationDate, @LastAccess, @IsActive)";
            update = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Password = @Password, " +"Phone = @Phone, BirthDate = @BirthDate, LastAccess = @LastAccess, IsActive = @IsActive " + "WHERE UserID = @UserID";

        }

        //Metodos, comportamientos
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(User entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@FirstName", entity.FirstName));
            parameters.Add(new SqlParameter("@LastName", entity.LastName));
            parameters.Add(new SqlParameter("@Email", entity.Email));
            parameters.Add(new SqlParameter("@Password", entity.Password));
            parameters.Add(new SqlParameter("@Phone", (object)entity.Phone ?? DBNull.Value));
            parameters.Add(new SqlParameter("@BirthDate", (object)entity.BirthDate ?? DBNull.Value));
            parameters.Add(new SqlParameter("@RegistrationDate", entity.RegistrationDate));
            parameters.Add(new SqlParameter("@LastAccess", entity.LastAccess));
            parameters.Add(new SqlParameter("@IsActive", entity.IsActive));
            return ExecuteNonQuery(insert);

        }

        public int Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
