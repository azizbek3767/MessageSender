using System.Collections.Generic;

namespace MessageSender.Models.Repositories
{
    public interface IUserRepository
    {
        User Get(int id);
        User GetByName(string name);
        IEnumerable<User> GetAll();
        User GetMessagesOf(User user);
        User Create(User user);
    }
}
