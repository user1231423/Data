namespace Data.Chat.Models
{
    using Common.Encoding.Encryption;
    using System;

    public class UserRecentConversations
    {
        /// <summary>
        /// Body
        /// </summary>
        private string _Body = "";

        /// <summary>
        /// Conversation id
        /// </summary>
        public int ConversationId { get; set; }

        /// <summary>
        /// Total unread messages
        /// </summary>
        public int TotalUnreadMessages { get; set; }

        /// <summary>
        /// Total unread messages for user in this conversation
        /// </summary>
        public int TotalConversationUnreadMessages { get; set; }

        /// <summary>
        /// User id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Conversation start date
        /// </summary>
        public DateTime ConversationStartDate { get; set; }

        /// <summary>
        /// Conversation type
        /// </summary>
        public int ConversationType { get; set; }

        /// <summary>
        /// Conversation name
        /// </summary>
        public string ConversationName { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Message body
        /// </summary>
        public string MessageBody
        {
            get { return _Body.Decrypt(); }
            set { _Body = value.Encrypt(); }
        }

        /// <summary>
        /// Message author id
        /// </summary>
        public int MessageAuthorId { get; set; }

        /// <summary>
        /// Message date sent
        /// </summary>
        public DateTime MessageDateSent { get; set; }

        /// <summary>
        /// Message status
        /// </summary>
        public short MessageStatus { get; set; }
    }
}
