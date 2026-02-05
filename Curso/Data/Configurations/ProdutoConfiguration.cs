using EFCurso.Curso.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCurso.Curso.Data.Configurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> produto)
        {
            produto.ToTable("Produtos");
            produto.HasKey(produto => produto.Id);
            produto.Property(produto => produto.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
            produto.Property(produto => produto.Descricao).HasColumnType("VARCHAR(60)");
            produto.Property(produto => produto.Valor).IsRequired();
            produto.Property(produto => produto.TipoProduto).HasConversion<string>();
        }
    }
}
