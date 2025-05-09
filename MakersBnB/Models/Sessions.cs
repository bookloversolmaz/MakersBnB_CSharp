namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;

public class Sessions
{
    [Key]
    public int Id {get; set;}
    // Form should contain fields for username, email and password. Strings.
    public string? Email {get; set;}
    public string? Password {get; set;}

    public Sessions(string username, string email, string password) 
    {
        this.Email = email;
        this.Password = password;
    }

    // a zero argument constructor is required by Entity Framework to create instances of the model when it loads data from the database.
    public Sessions() {}
}