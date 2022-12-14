// <auto-generated />
using AplicativoNotasWeb.context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AplicativoNotasWeb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AplicativoNotasWeb.Models.AnotacaoAbstrata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Anotacoes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AnotacaoAbstrata");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AplicativoNotasWeb.Models.AnotacaoFaculdade", b =>
                {
                    b.HasBaseType("AplicativoNotasWeb.Models.AnotacaoAbstrata");

                    b.Property<int>("AnotacaoFaculdadeId")
                        .HasColumnType("int");

                    b.Property<string>("NomedaAula")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomedaMateria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AnotacaoFaculdade");
                });

            modelBuilder.Entity("AplicativoNotasWeb.Models.AnotacaoProjeto", b =>
                {
                    b.HasBaseType("AplicativoNotasWeb.Models.AnotacaoAbstrata");

                    b.Property<int>("AnotacaoProjetoId")
                        .HasColumnType("int");

                    b.Property<string>("LinguagemProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProjeto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("AnotacaoProjeto");
                });
#pragma warning restore 612, 618
        }
    }
}
