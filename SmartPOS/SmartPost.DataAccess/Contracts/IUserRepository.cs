﻿using SmartPost.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPost.DataAccess.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
