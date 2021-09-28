using System.Linq;

namespace DesignPatterns.Behavioural.Command.CSharp.Examples
{
    public class GetUserCommand : IGetUserCommand
    {
        private readonly UserContext _UserContext;

        public GetUserCommand(UserContext userContext)
        {
            _UserContext = userContext;
        }

        public User GetUser(int id)
        {
            return _UserContext.Users.FirstOrDefault(x => x.ID == id);
        }

        public User GetUser(string name)
        {
            return _UserContext.Users.FirstOrDefault(x => x.Name == name);
        }

        public User GetUser(int id, string name)
        {
            return _UserContext.Users.FirstOrDefault(x => x.ID == id && x.Name == name);
        }
    }
}
