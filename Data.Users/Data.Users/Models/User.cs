namespace Data.Users.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        [Required(ErrorMessage = "First name is required")]
        [StringLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [StringLength(50, ErrorMessage = "Max first name length is 50")]
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must be valid")]
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        [StringLength(50, ErrorMessage = "Max password length is 50")]
        public string Password { get; set; }

        /// <summary>
        /// Status
        /// <para>1: Active</para>
        /// <para>0: Undefined</para>
        /// <para>-1: Disabled</para>
        /// </summary>
        [Range(-1, 1, ErrorMessage = "Status must be between -1 and 1")]
        public short Status { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
