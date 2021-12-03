using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Domain.Entities;


namespace Data
{
    public partial class RSDBContext: DbContext
    {
        public RSDBContext (): base("name=resetas-sabrosonasv3") {
            
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Profile> Profiles { get; set; }

        public virtual DbSet<Comment> Comments { get; set; }

        public virtual DbSet<Post> Posts { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Recipe> Recipes { get; set; }

        public virtual DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Profile>().ToTable("Profiles");
            modelBuilder.Entity<Post>().ToTable("Posts");
            modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Recipe>().ToTable("Recipes");
            modelBuilder.Entity<Score>().ToTable("Scores");


        }
    }
}
