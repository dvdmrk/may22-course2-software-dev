using System.ComponentModel.DataAnnotations;

public class Movie
{
    [Key]
    public int ID { get; set; }
    public string Title { get; set; }
    public string? Director { get; set; }
    public double? Budget { get; set; }
    [Display(Name = "Box Office Profit")]
    public double? Profit { get; set; }
    public string? Actor { get; set; }
    public int YearReleased {get;set;}
}
