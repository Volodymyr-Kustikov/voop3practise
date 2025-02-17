namespace ConsoleApp;

public struct Person
{
    public string FirstName;
    public string LastName;

    private string email;
    private string password;

    public string Email
    {
        get { return email; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Contains("@"))
                email = value;
        }
    }

    internal string Password
    {
        get { return password; }
        set
        {
            if (!string.IsNullOrEmpty(value) && value.Length > 6)
                password = value;
        }
    }
}