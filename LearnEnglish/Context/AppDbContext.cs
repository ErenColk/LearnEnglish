using LearnEnglish.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEnglish.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("Server=DESKTOP-5S3MNPI;Database=LearnEnglish;Uid=sa;Pwd=123;")
        {

            
        }

        public DbSet<EnglishWord> EnglishWords { get; set; }
        public DbSet<TurkishWord> TurkishWords{ get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnglishWord>().HasKey(x => x.Id);
            modelBuilder.Entity<TurkishWord>().HasKey(x => x.Id);

            modelBuilder.Entity<TurkishWord>()
                .HasRequired(t => t.EnglishWord)
                .WithMany()
                .HasForeignKey(t => t.EnglishWordId)
                .WillCascadeOnDelete(false);  

            base.OnModelCreating(modelBuilder);


        }
    }
}
