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
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", id)
            };
            ExecuteNonQuery(delete);
        }

        public IEnumerable<User> GetAll()
        {
            DataTable table = ExecuteReader(getAll);
            List<User> users = new List<User>();

            foreach (DataRow row in table.Rows)
            {
                users.Add(new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Phone = row["Phone"] as string,
                    BirthDate = row["BirthDate"] as DateTime?,
                    RegistrationDate = Convert.ToDateTime(row["RegistrationDate"]),
                    LastAccess = Convert.ToDateTime(row["LastAccess"]),
                    IsActive = Convert.ToBoolean(row["IsActive"])
                });
            }
            return users;
        }

        public User GetById(int id)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", id)
            };

            DataTable table = ExecuteReader(getById);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                return new User
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Phone = row["Phone"] as string,
                    BirthDate = row["BirthDate"] as DateTime?,
                    RegistrationDate = Convert.ToDateTime(row["RegistrationDate"]),
                    LastAccess = Convert.ToDateTime(row["LastAccess"]),
                    IsActive = Convert.ToBoolean(row["IsActive"])
                };
            }
            return null;
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
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", entity.UserID),
                new SqlParameter("@FirstName", entity.FirstName),
                new SqlParameter("@LastName", entity.LastName),
                new SqlParameter("@Email", entity.Email),
                new SqlParameter("@Password", entity.Password),
                new SqlParameter("@Phone", (object)entity.Phone ?? DBNull.Value),
                new SqlParameter("@BirthDate", (object)entity.BirthDate ?? DBNull.Value),
                new SqlParameter("@LastAccess", entity.LastAccess),
                new SqlParameter("@IsActive", entity.IsActive)
            };
            return ExecuteNonQuery(update);
        }
    }
}
