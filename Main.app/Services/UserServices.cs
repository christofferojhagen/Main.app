using System.Diagnostics;

namespace MainApp.Services;

public class UserServices
{

    private List<User> _users = [];

    public void CreateUser(User user)
    {
        try
        {
            if (!_users.Any(x => x.Email == user.Email) && !string.IsNullOrEmpty(user.Email)) 
            _users.Add(user);
        }

        catch (exeption ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
}