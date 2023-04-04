namespace ChallengeAluraAdopet.API.Models;

public class Tutor
{
    public int Id { get; set; }

    private string name;
    private string email;
    private string password;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }
    public string Password
    {
        get
        {
            return password;
        }
        set
        {
            password = value;
        }
    }

}