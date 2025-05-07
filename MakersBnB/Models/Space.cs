namespace MakersBnB.Models;
using System.ComponentModel.DataAnnotations;

public class Space
{
  // the primary key is Id
  [Key]
  public int Id {get; set;}
  public string? Name {get; set;}
  public string? Description {get; set;}
  public int? Bedrooms {get; set;}
  public int? Price {get; set;}
  public string? Rules {get; set;}

  public Space(string name, string description, int bedrooms, int price, string rules) {
    this.Name = name;
    this.Description = description;
    this.Bedrooms = bedrooms;
    this.Price = price;
    this.Rules = rules;
  }

  // a zero argument constructor is required by Entity Framework
  public Space() {}
}
