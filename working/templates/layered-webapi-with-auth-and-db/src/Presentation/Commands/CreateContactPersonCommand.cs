using System.ComponentModel.DataAnnotations;
using $safeprojectname$.Presentation.Attributes;

namespace $safeprojectname$.Presentation.Commands
{
    public class CreateContactPersonCommand
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required, PhoneNumberValidation]
        public string PhoneNumber { get; set; }
        
        [Required, EmailValidation]
        public string Email { get; set; }
    }
}