using System.ComponentModel.DataAnnotations;


namespace WebShopDemo.Models
{
    public class RegisterViewModel
    {
        /// <summary>
        /// Email used for registering
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        /// <summary>
        /// Password chosen for registering
        /// The attribute DataType makes it hidden while inputting it
        /// </summary>
        [Required]
        [Compare(nameof(PasswordRepeat))]      

        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        /// <summary>
        /// Repeat chosen password
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string PasswordRepeat { get; set; } = null!;
        /// <summary>
        /// First name of new user
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;
        /// <summary>
        /// Last name of new user
        /// </summary>
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; } = null!;



    }
}
