using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class CDL
{
    public int Id { get; set; }
    public String? Document { get; set; }
    public String? Description { get; set; }
    public String? Link { get; set; }
    public DateOnly DateUploaded { get; set; }
  
}
