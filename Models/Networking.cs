using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Networking
{
    public int Id { get; set; }
    public String? Name { get; set; }
    public String? Company { get; set; }
    public String? ContactInfo { get; set; }
    public String? ProgressNotes { get; set; }
    public String? ElevatorPitch { get; set; }
    public String? CompaniesContact { get; set; }
    public String? Questions { get; set; }
    public String? UpcomingEvents { get; set; }

}
