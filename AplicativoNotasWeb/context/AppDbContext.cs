using AplicativoNotasWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicativoNotasWeb.context

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        DbSet<AnotacaoFaculdade> AnotacoesFaculdade { get; set; }
        DbSet<AnotacaoProjeto> AnotacoesProjetos { get; set; }
        DbSet<AnotacaoAbstrata> Anotacoes { get; set; }

    }
}
