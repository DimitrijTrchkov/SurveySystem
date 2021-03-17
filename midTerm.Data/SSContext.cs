using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;

namespace midTerm.Data
{
    public class SSContext : DbContext
    {
        public SSContext(DbContextOptions<SSContext> options) : base(options)
        {
        }

        public DbSet<SurveyUser> SurveyUsers { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyUser>(SurveyUser =>
            {
                SurveyUser.Property(s => s.FirstName).IsRequired();
                SurveyUser.Property(s => s.FirstName).HasMaxLength(600);
                SurveyUser.Property(s => s.Id).IsRequired();
                SurveyUser.HasKey(s => s.Id);
                SurveyUser.Property(s => s.LastName).IsRequired();
                SurveyUser.Property(s => s.LastName).HasMaxLength(600);
                SurveyUser.Property(s => s.Country).IsRequired();
                SurveyUser.Property(s => s.Country).HasMaxLength(600);
            });

            modelBuilder.Entity<Answers>(Answers =>
            {
                Answers.Property(a => a.Id).IsRequired();
                Answers.HasKey(a => a.Id);
                Answers.Property(a => a.UserId).IsRequired();
                Answers.HasKey(a => a.UserId);
                Answers.Property(a => a.OptionId).IsRequired();
                Answers.HasKey(a => a.OptionId);
                Answers.HasOne(a => a.User).WithMany().HasForeignKey(a => a.UserId);
                Answers.HasOne(a => a.Option).WithMany().HasForeignKey(a => a.OptionId);
            });

            modelBuilder.Entity<Option>(Option =>
            {
                Option.Property(s => s.Id).IsRequired();
                Option.HasKey(o => o.Id);
                Option.Property(o => o.Text).IsRequired();
                Option.Property(o => o.Text).HasMaxLength(600);
                Option.Property(s => s.NumOrder).IsRequired();
                Option.Property(s => s.QuestionId);
                Option.HasOne(s => s.Question).WithMany(s => s.Options).HasForeignKey(s => s.QuestionId);
            });

            modelBuilder.Entity<Question>(Question =>
            {
                Question.Property(s => s.Id).IsRequired();
                Question.HasKey(o => o.Id);
                Question.Property(o => o.Text).IsRequired();
                Question.Property(o => o.Text).HasMaxLength(600);
                Question.Property(o => o.Description).IsRequired();
                Question.Property(o => o.Text).HasMaxLength(600);
                Question.HasMany(o => o.Options).WithOne(o => o.Question).HasForeignKey(o => o.QuestionId);
            });
        }
    }
}
