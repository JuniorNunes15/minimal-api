
using Microsoft.EntityFrameworkCore;
using minimalApi.Dominio.Entidades;

namespace minimalApi.Infraestrutura.Db;

public class DbContexto : DbContext
{
    private readonly IConfiguration _configuracaoAPPSettings;
    public DbContexto(IConfiguration configuracaoAPPSettings)
    {
        _configuracaoAPPSettings = configuracaoAPPSettings;
    }

    public DbSet<Administrador> Administradores { get; set; } = default!;

    public DbSet<Veiculo> Veiculos { get; set; } = default!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administrador>().HasData(
            new Administrador
            {
                Id = 1,
                Email = "administrador@teste.com",
                Senha = "123456",
                perfil = "Adm"
            }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var stringDeConexao = _configuracaoAPPSettings.GetConnectionString("mysql")?.ToString();
            if (!string.IsNullOrEmpty(stringDeConexao))
            {
                optionsBuilder.UseMySql(
                stringDeConexao,
                ServerVersion.AutoDetect(stringDeConexao));
            }
        }
    }
}