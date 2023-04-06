using System.ComponentModel.DataAnnotations.Schema;

namespace ChallengeAluraAdopet.API.Models;

[Table(("Tutor"))]
public class Tutor
{
    [Column("id")]
    public int Id { get; set; }

    private string name;
    private string email;
    private string password;

    [Column("nome")]
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
    
    [Column("email")]
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
    
    [Column("senha")]
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