using System.Data.Entity;
using Club.Core.Domain;
using Club.Core.Domains;
using Club.Core.Domains.Coachs;
using Club.Core.Domains.Members;
using Club.Data.Mapping;

namespace Club.Data
{
   public class BaseDbContext : DbContext
    {
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Member> Persons { get; set; }
        public BaseDbContext() :base("ConnectionString") {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CoachConfig());
            modelBuilder.Configurations.Add(new ClosetConfig());
            modelBuilder.Configurations.Add(new DietConfig());
            modelBuilder.Configurations.Add(new ExerciseConfig());
            modelBuilder.Configurations.Add(new MemberConfig());
            modelBuilder.Configurations.Add(new MemberClosetConfig());
            modelBuilder.Configurations.Add(new MemberDietConfig());
            modelBuilder.Configurations.Add(new MemberExerciseConfig());
            modelBuilder.Configurations.Add(new MemberHistoryConfig());
            modelBuilder.Configurations.Add(new MemberPaymetConfig());
            modelBuilder.Configurations.Add(new MemberSchaduleConfig());
            modelBuilder.Configurations.Add(new MemberTrafficConfig());
            modelBuilder.Configurations.Add(new SansCoachConfig());
            modelBuilder.Configurations.Add(new SansConfig());
            modelBuilder.Configurations.Add(new SettingConfig());
        }
    }
}
