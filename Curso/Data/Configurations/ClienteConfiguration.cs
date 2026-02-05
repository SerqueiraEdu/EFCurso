using EFCurso.Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCurso.Curso.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> cliente)
        {
            cliente.ToTable("Clientes");
            cliente.HasKey(cliente => cliente.Id);
            cliente.Property(cliente => cliente.Nome).HasColumnType("VARCHAR(60)").IsRequired();
            cliente.Property(cliente => cliente.Telefone).HasColumnType("CHAR(11)");
            cliente.Property(cliente => cliente.CEP).HasColumnType("CHAR(8)").IsRequired();
            cliente.Property(cliente => cliente.Estado).HasColumnType("CHAR(2)").IsRequired();
            cliente.Property(cliente => cliente.Cidade).HasMaxLength(60).IsRequired();
            cliente.HasIndex(cliente => cliente.Telefone).HasDatabaseName("idx_cliente_telefone");
        }
    }
}