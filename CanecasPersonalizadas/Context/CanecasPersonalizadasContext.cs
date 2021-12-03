using CanecasPersonalizadas.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanecasPersonalizadas.Context
{
    public class CanecasPersonalizadasContext : DbContext
    {


        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ItemDeVenda> ItemDeVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<UsuarioMaster> UsuariosMaster { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=45.93.100.120;Initial Catalog=FS04;User ID=FS04;Password=040458;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;MultiSubnetFailover=False");
        }
    }
}
