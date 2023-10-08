using System;

/// <summary>
/// Factory interface for creating objects of type T
/// </summary>
public interface IFactory<T>
{
    /// <summary>
    /// Creates an instance of T
    /// </summary>  
    /// <returns>The created instance</returns>
    T Create();
}
/// <summary>
/// Represents a user in the system
/// </summary>
public interface IUser
{
    /// <summary>
    /// The unique ID of the user
    /// </summary>
    Guid Id { get; set; }
    /// <summary>
    /// The name of the user
    /// </summary>
    string Name { get; set; }
    string Password { get; set; }
}

public class User : IUser
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}

// UserFactory implementation remains the same...

// Usage:

public class UserView
{
    public string Name { get; set; }
    public string Password { get; set; }
}

// Non-generic IUserFactory
public interface IUserFactory : IFactory<IUser>
{
    IUser CreateUser(UserView userView);
}
public class UserFactory : IUserFactory
{
    public IUser Create()
    {
        throw new NotImplementedException();
    }
    public IUser CreateUser(UserView userView)
    {
        User  user = new User
        {
            Id = Guid.NewGuid(),
            Name = userView.Name,
            Password = userView.Password
        };
        return user;
    }
}
class Program
{
    static void Main(string[] args)
    {
        IUserFactory userFactory = new UserFactory();
        UserView userView = new UserView
        {
            Name = Tool.InputString("Name:"),
            Password = Tool.InputString("Password:")
        };
        var user = userFactory.CreateUser(userView);
        Console.WriteLine("---------------Info---------------");
        Console.WriteLine($"User id: {user.Id}");
        Console.WriteLine($"User Name: {user.Name}");
        Console.WriteLine($"User Password: {user.Password}");
        Console.WriteLine("-------------DefaultUser----------");
        Console.ReadKey();
    }
}

public static class Tool
{
    public static string InputString(string msg)
    {
        while (true)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Input can't be blank");
            }
        }
    }
}
