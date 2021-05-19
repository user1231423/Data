using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Chat.Models
{
    public class Conversation
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// <para>1: Private</para>
        /// <para>2: Group</para>
        /// </summary>
        [Required]
        [Range(1, 2, ErrorMessage = "Value must be between 1 and 2")]
        public byte Type { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        [StringLength(255, ErrorMessage = "Max conversation name lenght is 255")]
        public string Name { get; set; }

        /// <summary>
        /// Date started
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.Now;
        
        /// <summary>
        /// Update date
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        public List<Message> Messages { get; set; }

        /// <summary>
        /// Users
        /// </summary>
        public List<UserConversation> Users { get; set; }

        /// <summary>
        /// Kicked users
        /// </summary>
        public List<KickedUser> KickedUsers { get; set; }

        /// <summary>
        /// Invited users
        /// </summary>
        public List<InvitedUser> InvitedUsers { get; set; }
    }
}
