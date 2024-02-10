namespace Single_Responsibility_Principle;

public class EmailSender
{
    public void SendEmail(string emailAddress, string message)
    {
        // Code to send email
        Console.WriteLine("Email sent to " + emailAddress + ": " + message);
    }
}