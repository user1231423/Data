namespace Data.Chat
{
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
        //public DbSet<UserRecentConversations> UserRecentConversations { get; set; }

        /// <summary>
        /// Kicked users
        /// </summary>
        public DbSet<KickedUser> KickedUsers { get; set; }

        /// <summary>
        /// Invited users
        /// </summary>
        public DbSet<InvitedUser> InvitedUsers { get; set; }

        /// <summary>
        /// On model creating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvitedUser>().ToTable("ConversationInvitedUsers");
            modelBuilder.Entity<KickedUser>().ToTable("ConversationKickedUsers");
            modelBuilder.Entity<ReadMessage>().ToTable("UserMessagesRead");
            modelBuilder.Entity<Message>().ToTable("ConversationMessages");

            modelBuilder.Entity<User>()
                .HasMany(x => x.Conversations)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Invites)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Kicks)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.User);

            modelBuilder.Entity<User>()
                .HasMany(x => x.Messages)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.UserId);

            modelBuilder.Entity<User>()
                .HasMany(x => x.ReadMessages)
                .WithOne(y => y.User)
                .HasForeignKey(z => z.UserId);

            modelBuilder.Entity<Conversation>()
                .HasMany(x => x.Messages)
                .WithOne(y => y.Conversation)
                .HasForeignKey(z => z.ConversationId);

            modelBuilder.Entity<Conversation>()
                .HasMany(x => x.InvitedUsers)
                .WithOne(y => y.Conversation)
                .HasForeignKey(z => z.ConversationId);

            modelBuilder.Entity<Conversation>()
                .HasMany(x => x.KickedUsers)
                .WithOne(y => y.Conversation)
                .HasForeignKey(z => z.ConversationId);

            modelBuilder.Entity<Conversation>()
                .HasMany(x => x.Users)
                .WithOne(y => y.Conversation)
                .HasForeignKey(z => z.ConversationId);

        }
    }
}
