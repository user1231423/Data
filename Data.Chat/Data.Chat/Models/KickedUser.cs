namespace Data.Chat.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class KickedUser
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// User id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Conversation id
        /// </summary>
        public int ConversationId { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

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
