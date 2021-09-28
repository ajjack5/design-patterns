using System.Collections.Generic;

namespace DesignPatterns.Behavioural.Command.CSharp.Examples
{
    public class UserContext : DbContext
    {
        public IEnumerable<User> Users { get; set; } = new List<User> {
            new User { ID = 1, Name = "Person 1" },
            new User { ID = 2, Name = "Person 2" },
            new User { ID = 3, Name = "Person 3" },
            new User { ID = 4, Name = "Person 4" }
        };
    }
}
