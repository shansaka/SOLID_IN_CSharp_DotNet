The Single Responsibility Principle (SRP) states that a class should have only one reason to change, meaning it should have only one responsibility. 

We could have write this program like this:


    public class UserManagement
    {
        public void AddUser(string username)
        {
            // Code to add user to the database
            Console.WriteLine("User added to the database: " + username);
        }
    
        public void SendEmail(string emailAddress, string message)
        {
            // Code to send email
            Console.WriteLine("Email sent to " + emailAddress + ": " + message);
        }
    }

But this say user managment class handling addming users and sending emails. Which is violate this principle. 
Look at the code in this repo.
