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
        public int UserId { get; set; }

        /// <summary>
        /// Message id
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Create date
        /// </summary>
        public DateTime CreateDate { get; set; }
    }
}
