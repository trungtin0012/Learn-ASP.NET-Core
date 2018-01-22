using System.ComponentModel.DataAnnotations;

namespace HelloWorld.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string Name { set; get; }

        [Required]
        [EmailAddress]
        public string Email { set; get; }

        [Required]
        [StringLength(4096, MinimumLength = 10) ]
        public string Message { set; get; }
    }
}
