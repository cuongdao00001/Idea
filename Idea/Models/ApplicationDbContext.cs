using System.Data.Entity;
using System.Drawing.Printing;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Idea_System.Models
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public override IDbSet<IdentityUser> Users { get; set; }
        public IDbSet<Idea> Ideas { get; set; }
        public override IDbSet<IdentityRole> Roles { get; set; }
        public IDbSet<Department> Departments { get; set; }

        public IDbSet<Category> Categories { get; set; }
        public IDbSet<Document> Documents { get; set; }
        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<React> Reacts { get; set; }
        public IDbSet<View> View { get; set; }
        public ApplicationDbContext()
      : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<React>()
       .HasRequired(r => r.User)
       .WithMany(u => u.Reacts)
       .HasForeignKey(r => r.UserId)
       .WillCascadeOnDelete(false);

            modelBuilder.Entity<React>()
                .HasRequired(r => r.Idea)
                .WithMany(i => i.Reacts)
                .HasForeignKey(r => r.IdeaId)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<View>()
                .HasRequired(v => v.User)
                .WithMany()
                .HasForeignKey(v => v.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<View>()
                        .HasRequired(v => v.Idea)
                        .WithMany()
                        .HasForeignKey(v => v.IdeaId)
                        .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<Idea_System.Models.Topic> Topics { get; set; }

        public System.Data.Entity.DbSet<Idea_System.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}