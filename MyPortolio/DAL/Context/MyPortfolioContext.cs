using Microsoft.EntityFrameworkCore;
using MyPortolio.DAL.Entities;

namespace MyPortolio.DAL.Context
{
    public class MyPortfolioContext : DbContext
    {
        public MyPortfolioContext(DbContextOptions<MyPortfolioContext> options) : base(options) 
        {
            
        }

        public DbSet<About> Abouts => Set<About>();
        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<Experince> Experinces => Set<Experince>();
        public DbSet<Feature> Features => Set<Feature>();
        public DbSet<Message> Messages => Set<Message>();
        public DbSet<Portfollio> Portfollios => Set<Portfollio>();
        public DbSet<Skill> Skills => Set<Skill>();
        public DbSet<SocialMedia> SocialMedias => Set<SocialMedia>();
        public DbSet<Testimonial> Testimonials => Set<Testimonial>();

    }
}
