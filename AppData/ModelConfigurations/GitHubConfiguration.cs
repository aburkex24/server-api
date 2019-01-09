using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServerApi.AppData.Models;

namespace ServerApi.AppData.ModelConfigurations
{
    public class GitHubConfiguration : IEntityTypeConfiguration<GitHub>
    {
        public void Configure(EntityTypeBuilder<GitHub> builder)
        {
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedOn)
                .HasColumnType("timestamp")
                .IsRequired();
            
            builder.Property(x => x.CreatedAt)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(x => x.Description)
                .HasMaxLength(500);

            builder.Property(x => x.Forks)
                .ValueGeneratedNever();

            builder.Property(x => x.HtmlUrl)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.ProgrammingLanguage)
                .HasMaxLength(25);

            builder.Property(x => x.RepoName)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}