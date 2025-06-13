
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjetoAPIFutebol.Data;
using ProjetoAPIFutebol.Models;

namespace ProjetoAPIFutebol.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ProjetoAPIFutebol.Models.Jogador", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd().HasColumnType("INTEGER");
                b.Property<string>("Nome").HasColumnType("TEXT");
                b.Property<string>("Posicao").HasColumnType("TEXT");
                b.Property<int>("NumeroCamisa").HasColumnType("INTEGER");
                b.Property<string>("Time").HasColumnType("TEXT");
                b.Property<System.DateTime>("DataNascimento").HasColumnType("TEXT");
                b.Property<float>("Altura").HasColumnType("REAL");
                b.Property<float>("Peso").HasColumnType("REAL");
                b.Property<string>("Nacionalidade").HasColumnType("TEXT");

                b.HasKey("Id");
                b.ToTable("Jogadores");
            });
        }
    }
}
