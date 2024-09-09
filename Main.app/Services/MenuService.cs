using MainApp.Services;

namespace MainApp.Service;
internal static class MenuService
{
    private static readonly UserServices = new UserService();

    private static void ExitApplication()
    {
        Environment.Exit(0);

    }
    private static void ListUser()
    {
        Environment.ListUser(2);

    }
    private static void MainMenu(string selectedOption)
    {

        if (int.TryParseselectedOptions(), out int option))
    {
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 0:
                    ExitApplication();
                    break;
                default:
                    break;
            }

        }
    }

    public static void MainMenu()
    {


        Console.Clear();
        Console.WriteLine("1. Create New User");
        Console.WriteLine("2 List All User");
        Console.WriteLine("0 Exit");

        Console.Write("Enter an option");
        

    }
}