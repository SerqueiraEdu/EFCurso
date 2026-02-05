using EFCurso.Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCurso.Curso.Data.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> pedido)
        {
            pedido.ToTable("Pedidos");
            pedido.HasKey(pedido => pedido.Id);
            pedido.Property(pedido => pedido.Iniciado).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            pedido.Property(pedido => pedido.StatusPedido).HasConversion<string>();
            pedido.Property(pedido => pedido.TipoFrete).HasConversion<string>();
            pedido.Property(pedido => pedido.Observacao).HasColumnType("VARCHAR(512)");

            pedido.HasMany(pedido => pedido.Items)
                .WithOne(pedido => pedido.Pedido)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
