using MessageSender.Data;
using System.Collections.Generic;
using System.Linq;

namespace MessageSender.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User Get(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users;
        }

        public User GetByName(string name)
        {
            return _context.Users.FirstOrDefault(user => user.Name == name);
        }

        public User GetMessagesOf(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
