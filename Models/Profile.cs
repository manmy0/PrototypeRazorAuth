using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Profile
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Introduction { get; set; }
    public string? LinkedIn { get; set; }
    public string? Resume {  get; set; }
    public string? SupportingDocuments { get; set; }
    public string? ProfessionalDocuments { get; set; }
    public string? Link1 { get; set; }
    public string? Link2 { get; set; }
    public string? Link3 { get; set; }
    public List<string>? Actions { get; set; }
}
