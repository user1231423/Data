using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Chat.Models
{
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
        [StringLength(50, ErrorMessage = "Max first name length is 50")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        [StringLength(50, ErrorMessage = "Max last name length is 50")]
        public string LastName { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email must be valid")]
        [StringLength(50, ErrorMessage = "Max email length is 50")]
        public string Email { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "Password is required")]
        [StringLength(64, ErrorMessage = "Max password length is 64")]
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

        /// <summary>
        /// User full name
        /// </summary>
        public string FullName {
            get { return FirstName + " " + LastName; }
        }

        /// <summary>
        /// Conversations
        /// </summary>
        public List<UserConversation> Conversations { get; set; }

        /// <summary>
        /// Kicked users
        /// </summary>
        public List<KickedUser> Kicks { get; set; }

        /// <summary>
        /// Invited Users
        /// </summary>
        public List<InvitedUser> Invites { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        public List<Message> Messages { get; set; }

        /// <summary>
        /// Read messages
        /// </summary>
        public List<ReadMessage> ReadMessages { get; set; }
    }
}
