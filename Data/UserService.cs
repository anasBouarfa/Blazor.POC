using System.Collections.Generic;
using System.Linq;

namespace Blazor.POC.Data;

public static class UserService
{
    private static readonly List<User> Users = new()
    {
        new User(1, "Alice", "alice@example.com"),
        new User(2, "Bob", "bob@example.com"),
        new User(3, "Charlie", "charlie@example.com")
    };

    public static IReadOnlyList<User> GetUsers() => Users;

    public static User? GetUser(int id) => Users.FirstOrDefault(u => u.Id == id);
}
