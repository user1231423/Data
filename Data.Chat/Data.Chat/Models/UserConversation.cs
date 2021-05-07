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
        public int UserId { get; set; }

        /// <summary>
        /// Conversation id
        /// </summary>
        public int ConversationId { get; set; }

        /// <summary>
        /// Status
        /// <para>0: Added when conversation was created</para>
        /// <para>1: Invited</para>
        /// <para>-1: Kicked</para>
        /// <para>-2: User left the conversation</para>
        /// </summary>
        public short Status { get; set; }

        /// <summary>
        /// Invite user id
        /// </summary>
        public int InviteUserId { get; set; }

        /// <summary>
        /// Kick user id
        /// </summary>
        public int KickUserId { get; set; }

        /// <summary>
        /// Notificaiton status
        /// </summary>
        public short NotificationStatus { get; set; }

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
