using OptimeProject.Models;

namespace OptimeProject.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUser();
        public Task<User?> GetUserById(int Id);
        public Task<bool> AddUser(User user);
        public Task<bool> EditUser(User user);
        public Task<bool> DeleteUser(int Id);
    }
}
