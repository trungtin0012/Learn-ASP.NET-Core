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
        public string Subject { set; get; }

        [Required]
        [MaxLength(250)]
        public string Message { set; get; }
    }
}
