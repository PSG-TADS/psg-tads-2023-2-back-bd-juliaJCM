using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema_Cobranca
{
    internal class Program
    {

        public class Cliente
        {
            [Key]
            public int Id { get; set; }
            public string? CPF { get; set; }
            public string? Nome { get; set; }
            public string? Email { get; set; }
            public int Senha { get; set; }
        }

        public class Veiculo
        {
            [Key]
            public string? Placa { get; set; }
            public string? Modelo { get; set; }
            public int ClienteId { get; set; }
            [ForeignKey("ClienteId")]
            public int cliente { get; set; }
            public int Tag_id { get; set; }
            [ForeignKey("Tag_id")]
            public int tag { get; set; }
        }

        public class Tag
        {
            [Key]
            public int NumTag { get; set; }
            public int portaID { get; set; }
            [ForeignKey("portaID")]
            public int porta { get; set; }
        }

        public class Estacionamento
        {
            [Key]
            public int Porta { get; set; }
            public DateTime HoraSaida { get; set; }
            public DateTime HoraEntrada { get; set; }
        }

        public class Faturamento
        {
            [Key]
            public int NumFaturamento { get; set; }
            public double Valor { get; set; }
            public string? MetodoPagamento { get; set; }
            public int ClienteId { get; set; }
            [ForeignKey("ClienteId")]
            public int cliente { get; set; }
        }

        public class ApplicationContext : DbContext
        {
            public DbSet<Cliente> Clientes { get; set; }
            public DbSet<Veiculo> Veiculos { get; set;}
            public DbSet<Tag> Tags { get; set; }
            public DbSet<Estacionamento> Portas { get; set; }
            public DbSet<Faturamento> Faturamentos { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                _ = optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TrabEstacionamento;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }
