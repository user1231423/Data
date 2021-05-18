using Common.Encoding.Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Chat.Models
{
    public class Message
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Message Body
        /// </summary>
        public string Body
        {
            get { return Body.Decrypt(); }
            set { value.Encrypt(); }
        }

        /// <summary>
        /// User Id
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Conversation id
        /// </summary>
        [Required]
        public int ConversationId { get; set; }

        /// <summary>
        /// Create Date
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

        /// <summary>
        /// Read messages
        /// </summary>
        public List<ReadMessage> ReadMessages { get; set; }

    }
}
