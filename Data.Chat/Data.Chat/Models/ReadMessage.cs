namespace Data.Chat.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ReadMessage
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
        /// Message id
        /// </summary>
        [Required]
        public int MessageId { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// User
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public Message Message { get; set; }
    }
}
