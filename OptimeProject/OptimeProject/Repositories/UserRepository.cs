using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using OptimeProject.Context;
using OptimeProject.Interfaces;
using OptimeProject.Models;

namespace OptimeProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly OptimeDbContext _context;
        public UserRepository(OptimeDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetAllUser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetUserById(int Id)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.ID == Id);
            return user;
        }

        public async Task<bool> AddUser(User user)
        {
            try
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> EditUser(User user)
        {
            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteUser(int Id)
        {
            var user = await GetUserById(Id);
            if (user == null)
                return false;

            try
            {
                _context.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
