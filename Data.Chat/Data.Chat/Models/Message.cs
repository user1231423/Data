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
        /// Body
        /// </summary>
        private string _Body = "";

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
            get { return _Body.Decrypt(); }
            set { _Body = value.Encrypt(); }
        }

        /// <summary>
        /// Author Id
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// Conversation id
        /// </summary>
        public int ConversationId { get; set; }

        /// <summary>
        /// Create Date
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Update date
        /// </summary>
        public DateTime UpdateDate { get; set; }

    }
}
