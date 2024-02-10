namespace Single_Responsibility_Principle;

public class UserManager
{
    public void AddUser(string username)
    {
        // Code to add user to the database
        Console.WriteLine("User added to the database: " + username);
    }
}