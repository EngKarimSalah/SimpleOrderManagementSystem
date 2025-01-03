﻿using Microsoft.EntityFrameworkCore;
using SimpleOrderManagementSystem.Models;

namespace SimpleOrderManagementSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public int AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user.UId; // Return the newly created user's ID
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
