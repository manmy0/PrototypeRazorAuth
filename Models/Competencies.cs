using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Competencies
{
    public int Id { get; set; }
    public int Num { get; set; }
    public String? Competency { get; set; }
    public String? Description { get; set; }
    public String? Level { get; set; }  
    public String? EvidenceLink { get; set; }
    public String? ReflectionLink { get; set; }

}
