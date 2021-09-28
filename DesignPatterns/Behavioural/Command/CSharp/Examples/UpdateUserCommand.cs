using System.Linq;

namespace DesignPatterns.Behavioural.Command.CSharp.Examples
{
    public class UpdateUserCommand : IUpdateUserCommand
    {
        private readonly UserContext _UserContext;

        public UpdateUserCommand(UserContext userContext)
        {
            _UserContext = userContext;
        }

        public User UpdateUser(User user)
        {
            // a more future-proof approach here would be to chain commands in the invoker, rather than also getting the value in here - not single responsibility
            var dbUser = _UserContext.Users.FirstOrDefault(x => x.ID == user.ID);
            
            dbUser.Name = user.Name;
            _UserContext.SaveChanges();

            return dbUser;
        }
    }
}
