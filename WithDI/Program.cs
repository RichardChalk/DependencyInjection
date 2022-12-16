using WithDI;

var notificationService = new ConsoleNotification();

var user1 = new User("Richard", notificationService);

user1.ChangeUserName("Richard the Lionheart (With DI)");

Console.ReadLine();


