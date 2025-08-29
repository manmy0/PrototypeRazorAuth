using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Summary
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? ProfileImage { get; set; }
    public string? GoalsCompleted { get; set; }
    public int NumConfidentCompentencies {  get; set; }
    public string? NumEmergingCompentencies { get; set; }
    public string? LogbookCompleted { get; set; }
    
}
