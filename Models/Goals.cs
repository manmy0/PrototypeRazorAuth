using System.ComponentModel.DataAnnotations;

namespace PrototypeRazorApp.Models;
public class Goals
{
    public int Id { get; set; }
    public String? ProfessionalInterests { get; set; }
    public String? EmployersOfInterest { get; set; }
    public String? PersonalValues { get; set; }
    public String? DevelopmentFocus { get; set; }
    public String? SmartGoal { get; set; }
    public String? ActionSteps { get; set; }
    public String? Timeline { get; set; }
    public String? ProgressNotes { get; set; }
    public String? KeyLearnings { get; set; }
}
