using Single_Responsibility_Principle;

UserManager userManager = new UserManager();
userManager.AddUser("Alice");

EmailSender emailSender = new EmailSender();
emailSender.SendEmail("alice@example.com", "Welcome to our platform!");