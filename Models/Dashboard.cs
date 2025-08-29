using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Dashboard
{
    public int Id { get; set; }
    public String? Competency {  get; set; }
    public int NumExamples { get; set; }
    public string? HighestLevel { get; set; }

}
