using System;

// Define a generic factory interface
public interface IFactory<T>
{
    T Create();
}
public interface IUser
{
    Guid Id { get; set; }
    string Name { get; set; }
    string Password { get; set; }
}

public class User : IUser
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}

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
