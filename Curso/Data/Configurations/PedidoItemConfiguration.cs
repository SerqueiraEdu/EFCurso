using EFCurso.Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCurso.Curso.Data.Configurations
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> pedidoItem)
        {
            pedidoItem.ToTable("PedidoItens");
            pedidoItem.HasKey(  pedidoItem => pedidoItem.Id);
            pedidoItem.Property(pedidoItem => pedidoItem.Quantidade).HasDefaultValue(1).IsRequired();
            pedidoItem.Property(pedidoItem => pedidoItem.Valor).IsRequired();
            pedidoItem.Property(pedidoItem => pedidoItem.Desconto).IsRequired();
        }
    }
}
