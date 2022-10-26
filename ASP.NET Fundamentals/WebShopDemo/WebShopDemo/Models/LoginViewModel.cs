using System.ComponentModel.DataAnnotations;

namespace WebShopDemo.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Email for login        
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;
        /// <summary>
        /// Password for login
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        /// <summary>
        /// When using forms authentication and the user is not authenticated or authorized the ASP.NET
        /// security pipeline will redirect to the login page and pass as a parameter in the query 
        /// string the returnUrl equal to the page that redirected to the login page. The login action
        /// grabs the value of this parameter and puts it in the ViewBag so it can be passed to the  View.
        /// </summary>
        [UIHint("hidden")]
        public string? ReturnUrl { get; set; } 
    }
}
