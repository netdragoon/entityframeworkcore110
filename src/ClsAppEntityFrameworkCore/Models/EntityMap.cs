using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace ClsAppEntityFrameworkCore.Models
{
    public abstract class EntityMap<T>
        where T: class, new()
    {
        public abstract void Map(EntityTypeBuilder<T> entity);            
    }

    public class ClientMap : EntityMap<Client>
    {
        
        public override void Map(EntityTypeBuilder<Client> entity)            
        {
            entity.ToTable("Client");

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Id)
                .IsRequired()
                .UseSqlServerIdentityColumn();

            entity.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(c => c.Created)
                .IsRequired();

            entity.Property(c => c.Active)
                .IsRequired();

            entity.HasMany(c => c.Phones)
                .WithOne(c => c.Client)
                .HasForeignKey(k => k.ClientId)
                .HasPrincipalKey(k => k.Id)
                .IsRequired();
        }

        public static void Create(EntityTypeBuilder<Client> entity)
        {
            new ClientMap().Map(entity);
        }
    }

    public class PhoneMap : EntityMap<Phone>
    {
        public override void Map(EntityTypeBuilder<Phone> entity)
        {
            entity.ToTable("Phone");

            entity.HasKey(c => c.Id);

            entity.Property(c => c.Id)
                .IsRequired()
                .UseSqlServerIdentityColumn();

            entity.Property(c => c.Ddd)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(c => c.Number)
                .IsRequired()
                .HasMaxLength(14);

            entity.Property(c => c.Active)
                .IsRequired();

            entity.Property(c => c.ClientId)
                .IsRequired();

            entity.HasOne(c => c.Client)
                .WithMany(c => c.Phones)
                .HasForeignKey(k => k.ClientId)
                .HasPrincipalKey(k => k.Id);
        }
        public static void Create(EntityTypeBuilder<Phone> entity)
        {
            new PhoneMap().Map(entity);
        }
    }
}
