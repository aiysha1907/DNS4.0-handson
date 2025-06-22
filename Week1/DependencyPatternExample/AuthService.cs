public class AuthService
{
    private readonly ILogger _logger;

    // Constructor Injection
    public AuthService(ILogger logger)
    {
        _logger = logger;
    }

    public void Login(string username, string password)
    {
        // Dummy check
        if (username == "admin" && password == "1234")
        {
            _logger.Log($"User '{username}' logged in successfully.");
        }
        else
        {
            _logger.Log($"Login failed for user '{username}'.");
        }
    }
}
