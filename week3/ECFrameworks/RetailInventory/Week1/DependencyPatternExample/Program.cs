// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger(); // Can be replaced with other loggers
        AuthService authService = new AuthService(logger);

        authService.Login("admin", "1234");
        authService.Login("user", "wrongpass");
    }
}

