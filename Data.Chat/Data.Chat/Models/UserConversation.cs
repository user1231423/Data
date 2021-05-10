namespace Data.Chat.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class UserConversation
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// User id
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Conversation id
        /// </summary>
        [Required]
        public int ConversationId { get; set; }

        /// <summary>
        /// Status
        /// <para>0: Normal</para>
        /// <para>1: Invited</para>
        /// <para>-1: Kicked</para>
        /// <para>-2: User left the conversation</para>
        /// </summary>
        [Required]
        [Range(-2, 1, ErrorMessage = "Value must be between -2 and 1")]
        public short Status { get; set; }

        /// <summary>
        /// Notification status
        /// <para>0: Undefined</para>
        /// <para>1: Active</para>
        /// <para>-1: Disabled</para>
        /// </summary>
        [Required]
        [Range(-1, 1, ErrorMessage = "Value must be between -1 and 1")]
        public short NotificationStatus { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Conversation
        /// </summary>
        public Conversation Conversation { get; set; }
    }
}
