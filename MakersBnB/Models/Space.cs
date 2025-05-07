namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;

public class Space
{
  // some fields
  // the ? indicates that a field can be null / blank (is nullable)
  // {get; set;} tells the compiler to create getter and setter methods
  public string? Name {get; set;}
  public string? Description {get; set;}
  public int? Price {get; set;}

  // the constructor
  public Space(string name, string description, int price) {
    this.Name = name;
    this.Description = description;
    this.Price = price;
  }
}
