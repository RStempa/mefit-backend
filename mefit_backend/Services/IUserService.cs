﻿using mefit_backend.models.domain;
using System.Reflection;

namespace mefit_backend.Service
{
    public interface IUserService
    {
        public Task<User> GetUserById(int id);
        public Task<User> CreateUser(User user);
        public Task DeleteUser(int id);

        public Task<User> UpdateUser(User user);

        public Task<User> UpdateUserPassword(int id, string password);

    }
}
