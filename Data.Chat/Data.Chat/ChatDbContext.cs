namespace Data.Chat
{
    using Data.Authentication.Models;
    using Data.Chat.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Chat db context
    /// </summary>
    public class ChatDbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public ChatDbContext(DbContextOptions<ChatDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Users
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Conversations
        /// </summary>
        public DbSet<Conversation> Conversations { get; set; }

        /// <summary>
        /// Messages
        /// </summary>
        public DbSet<Message> Messages { get; set; }

        /// <summary>
        /// User conversations
        /// </summary>
        public DbSet<UserConversation> UserConversations { get; set; }

        /// <summary>
        /// Messages read
        /// </summary>
        public DbSet<ReadMessage> MessagesRead { get; set; }

        /// <summary>
        /// View User recent conversations
        /// </summary>
        public DbSet<UserRecentConversations> UserRecentConversations { get; set; }

        /// <summary>
        /// On model creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
